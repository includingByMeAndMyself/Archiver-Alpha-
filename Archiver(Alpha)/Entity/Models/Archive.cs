using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver_Alpha_.Entity.Interfaces;

namespace Archiver_Alpha_.Entity.Models
{
    public class Archive : IBaseFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public DateTime CreationTime { get; set; }

        private List<MyFile> _files = new List<MyFile>();
        public List<MyFile> Files
        {
            get
            {
                return _files;
            }
            set
            {
                _files = value;
            }
        }
    }
}
 