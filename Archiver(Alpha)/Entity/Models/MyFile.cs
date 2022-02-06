using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver_Alpha_.Entity.Interfaces;

namespace Archiver_Alpha_.Entity.Models
{
    public class MyFile : IBaseFile
    {
        public string Name { get; set; }
        public string Extension { get; set; } 
        public string Path { get; set; }
        public DateTime CreationTime { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is MyFile file) 
                return Name == file.Name && CreationTime == file.CreationTime;
            return false;
        }

        public override int GetHashCode()
        {
            return CreationTime.GetHashCode();
        }
    }
}
