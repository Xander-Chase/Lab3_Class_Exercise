using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Class_Exercise
{

    public partial class Student : AbstractStudent
    {

        // Step 2: Adjust the _gpa to have auto-generated getters/setters
        private double _gpa;




        // DO NOT CHANGE
        public void AdjustGPA(double grade)
        {
            _gpa = (_gpa + grade) / 2;
        }


    }

}
