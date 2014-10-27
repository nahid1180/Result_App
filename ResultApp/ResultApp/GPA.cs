using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultApp
{
    class GPA
    {
        public GPA(double physics, double chemistry, double math)
        {
            Physics = physics;
            Chemistry = chemistry;
            Math = math;
        }





        private double physics;
        private double chemistry;
        private double math;
        private double averarage;
        private string grade;

        public double Physics
        {
            set
            {
                physics = value;
            }
            get
            {
                return physics;
                
            }
        }

        public double Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }

        public double Math
        {
            get { return math; }
            set { math = value; }
        }

        public double Averarage
        {
            get { return averarage; }
            //set { averarage = value; }
        }

        public string Grade
        {
            get { return grade; }
            //set { grade = value; }
        }

        public double GetAverage()
        {
            averarage = (physics + chemistry + math)/3;
            return averarage;
        }

        public string GetGradeLetter()
        {
            if (averarage >= 80)
            {
                return "A +";
            }
            else if (averarage >=70 && averarage <80)
            {
                return "B+";
            }
            else if (averarage >= 60 && averarage < 70)
            {
                return "C+";
            }
            else if (averarage >= 50 && averarage < 60)
            {
                return "D+";
            }
            else
            {
                return "F";
            }
        }
    }
}
