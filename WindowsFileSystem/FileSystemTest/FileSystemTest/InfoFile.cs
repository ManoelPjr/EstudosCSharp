using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemTest
{
    public class InfoFile
    {
        FileInfo fileInfo;
        public InfoFile(string path)
        {
            fileInfo = new FileInfo(path);
        }

        public string FullName()
        {            
            return fileInfo.FullName;
        }
        public string Extension()
        {
            return fileInfo.Extension;
        }
        public long Length()
        {
            return fileInfo.Length;
        }
    }
}
