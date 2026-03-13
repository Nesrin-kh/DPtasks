using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class StudentFactory
    {
        public static Student CreateStudent(string type)
        {
            if (type == "Engineering")
                return new EngineeringStudent();

            else if (type == "Medical")
                return new MedicalStudent();

            else if (type == "Business")
                return new BusinessStudent();

            else
                return null;
        }
    }
}
