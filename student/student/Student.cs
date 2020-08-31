using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    public class Student
    {
        public enum GenderType { male, female }
        private string _address;
        private string _name;
        private int _semester;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 1)
                    _name = value;
                throw new ArgumentException();

            }
            
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value != null)
                    _address = value;
                else throw new ArgumentNullException();
            
            }
        }

        public int Semester
        {
            get => _semester;
            set
            {
                if (value >0 && value<9)
                    _semester = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public GenderType Gender
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
