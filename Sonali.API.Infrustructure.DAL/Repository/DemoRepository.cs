using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Entities.Demo;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Infrustructure.Data.Models;
using Sonali.API.Utilities.FileManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrustructure.DAL.Repository
{
    public class DemoRepository : IDemoRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public DemoRepository(AppDbContext dbContext, IMapper mapper, IFileManager fileManager)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext), "Database context cannot be null");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), "Mapper cannot be null");
            _fileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }
        public async Task<DemoDTO> Save(DemoDTO demo, List<IFormFile> files)
        {
            try
            {
                if (demo == null)
                    throw new ArgumentNullException(nameof(demo), "Demo cannot be null");
                if (files == null || !files.Any())
                {
                    throw new ArgumentException("Files cannot be null or empty", nameof(files));
                }
                var demoEntity = demo as Demos;// Please explain that
                var demoObj = _mapper.Map<AccDemo>(demoEntity);
                demoObj.IsActive = true;
                demoObj.CreateDate = DateTime.Now;
                _dbContext.AccDemos.Add(demoObj);


                await _dbContext.SaveChangesAsync();
                demo.Id = demoObj.Id;
                await UpdateDemoItem(demoObj.Id, demo.DemoItems, files);

                return demo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task UpdateDemoItem(int demoId, List<DemoItems> demoItems, List<IFormFile> files)
        {
            foreach (var item in demoItems)
            {
                switch (item.Tag)
                {
                    case EntityState.Added:
                        var entity = _mapper.Map<AccDemoItem>(item);
                        entity.DemoId = demoId;
                        entity.IsActive = true;
                        _dbContext.AccDemoItems.Add(entity);
                        await _dbContext.SaveChangesAsync();

                        item.Id = entity.Id;
                        item.DemoId = demoId;
                        if (entity.Id > 0)
                            await UpdateDemoItemAttachment(entity.Id, item.DemoItemFileAttachments, files);
                        break;

                    case EntityState.Modified:
                        var existing = _mapper.Map<AccDemoItem>(item);
                        _dbContext.AccDemoItems.Update(existing);
                        await _dbContext.SaveChangesAsync();

                        await UpdateDemoItemAttachment(existing.Id, item.DemoItemFileAttachments, files);
                        break;

                    case EntityState.Deleted:
                        var toDelete = await _dbContext.AccDemoItems.FindAsync(item.Id);
                        if (toDelete != null)
                        {
                            _dbContext.AccDemoItems.Remove(toDelete);
                            await _dbContext.SaveChangesAsync();

                            await UpdateDemoItemAttachment(item.Id, item.DemoItemFileAttachments, files);
                        }
                        break;
                }
            }
        }

        private async Task UpdateDemoItemAttachment(int demoItemId, List<DemoItemFileAttachments> attachments, List<IFormFile> files)
        {
            string folder = Path.Combine("Demos", demoItemId.ToString());

            foreach (var att in attachments)
            {
                switch (att.Tag)
                {
                    case EntityState.Added:
                        var file = files.FirstOrDefault(f => f.FileName == att.FileName);
                        if (file != null)
                        {
                            var uploaded = await _fileManager.UploadFilesAsync(new List<IFormFile> { file }, folder);
                            var entityIn = new AccDemoItemFileAttachment
                            {
                                DemoItemId = demoItemId,
                                FileName = uploaded.First(),
                                IsActive = true
                            };
                            _dbContext.AccDemoItemFileAttachments.Add(entityIn);
                            await _dbContext.SaveChangesAsync();
                            att.Id = entityIn.Id; 
                            att.DemoItemId= demoItemId;
                        }
                        break;

                    case EntityState.Modified:
                        var fileUpdate = files.FirstOrDefault(f => f.FileName == att.FileName);
                        if (fileUpdate != null)
                        {
                            var newPath = await _fileManager.ReplaceFileAsync(att.FileName, fileUpdate, folder);
                            att.FileName = newPath;
                            _dbContext.AccDemoItemFileAttachments.Update(_mapper.Map<AccDemoItemFileAttachment>(att));
                            await _dbContext.SaveChangesAsync();
                        }
                        break;

                    case EntityState.Deleted:
                        var entity = await _dbContext.AccDemoItemFileAttachments.FindAsync(att.Id);
                        if (entity != null)
                        {
                            _fileManager.DeleteFile(entity.FileName);
                            _dbContext.AccDemoItemFileAttachments.Remove(entity);
                            await _dbContext.SaveChangesAsync();
                        }
                        break;
                }
            }

            
        }

    }
}
