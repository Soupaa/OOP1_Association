using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_Association
{
    internal class Grade
    {
        private int _point;
        private int _studentID;

        public Grade(int point, int studentID)
        {
            this._point = point;
            this._studentID = studentID;
        }

        public int getPoint()
        {
            return this._point;
        }

        public int getStudentID() {
            return this._studentID;
        }
    }
}
