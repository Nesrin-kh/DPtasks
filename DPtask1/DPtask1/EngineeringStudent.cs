using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class EngineeringStudent : Student
    {
        public override void GetTypeOfStudent()
        {
            Console.WriteLine("Engineering Student Created");
        }
    }

    public class MedicalStudent : Student
    {
        public override void GetTypeOfStudent()
        {
            Console.WriteLine("Medical Student Created");
        }
    }

    public class BusinessStudent : Student
    {
        public override void GetTypeOfStudent()
        {
            Console.WriteLine("Business Student Created");
        }
    }
}
