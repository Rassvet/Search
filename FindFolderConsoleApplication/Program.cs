using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication34
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int choose;
            int tempSize = 0;
            int chooseFolder;
            int chooseFile;
            string[] arrSize = new string[20];
            string[] massFile;
            string[] massFolder;
            string searchFile;
            string searchFolder;
            string path = "C:\\General";
            massFile = Directory.GetFiles(path);
            massFolder = Directory.GetDirectories(path);
            int count = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.Работать с папками");
                Console.WriteLine("2.Работать с файлами");
                Console.WriteLine("0.Выход");
                Console.WriteLine("Выберите пункт меню:");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("1.Поиск по имени");
                            Console.WriteLine("2.Дата создания");
                            Console.WriteLine("3.Дата изменения");
                            Console.WriteLine("0.Назад");
                            Console.WriteLine("Выберите пункт меню:");
                            chooseFolder = Convert.ToInt32(Console.ReadLine());
                            switch (chooseFolder)
                            {

                                case 1:
                                    {
                                        Console.Clear();
                                        string a;
                                        string b;
                                        Console.WriteLine("Введите имя папки");
                                        searchFolder = Convert.ToString(Console.ReadLine());
                                        a = massFolder[0].Replace("C:\\General\\", "");
                                        b = massFolder[1].Replace("C:\\General\\", "");
                                        List<string> folderList = new List<string>();
                                        folderList.Add(a);
                                        folderList.Add(b);
                                        for (int i = 0; i < folderList.Count; i++)
                                        {
                                            if (folderList[i] == searchFolder)
                                            {

                                                Console.WriteLine("Папка найдена!");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine(massFolder[i]);
                                                count++;
                                            }

                                        }
                                        if (count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Папка не найдена!");
                                        }
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;

                                    }
                                case 2:
                                    {
                                        break;
                                    }


                            }
                        } while (chooseFolder != 0);
                        break;
                    case 2:
                        Console.Clear();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("1.Поиск по имени");
                            Console.WriteLine("2.Поиск по размеру");
                            Console.WriteLine("3.Дата создания");
                            Console.WriteLine("4.Дата изменения");
                            Console.WriteLine("0.Назад");
                            Console.WriteLine("Выберите пункт меню:");
                            chooseFile = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (chooseFile)
                            {

                                case 1:
                                    {
                                        string a;
                                        Console.WriteLine("Введите имя файла");
                                        searchFile = Convert.ToString(Console.ReadLine());
                                        for (int i = 0; i < massFile.Length; i++)
                                        {
                                            a = Path.GetFileNameWithoutExtension(massFile[i]);
                                            if (searchFile == a)
                                            {

                                                Console.WriteLine("Файл найден!");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine(massFile[i]);
                                                count++;
                                            }

                                        }
                                        if (count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Файл не найден!");
                                        }
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;

                                    }
                                case 2:
                                    {
                                        foreach (string aSize in massFile)
                                        {

                                            arrSize[tempSize] = Path.GetFileName(aSize);
                                            tempSize++;
                                            Console.WriteLine(Path.GetFileName(aSize));

                                        }

                                        int searchFileSize;
                                        int searchFileSizeEnd;

                                        Console.WriteLine("Введите диапазон размеров искомого файла в кБ");
                                        Console.WriteLine("Начальное значение:");
                                        searchFileSize = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Конечное значение:");
                                        searchFileSizeEnd = Convert.ToInt32(Console.ReadLine());
                                        for (int i = 0; i < massFile.Length; i++)
                                        {
                                            FileInfo razm = new FileInfo(@"C:\General\" + arrSize[i]);
                                            if (razm.Length / 1024 >= searchFileSize && razm.Length / 1024 < searchFileSizeEnd)
                                            {
                                                Console.WriteLine("Файл " + massFile[i] + " размер " + razm.Length / 1024 + "кБ");
                                                count++;
                                            }

                                        }
                                        if (count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Файл не найден!");
                                        }
                                        Console.ReadLine();
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                                case 4:
                                    {
                                        break;
                                    }
                            }
                            break;
                        } while (chooseFile != 0);
                        break;
                }
            } while (choose != 0);
        }
    }
}






