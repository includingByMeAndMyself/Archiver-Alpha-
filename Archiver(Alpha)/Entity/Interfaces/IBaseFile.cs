using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver_Alpha_.Entity.Interfaces
{
    public interface IBaseFile
    {
        string Name { get; set; }
        string Path { get; set; }
        string Extension { get; set; }
        DateTime CreationTime { get; set; }
    }
}
