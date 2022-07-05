using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LabWork_5_1
{
    class InOutOperation
    {
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        public string CurrentPath { get; set; }
        public string CurrentDirectory { get; set; }
        public string CurrentFile { get; set; }


        // 2) declare public methods:
        //ChangeLocation() - change of CurrentPath; 
        // method takes new file path as parameter, creates new directories (if it is necessary)

        public void ChangeLocation(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            CurrentPath = filePath;
        }

        // CreateDirectory() - create new directory in current location
        public void CreateDirectory(string folderName)
        {
            DirectoryInfo directory = new DirectoryInfo(CurrentPath + @"\" + folderName);
            if (!directory.Exists)
            {
                CurrentDirectory = folderName;
                directory.Create();
                CurrentPath = CurrentPath + @"\" + CurrentDirectory;
            }

        }

        // WriteData() – save data to file
        // method takes data (info about computers) as parameter
        public void WriteData(Computer comp, string fileName)
        {
            CurrentFile = fileName;
            using (StreamWriter writer = new StreamWriter(CurrentPath + @"\" + CurrentFile + @".txt", true))
            {
                writer.WriteLine("Cores: " + comp.Cores);
                writer.WriteLine("Frequency: " + comp.Frequency);
                writer.WriteLine("Memory: " + comp.Memory);
                writer.WriteLine("Hdd: " + comp.Hdd);
            }
        }

        // ReadData() – read data from file
        // method returns info about computers after reading it from file
        public void ReadData(string fileName)
        {
            using (StreamReader reader = new StreamReader(CurrentPath + @"\" + fileName + @".txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        // WriteZip() – save data to zip file
        // method takes data (info about computers) as parameter
        public void WriteZip(string fileName)
        {
            string compressedFile = CurrentPath + @"\" + fileName + @".gz";

            //поток для чтения исходного файла
            using FileStream sourceStream = new FileStream(CurrentPath + @"\" + fileName + @".txt", FileMode.OpenOrCreate);
            //поток для чтения сжатого файла
            using FileStream targetStream = new FileStream(compressedFile, FileMode.Create);

            //поток архивации
            using GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress);
            //копіюємо байти із одного потоку в інший
            sourceStream.CopyTo(compressionStream);
        }


        // ReadZip() – read data from file
        // method returns info about computers after reading it from file

        public void ReadZip(string fileName)
        {
            string targetFile = CurrentPath + @"\" + fileName + @"_Decompressed" + @".txt";
            //поток для чтения из сжатого файла
            using FileStream sourceStream = new FileStream(CurrentPath + @"\" + fileName + @".gz", FileMode.OpenOrCreate);
            //поток для записи восстановленного файла
            using FileStream targetStream = new FileStream(targetFile, FileMode.Create);
            //поток розархивации
            using GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress);
            decompressionStream.CopyTo(targetStream);
        }


        // ReadAsync() – read data from file asynchronously
        // method is async
        // method returns Task with info about computers
        // use ReadLineAsync() method to read data from file
        // Note: don't forget about await
        public async void ReadAsync(string fileName)
        {
            using (StreamReader reader = new StreamReader(CurrentPath + @"\" + fileName + @".txt"))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }


        // 7)
        // ADVANCED:
        // WriteToMemoryStream() – save data to memory stream
        // method takes data (info about computers) as parameter
        // info about computers is saved to Memory Stream

        // use  method GetBytes() from class UnicodeEncoding to save array of bytes from string data 
        // create new file stream
        // use method WriteTo() to save memory stream to file stream 
        // method returns file stream
        public FileStream WriteToMemoryStream(Computer comp)
        {
            byte[] array1 = Encoding.UTF8.GetBytes(comp.Cores.ToString());
            byte[] array2 = Encoding.UTF8.GetBytes(comp.Frequency.ToString());
            byte[] array3 = Encoding.UTF8.GetBytes(comp.Memory.ToString());
            byte[] array4 = Encoding.UTF8.GetBytes(comp.Hdd.ToString());

            using (MemoryStream writer = new MemoryStream())
            {
                writer.Write(array1);
                writer.Write(array2);
                writer.Write(array3);
                writer.Write(array4);

                FileStream fileStream = new FileStream()
            }

            using (FileStream fileStream = new FileStream())
            {

            }

                

        }




        // WriteToFileFromMemoryStream() – save data to file from memory stream and read it
        // method takes file stream as parameter
        // save data to file      


        // Note: 
        // - use '//' in path string or @ before it (for correct path handling without escape sequence)
        // - use 'using' keyword to organize correct working with files
        // - don't forget to check path before any file or directory operations
        // - don't forget to check existed directory and file before creating
        // use File class to check files, Directory class to check directories, Path to check path


    }
}
