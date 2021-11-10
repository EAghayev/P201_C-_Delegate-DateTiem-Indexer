using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Student
    {
        public Student()
        {
            _exams = new Dictionary<string, int>();
        }
        private Dictionary<string, int> _exams;
        public int CalcAvgPoint()
        {
            var sum = 0;
            foreach (var item in this._exams)
            {
                sum += item.Value;
            }

            return sum / this._exams.Count;
        }

        public bool AddExam(string examName,int examPoint)
        {
            //if (!_exams.ContainsKey(examName)) _exams.Add(examName, examPoint);
            return _exams.TryAdd(examName, examPoint);
        }

        public int FindExamsCount(Predicate<int> check)
        {
            int counter = 0;
            foreach (var item in _exams)
            {
                if (check(item.Value)) counter++;
            }

            return counter;
        }


    }
}
