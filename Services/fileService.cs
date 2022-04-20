using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using file_upload.Data;
using file_upload.Models;

namespace file_upload.Services
{
    public class fileService
    {
        private readonly FileUploadContext _fileUploadContext;

        public fileService(FileUploadContext fileUploadContext)
        {
            _fileUploadContext = fileUploadContext;
        }

        public async Task<int>AddFile(fileModel fileModel)
        {
            var files = new file()
            {
                Bucket = fileModel.Bucket,
                key = fileModel.key,
                Location = fileModel.Location,
                filename = fileModel.filename
            };
            _fileUploadContext.file.Add(files);
            await _fileUploadContext.SaveChangesAsync();
            return files.Id;
        }
    }
}
