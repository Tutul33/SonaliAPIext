using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.FileManagement
{
    public class FileManager : IFileManager
    {
        private readonly FileUploadSettings _settings;
        public string BasePath => _settings.BasePath;

        public FileManager(IOptions<FileUploadSettings> options)
        {
            _settings = options.Value;

            if (!Directory.Exists(_settings.BasePath))
                Directory.CreateDirectory(_settings.BasePath);
        }

        private void ValidateFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is empty.");

            var extension = Path.GetExtension(file.FileName).ToLower();
            if (!_settings.AllowedExtensions.Contains(extension))
                throw new ArgumentException($"File type '{extension}' not allowed.");

            if (file.Length > _settings.MaxFileSizeMB * 1024 * 1024)
                throw new ArgumentException($"File exceeds max size of {_settings.MaxFileSizeMB} MB.");
        }

        public async Task<List<string>> UploadFilesAsync(List<IFormFile> files, string relativeFolderPath)
        {
            if (files == null || !files.Any())
                throw new ArgumentException("No files to upload");

            var fullFolderPath = Path.Combine(BasePath, relativeFolderPath);
            if (!Directory.Exists(fullFolderPath))
                Directory.CreateDirectory(fullFolderPath);

            var uploadedPaths = new List<string>();

            foreach (var file in files)
            {
                ValidateFile(file);

                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
                var filePath = Path.Combine(fullFolderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //uploadedPaths.Add(Path.Combine(relativeFolderPath, fileName));
                uploadedPaths.Add(fileName);
            }

            return uploadedPaths;
        }

        public async Task<string> ReplaceFileAsync(string oldRelativePath, IFormFile newFile, string relativeFolderPath)
        {
            // Delete old file
            if (!string.IsNullOrEmpty(oldRelativePath))
            {
                DeleteFile(oldRelativePath);
            }

            // Upload new file
            var uploaded = await UploadFilesAsync(new List<IFormFile> { newFile }, relativeFolderPath);
            return uploaded.First();
        }

        public void DeleteFile(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath))
                return;

            var fullPath = Path.Combine(BasePath, relativePath);
            if (File.Exists(fullPath))
                File.Delete(fullPath);//Delete File
        }
        public void DeleteFolder(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath))
                return;

            var fullPath = Path.Combine(BasePath, relativePath);
            if (Directory.Exists(fullPath))
            {
                Directory.Delete(fullPath, recursive: true); // deletes folder + all contents
            }
        }
    }
}
