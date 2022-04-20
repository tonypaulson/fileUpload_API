using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace file_upload.Data
{
    public class FileUploadContext:DbContext
    {

        public FileUploadContext(DbContextOptions<FileUploadContext> options) : base(options)
        {
        }

        public DbSet<file> file { get; set; }
    }
}
