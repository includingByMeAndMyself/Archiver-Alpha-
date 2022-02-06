using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver_Alpha_.Entity.Models;

namespace Archiver_Alpha_.Services
{
    public class ArchiveService
    {
        private Archive _archive = new Archive();
        private MyFile _file = new MyFile();

        private void CreateArchive(List<MyFile> files)
        {
            
        }

        public void AddFileToArchive(string path, string extension)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    var result = Directory.EnumerateFiles(path, extension).ToList();
                    if (result.Count != 0)
                    {
                        foreach (var file in result)
                        {
                            _file.Name = Path.GetFileNameWithoutExtension(file);
                            _file.Extension = Path.GetExtension(file);
                            _file.Path = file;
                            _file.CreationTime = File.GetCreationTime(file);
                            
                            if (_file.CreationTime.Month != DateTime.Now.Month &&
                                _file.CreationTime.Year != DateTime.Now.Year)
                            {
                                _archive.Files.Add(_file);
                            }
                            else
                            {
                                Console.WriteLine($" File {_file.Name} is still too early to archive, it dates from the current month !");
                            }
                        }
                        CreateArchive(_archive.Files);
                    }
                    else
                    {
                        Console.WriteLine($" File with extension \"{extension}\" does not exist on path \"{path}\"!");
                    }
                }
                else
                {
                    Console.WriteLine($" No directory on path \"{path}\"!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }    
            
        }
    }
}
 