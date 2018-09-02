using System;
using System.IO;
using System.Text;

namespace Lesson_17
{
    class Program
    {
        private static string FileName = "test.txt";

        static void Main(string[] args)
        {
            //FileActions();

            //FileReadWrite();

            //ReadMatrixFromFile();

            //PrintFileInfo(FileName);

            //GetAndPrintFileInfo(FileName);

            //FileStreams();
            //StreamWriterMethod();

            StreamReaderMethod();

            MemoryStreamMethod1();

            Console.WriteLine("Нажми Enter для выхода.");

            Console.Read();
        }

        private static void ReadMatrixFromFile()
        {
            var fileName = "matrix.txt";
            var fileLines = File.ReadAllLines(fileName);
            Console.WriteLine($"Количество строк в файле {fileName} = {fileLines.Length}");
            int rows = int.Parse(fileLines[0]);
            int columns = int.Parse(fileLines[1]);
            int[,] matrix = new int[rows, columns];
            for (int i = 2; i < fileLines.Length; i++)
            {
                var numbers = fileLines[i].Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i - 2, j] = int.Parse(numbers[j]);
                }
            }

            PrintMatrix(matrix);
        }

        private static void FileReadWrite()
        {
            Console.WriteLine("Введи текст для записи в файл: ");
            var input = Console.ReadLine();
            File.WriteAllText(FileName, input);
            Console.WriteLine($"Текст записн в файл {FileName}.");

            var fileContent = File.ReadAllText(FileName);
            Console.WriteLine($"Содержимое файла {FileName}: {fileContent}");

            File.AppendAllText(FileName, "\ndfighdfghdfoguh fdouighdfouhg oduifhgodfhg odfuhgdofuhg\ndfgfdg\vdfgdfg\tfgdfgdfg");
            var fileLines = File.ReadAllLines(FileName);
            Console.WriteLine($"Количество строк в файле {FileName} = {fileLines.Length}");

            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i]);
            }
        }

        private static void FileActions()
        {
            if (File.Exists(FileName))
                Console.WriteLine($"Файл {FileName} уже существует!");
            else
                Console.WriteLine($"Файл {FileName} не существует!");

            File.Create(FileName);
            File.Delete(FileName);
            File.Copy("source.txt", "destination.txt");
            File.Move("source.txt", "destination.txt");
        }

        static void PrintFileInfo(string FileName)
        {
            Console.WriteLine(FileName);
            Console.WriteLine("Attributes: " + File.GetAttributes(FileName));
            Console.WriteLine("Creation time: " + File.GetCreationTime(FileName));
            Console.WriteLine("Last access time: " + File.GetLastAccessTime(FileName));
        }

        static FileInfo GetAndPrintFileInfo(string FileName)
        {
            FileInfo fi1 = new FileInfo(FileName);
            Console.WriteLine("Attributes: " + fi1.Attributes.ToString());
            Console.WriteLine("FullName: " + fi1.FullName);
            Console.WriteLine("Name: " + fi1.Name);
            Console.WriteLine("Extension: " + fi1.Extension);
            Console.WriteLine("Directory name: " + fi1.DirectoryName);
            Console.WriteLine("IsReadOnly: " + fi1.IsReadOnly);
            Console.WriteLine("Length: " + fi1.Length);
            Console.WriteLine("Last access time: " + fi1.LastAccessTime);
            return fi1;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }



        private static void FileStreams()
        {
            string fileName1 = "test_filestream.txt";
            FileStream fs1 = new FileStream(fileName1, FileMode.Create, FileAccess.Write);
            var bytesArray = new byte[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < bytesArray.Length; i++)
            {
                Console.Write(bytesArray[i] + " ");
            }
            Console.WriteLine();

            fs1.Write(bytesArray, 0, bytesArray.Length);
            fs1.Flush();
            fs1.Dispose();

            fs1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            byte[] bytesArrayNew = new byte[bytesArray.Length];
            fs1.Read(bytesArrayNew, 0, bytesArray.Length);
            for (int i = 0; i < bytesArrayNew.Length; i++)
            {
                Console.Write(bytesArrayNew[i] + " ");
            }
            fs1.Dispose();

            var fs2 = File.Create("test_fs.txt");
        }

        private static void StreamWriterMethod()
        {
            var path = "test_sw.txt";

            StreamWriter sw1 = new StreamWriter(path);
            sw1.WriteLine("Test1");
            sw1.WriteLine("Test2");
            sw1.Flush();
            sw1.Close();
            sw1.Dispose();

            StreamWriter sw2 = File.AppendText(path);
            sw2.WriteLine("Test3");
            sw2.WriteLine("Test4");
            sw2.Flush();
            sw2.Close();
            sw2.Dispose();

            //FileInfo fi1 = new FileInfo(path);
            //StreamWriter sw3 = fi1.CreateText();
            //sw3.WriteLine("Test5");
            //sw3.WriteLine("Test6");
            //sw3.Flush();
            //sw3.Close();
            //sw3.Dispose();

            using (var sw4 = new StreamWriter(path))
            {
                sw4.WriteLine("ААА");
                sw4.WriteLine("BBB");
                sw4.WriteLine("CCC");
            }
        }

        private static void StreamReaderMethod()
        {
            var path = "test_sw.txt";

            using (var sr4 = new StreamReader(path))
            {
                string temp;
                while (!string.IsNullOrEmpty(temp = sr4.ReadLine()))
                {
                    Console.WriteLine(temp);
                }

                while ((temp = sr4.ReadLine()) != null)
                {
                    Console.WriteLine(temp);
                }
            }
        }


        private static void StringWriterMethod()
        {
            var sw1 = new StringWriter();
            var sw2 = new StringWriter(new StringBuilder(100000));
            sw2.WriteLine("Тестируем StringWriter");
            sw2.WriteLine("Тестируем StringWriter");
            sw2.WriteLine("Тестируем StringWriter");
            sw2.Flush();
            sw2.Close();
        }

        private static void StringReaderMethod()
        {
            string input = @"Пример нескольких
            строк, которые
            разделены";

            using (var sr = new StringReader(input))
            {
                int count = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine("Строка {0}: {1}", count, line);
                }
            }
        }

        private static void MemoryStreamMethod1()
        {
            byte[] file = File.ReadAllBytes(FileName);
            
            using (MemoryStream ms = new MemoryStream(file))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    for (int i = 0; i < file.Length; i++)
                    {
                        byte result = br.ReadByte();
                        Console.WriteLine(result);
                        //Console.WriteLine(br.ReadByte());
                    }
                }
            }
        }

        private static void BinaryWriterReaderMethod()
        {
            FileStream writeStream = null;
            try
            {
                writeStream = new FileStream("binary.dat", FileMode.Create);
                BinaryWriter writeBinay = new BinaryWriter(writeStream);
                writeBinay.Write("Тестирую BinaryWriter");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writeStream?.Close();
                writeStream?.Dispose();
            }
        }

        private static void BufferedStreamMethod()
        {
            var fileName = @"buffered_stream.txt";
            var file = new FileInfo(fileName);
            using (FileStream fileStream = file.Create())
            {
                using (var bs = new BufferedStream(fileStream, 10000))
                {
                    for (var index = 1; index < 2000; index++)
                    {
                        var s = "Строка с номером: " + index + "\n";

                        byte[] bytes = Encoding.UTF8.GetBytes(s);
                        bs.Write(bytes, 0, bytes.Length);
                    }
                    bs.Flush();
                }
            }
        }
    }
}