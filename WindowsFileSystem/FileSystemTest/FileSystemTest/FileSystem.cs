using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemTest
{
    public class FileSystem
    {
        public bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void DeleteDirectory(string path, bool recursive = true) 
        {
            Directory.Delete(path, true);
        }
        public void MoveDirectory(string srcPath, string destPath)
        {
            Directory.Move(srcPath, destPath);
        }
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
        public char DirectorySeparatorChar
        {
            get { return Path.DirectorySeparatorChar; }
        }
        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public void WriteAllText(string path, string text)
        {
            File.WriteAllText(path, text);
        }
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
        public void WriteAllLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
        public void CopyFile(string srcPath, string destPath)
        {
            File.Copy(srcPath, destPath);
        }
        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }
        public void MoveFile(string srcPath, string destPath)
        {
            File.Move(srcPath, destPath);
        }
    }
}
