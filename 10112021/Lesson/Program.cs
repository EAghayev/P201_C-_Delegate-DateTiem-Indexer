using System;
using System.Collections.Generic;

namespace Lesson
{
    class Program
    {
        delegate bool CheckNum(int num);
        delegate int SumFunc(int num1, int num2);
        delegate void Show(string str1, string str2);
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 40, 14,30, 50, 55, 13,63 };

            Console.WriteLine($"Sum even: {SumEven(numbers)}");
            Console.WriteLine($"Sum odd: {SumOdd(numbers)}");
            Console.WriteLine($"Sum odd: {Sum(numbers,IsOdd)}");
            Console.WriteLine($"Sum even: {Sum(numbers, IsEven)}");


            CheckNum check = IsEven;
            check = IsOdd;

            //anonymous method
            check = delegate (int n) {
                return n % 7 == 0;
            };

            check = x => x % 5 == 0;

            Console.WriteLine(check(15));

            SumFunc sum = Sum2Nums;
            sum = delegate (int x, int y)
            {
                int result = x + y;
                return result;
            };
            sum = (x,y) => x+y;

            Console.WriteLine(sum(45,10));
            Console.WriteLine(sum.Invoke(55,10));

            Func<int, int, int> func1 = Sum2Nums;
            Func<int, bool> func2 = (x) => x % 2 == 0;
            Func<int, bool> func3 = delegate (int num) { return num % 2 == 0; };

            Console.WriteLine(Sum(numbers, IsEven));

            Action action1 = delegate () { Console.WriteLine("action1 excecuted"); };
            action1();

            Show show = ShowFullName;
            Action<string, string> action2 = ShowFullName;

            action2("Hikmet","Abbasov");

            Predicate<int> checkPred = IsEven;
            checkPred = x => x % 3 == 0;
            checkPred = delegate (int num) { return num % 5 == 0; };
            Console.WriteLine(checkPred(39));


            List<int> searchedList;

            searchedList = FindAll(numbers, IsEven) ;

            Console.WriteLine("Searched items:");
            foreach (var item in searchedList)
            {
                Console.WriteLine(item);
            }

            int sumOfNumbers = 0;
            numbers.ForEach(x => x++);
            Console.WriteLine("sum: "+sumOfNumbers);
        }

        static void ShowFullName(string name,string surname)
        {
            Console.WriteLine(name +" "+surname);
        }
        static int SumEven(List<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0) sum += item;
            }

            return sum;
        }

        static int Sum2Nums(int num1, int num2)
        {
            return num1 + num2;
        }
        static int SumOdd(List<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 != 0) sum += item; 
            }

            return sum;
        }

        static int SumDividedBy7(List<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 7 == 0) sum += item;
            }

            return sum;
        }
        static int Sum(List<int> nums, Predicate<int> check)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (check(item)) sum += item;
            }

            return sum;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        static List<int> FindAll(List<int> list,Predicate<int> check)
        {
            List<int> nums = new List<int>();
            foreach (var item in list)
            {
                if (check(item)) nums.Add(item);
            }

            return nums;
        }
    }
}
