using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace FileSystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.CreateConfig();
            app.ReadConfig();
            app.CreateDirectory();
            app.CreateFile();
            Console.Read();
            app.ArchiveConfig();
            app.SaveImage();
            app.CopySaveData();
            app.DeleteTmpDir();
        }
        private FileSystem fileSystem;
        public Program()
        {
            fileSystem = new FileSystem();
        }
        //public string ConfigFile = "Config.txt";
        public string ConfigFile
        {
            get { return GetUserDataFolder() + "Config.txt"; }
        }

        public string[] Folders =
        {
            @"Workspace\",
            @"Workspace\Archive\",
            @"Workspace\Tmp\",
            @"Workspace\Tmp\SaveData\"
        };
        public enum FolderNames
        {
            Workspace,
            Archive,
            Tmp,
            SaveData
        }
        public string GetFolderByName(FolderNames name)
        {
            return GetUserDataFolder() + Folders[(int)name];
        }
        public void CreateDirectory()
        {
            var total = Folders.Length;

            for (int i = 0; i < total; i++)
            {
                //var dirName = Folders[i];
                var dirName = GetFolderByName((FolderNames)i);
                if (fileSystem.DirectoryExists(dirName))
                {
                    Console.WriteLine("dir '" + dirName + "' Existis");
                }
                else
                {
                    fileSystem.CreateDirectory(dirName);
                    Console.WriteLine("dir '" + dirName + "' Is created");
                }
            }
        }

        public void DeleteTmpDir()
        {
            //var dirName = Folders[2];
            var dirName = GetFolderByName(FolderNames.Tmp);
            if (fileSystem.DirectoryExists(dirName))
            {
                fileSystem.DeleteDirectory(dirName, true);
            }
        }

        public void CopySaveData()
        {
            //var saveDataDir = Folders[3];
            var saveDataDir = GetFolderByName(FolderNames.SaveData);
            if (fileSystem.DirectoryExists(saveDataDir))
            {
                var destDirName = GetFolderByName(FolderNames.Archive);
                destDirName += fileSystem.GetFileName(saveDataDir.TrimEnd(fileSystem.DirectorySeparatorChar));
                destDirName += "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                fileSystem.MoveDirectory(saveDataDir, destDirName);
            }
        }
        public void CreateFile()
        {
            var path = GetFolderByName(FolderNames.SaveData) + "TestFile.txt";
            fileSystem.WriteAllText(path, "Teste da Mamãe");

            //var fileInfo = new System.IO.FileInfo(path);
            var infoFile = new InfoFile(path);
            //var fileName = fileSystem.GetFileNameWithoutExtension(fileInfo.FullName);
            var fileName = fileSystem.GetFileNameWithoutExtension(infoFile.FullName());

            var fileExt = infoFile.Extension();
            var fileSize = infoFile.Length();

            Console.WriteLine("Created file : " + fileName + " witch ext " + fileExt + " with a size of " + fileSize + " bytes.");
        }
        public void CreateConfig()
        {
            if (!fileSystem.FileExists(ConfigFile))
            {
                fileSystem.WriteAllLines(ConfigFile, Folders);
            }

        }
        public void ReadConfig()
        {
            var lines = fileSystem.ReadAllLines(ConfigFile);
            var total = lines.Length;
            Array.Resize(ref Folders, total);

            for (int i = 0; i < total; i++)
            {
                var pathString = lines[i];
                Console.WriteLine("Setting path - " + pathString);
                Folders[i] = pathString;
            }
        }
        public void ArchiveConfig()
        {
            var configPath = ConfigFile;
            var configName = fileSystem.GetFileName(configPath);
            var tmpPath = GetFolderByName(FolderNames.Tmp) + configName;
            var newPath = GetFolderByName(FolderNames.SaveData) + configName;

            fileSystem.CopyFile(configPath, tmpPath);

            var lines = fileSystem.ReadAllLines(tmpPath);
            var configString = String.Join(Environment.NewLine, lines);
            var workspaceDirName = fileSystem.GetDirectoryName(GetFolderByName(FolderNames.Workspace));
            var newWorkspaceDirName = workspaceDirName + DateTime.Now.ToString("yyyyMMddHHmmss");

            configString = configString.Replace(workspaceDirName, newWorkspaceDirName);
            fileSystem.WriteAllText(tmpPath, configString);

            fileSystem.MoveFile(tmpPath, newPath); 
        }

        public void SaveImage()
        {
            var imageFileName = GetFolderByName(FolderNames.SaveData) + "Image.jpg";

            var bitmap = new Bitmap(128, 128, PixelFormat.Format24bppRgb);
            var g = Graphics.FromImage(bitmap);
            g.Clear(Color.Magenta);

            bitmap.Save(imageFileName, ImageFormat.Jpeg);

        }
        public string GetUserDataFolder()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            dir += @"\FileSystemTestProgram\";

            if (!fileSystem.DirectoryExists(dir))
            {
                fileSystem.CreateDirectory(dir);
            }
            return dir;
        }
    }
}
