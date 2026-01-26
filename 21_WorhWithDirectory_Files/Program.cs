using System.Text;

namespace _21_WorhWithDirectory_Files
{
    internal class Program
    {
        static void WriteFile(FileInfo file)
        {

            using (FileStream fs = file.Open(FileMode.Create, FileAccess.Write, FileShare.None))
            {

                Console.WriteLine("Enter some text : ");
                string writeText = Console.ReadLine()!;
                byte[] writeBytes = Encoding.Default.GetBytes(writeText);
                fs.Write(writeBytes, 0, writeBytes.Length);
                Console.WriteLine("Information was recorded!");
            }//fs.Dispose();
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Test");
            if (!dir.Exists)
            {
                dir.Create();
            }
            Console.WriteLine($"Last access to the folder : {dir.LastAccessTime}");

            DirectoryInfo subDir = dir.CreateSubdirectory("Subdir");
            Console.WriteLine($"Full path to directory : {subDir.FullName}");

            FileInfo file = new FileInfo(subDir + @"\Test.bin");  
            WriteFile(file);


            Directory.Delete(dir.FullName, true);  //dir.Delete();
            /*
            DriveInfo[] drivers =  DriveInfo.GetDrives();
            foreach (DriveInfo driver in drivers)
            {
                Console.WriteLine(driver.Name);
            }


            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            do
            {
                //Console.Clear();

                DirectoryInfo dir = new DirectoryInfo(root);

                Console.WriteLine($"Directory :  {dir.FullName}");
                Console.WriteLine($"Creation Time :  {dir.CreationTime}");
                Console.WriteLine($"Extension :  {dir.Extension}");
                Console.WriteLine($"Last Access Time :  {dir.LastAccessTime}");
                Console.WriteLine($"Last Write Time :  {dir.LastWriteTime}");
                Console.WriteLine($"Name :  {dir.Name}");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------------ Directories --------");
                foreach (var item in dir.GetDirectories())
                {
                    Console.WriteLine($"Directory : {item.Name}. Time : {item.CreationTime}");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------ Files --------");
                foreach (var item in dir.GetFiles())
                {
                    Console.WriteLine($"Files : {item.Name}. Time : {item.CreationTime}");
                }

                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.BackgroundColor= ConsoleColor.DarkBlue;
                Console.Write(root + @"\");
                string next = Console.ReadLine();
                Console.ResetColor();
                string nextPath = Path.Combine(root, next);

                root = nextPath;    
                    

            } while (true);
            */
        }
    }
}
