namespace _21_WorhWithDirectory_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}
