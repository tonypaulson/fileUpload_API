using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace file_upload.Data
{
    public class file
    {
        public int Id { get; set; }
        public string Bucket { get; set; }
        public string key { get; set; }
        public string Location { get; set; }
        public string filename { get; set; }
    }
}
