using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver_Alpha_.Services;

namespace Archiver_Alpha_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchiveService archiveService = new ArchiveService();
            archiveService.AddFileToArchive(@"C:\Users\Ivan\Desktop\test\", "*.pdf");
        }
    }
}
