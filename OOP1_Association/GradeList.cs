using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_Association
{
    internal class GradeList
    {
        private int _size;
        public List<Grade> _grade;

        public GradeList(int maxNumberofGrades)
        {
            this._size = maxNumberofGrades;
            this._grade = new List<Grade>(maxNumberofGrades);
        }

        public int getSize()
        {
            return this._size;
        }

        public Grade getGrade(int index)
        {
            return _grade[index];
        }

        public void addGrade(Grade grade)
        {
            if (_grade.Count < _size)
            {
                _grade.Add(grade);
            }
            else
            {
                Console.WriteLine($"Grade list has the size of {_size}. It is full");
            }
        }

        public Grade[] getAllGrades()
        {
            return _grade.ToArray();
        }

        public double getAverage()
        {
            double sum = 0;
            foreach (Grade grade in _grade)
            {
                sum += grade.getPoint();
            }

            return sum / _grade.Count;
        }

        public string? toString()
        {
            return null;
        }
    }
}
