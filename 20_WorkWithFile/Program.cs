using System.Text;

namespace _20_WorkWithFile
{

    internal class Program
    {
        static void WriteFile(string path)
        {
            //ex --- 1 ----
            // FileStream fs = new FileStream(path, FileMode.Open,
            //     FileAccess.Write | FileAccess.Read, FileShare.Write);
            //// fs.Write()
            //// fs.Read()
            //fs.Close();


            //ex --- 2 ------
            //FileStream fs = new FileStream(path, FileMode.Open,
            //   FileAccess.Write | FileAccess.Read, FileShare.Write);
            //// fs.Write()
            //// throw exception
            //// fs.Read()
            //fs.Dispose();//fs.Close();

            //ex  ---- 3 -----
            //FileStream fs = new FileStream(path, FileMode.Open,
            //  FileAccess.Write | FileAccess.Read, FileShare.Write);

            //try
            //{
            //    // fs.Write()
            //    // throw exception
            //    // fs.Read()
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    fs.Dispose();
            //}

            // ex   ----- 4-------
            using (FileStream fs = new FileStream(path, FileMode.Create,
              FileAccess.Write , FileShare.None))
            {
              
                Console.WriteLine("Enter some text : ");
                string writeText = Console.ReadLine()!;
                byte[]writeBytes = Encoding.Default.GetBytes(writeText);
                fs.Write(writeBytes, 0, writeBytes.Length);
                Console.WriteLine("Information was recorded!");
            }//fs.Dispose();
        }
        static string ReadFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[]readText = new byte[fs.Length];
                fs?.Read(readText, 0, readText.Length);
                return Encoding.Default.GetString(readText);
            }
        }

        static void WriteStringText(string path)
        {
            using (StreamWriter sw = new StreamWriter(path + @"\textString.txt"))
            {
                sw.Write("Hello");
                sw.WriteLine();
                sw.WriteLine("How are you? ");
                sw.Write("Are you fine? ");
            }
        }
        static void ReadStringText(string path)
        {
            using (StreamReader sr = new StreamReader(path + @"\textString.txt"))
            {
                //Console.WriteLine(sr.Read()); ;//read one symbol

                //char[] buffer = new char[10];
                //sr.ReadBlock(buffer,0,buffer.Length) ;//read block by size
                //Console.WriteLine(buffer);

                //while (!sr.EndOfStream)//read one line
                //{
                //    Console.WriteLine(sr.ReadLine());
                //}
                Console.WriteLine(sr.ReadToEnd()); ;

            }
        }
        static void Main(string[] args)
        {
            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\test1.txt";
            //WriteFile(filePath);
            //Console.WriteLine(ReadFile(filePath));;
            //WriteStringText(root);
            ReadStringText(root);

            //---1----
            FileStream fs =  File.Create("text3.txt");           
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello");
            sw.WriteLine("Hello");
            sw.WriteLine("Hello");
            sw.WriteLine("Hello");
            sw.WriteLine("Hello");
            sw.Close();
            fs.Close();

            //---2 ---
            sw = File.CreateText("text4.txt");
            sw.WriteLine("Example 2 write text");
            sw.Close();

            //--3 ----
            File.WriteAllText("text5.txt", "Content for write");
   

            #region Binary Write and Binary Read
            FileStream bfs = File.Create(@"info.bin");
            BinaryWriter writer = new BinaryWriter(bfs);
            long number = 100;
            var bytes = new byte[] { 10, 20, 30, 40, 50 };
            string s = "mywriter";
            writer.Write(number);
            writer.Write(bytes);
            writer.Write(s);

            writer.Close();


            fs = File.Open(@"info.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            long num = br.ReadInt64();
            byte[]b = br.ReadBytes(5);
            string str = br.ReadString();
            fs.Close();
            br.Close();
            Console.WriteLine(num);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(str);

            #endregion





        }
    }
}
