using System;

namespace _10112021
{
    enum GroupType:byte
    {
        Programming,
        System=5,
        Network
    }
    class Group
    {
        public GroupType Type;
    }
    class Human
    {
        public string FullName;
    }
    class Student : Human
    {
        public string GroupNo;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var names = Enum.GetNames(typeof(GroupType));
            var values = Enum.GetValues(typeof(GroupType));

            foreach (var item in values)
            {
                Console.WriteLine((byte)item);
            }
            Human human = new Human();

            //Student student = human as Student;
            Student student = human as Student;

            int num1 = 560;
            byte age = 80;

            age = (byte)num1;

            object obj = num1;
            num1 = (int)obj;
        }
    }
}
