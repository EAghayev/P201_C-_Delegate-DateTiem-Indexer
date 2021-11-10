using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("az-AZ");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Əlifba");

            List<Exam> exams = new List<Exam>
            {
                new Exam{Name = "riyaziyyat1",Date = new DateTime(2021,11,20,14,0,0)},
                new Exam{Name = "riyaziyyat2",Date = new DateTime(2021,11,21,11,0,0)},
                new Exam{Name = "riyaziyyat3",Date = new DateTime(2021,11,20,18,0,0)},
                new Exam{Name = "riyaziyyat4",Date = new DateTime(2021,11,22)}
            };
            DateTime wantedDate = new DateTime(2021, 11, 20);
            Console.WriteLine(wantedDate.Month);
            Console.WriteLine(wantedDate.Year);
            Console.WriteLine(wantedDate.Day);
            Console.WriteLine(wantedDate.DayOfWeek);


            Console.WriteLine($"exam count: {FindExamsCountByDate(wantedDate,exams)}");


            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(12);
            nums.Add(15);
            nums.Add(51);

            Console.WriteLine(nums[2]);

            MyList<int> myList = new MyList<int>(5);
            myList[0] = 45;
            myList[1] = 55;


            Console.WriteLine(myList[4]);

            DateTime dateTime = new DateTime(2021, 10, 21, 14, 20, 50);
            Console.WriteLine(dateTime.Date);

            Console.WriteLine("Il daxil edin");
            string yearStr = Console.ReadLine();
            int year = Convert.ToInt32(yearStr);

            Console.WriteLine("Ay daxil edin");
            string monthStr = Console.ReadLine();
            int month = Convert.ToInt32(monthStr);


            Console.WriteLine("Gun daxil edin");
            string dayStr = Console.ReadLine();
            int day = Convert.ToInt32(dayStr);


            DateTime newDate = new DateTime(year, month, day);
            Console.WriteLine(newDate);

            Console.WriteLine("Tarixi daxil edin:");
            string dateStr = Console.ReadLine();

            newDate = Convert.ToDateTime(dateStr);
            newDate = newDate.AddMonths(-2);


            Console.WriteLine(newDate);
        }

        static int FindExamsCountByDate(DateTime date,List<Exam> exams)
        {
            int count = 0;
            foreach (var exam in exams)
            {
                if (exam.Date.Date == date.Date) count++;
            }

            return count;
        }
    }
}
