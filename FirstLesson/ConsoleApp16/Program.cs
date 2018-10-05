using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp16
{
    public class Program
    {

        public static string[] readingFile()
        {
            string path = @"C:\Users\User\Desktop\test.csv";
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        public static int countAll(string[] lines)
        {
            int count = 0;
            count = lines.Length - 1;
            return count;
        }

        public static int countOfDormitory(string[] lines)
        {
            int count = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    lines[i] = lines[i].Substring(0, lines[i].LastIndexOf(';'));
                }

                if (lines[i][lines[i].Length-1] == 'а')
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] countOfCourses(string[] lines)
        {
            int[] course = new int[3];

            for (int i = 1; i < lines.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    lines[i] = lines[i].Substring(lines[i].IndexOf(';') + 1);
                }

                switch (lines[i][0])
                {
                    case '1':
                        course[0]++;
                        break;
                    case '2':
                        course[1]++;
                        break;
                    case '3':
                        course[2]++;
                        break;
                    default:
                        break;                    
                }
            }
            return course;
        }

        static void Main(string[] args)
        {
            string[] linesFile = readingFile();
            int[] courses = countOfCourses(linesFile);

            Console.Write("Всего анкет: ");
            Console.WriteLine(countAll(linesFile));
            Console.Write("Анкет первого курса: ");
            Console.WriteLine(courses[0]);
            Console.Write("Анкет второго курса: ");
            Console.WriteLine(courses[1]);
            Console.Write("Анкет третьего курса: ");
            Console.WriteLine(courses[2]);
            Console.Write("Людей, проживающих в общажитии: ");
            Console.WriteLine(countOfDormitory(linesFile));
        }
    }
}
//чтение файла
//парсинг
//кол-во анкет
//разделение по курсам
//Кол-во общажников
