using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities
{
    public class FileUploadSettings
    {
        public string BasePath { get; set; } = string.Empty;
        public int MaxFileSizeMB { get; set; } = 10;
        public List<string> AllowedExtensions { get; set; } = new List<string>();
    }

}
