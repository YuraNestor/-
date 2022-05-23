using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Worker
    {
        public Worker(int workerId, string work, string qualification, int experience, double wages, bool insurance, int vacation)
        {
            WorkerId = workerId;
            Work = work;
            Qualification = qualification;
            Experience = experience;
            Wages = wages;
            Insurance = insurance;
            Vacation = vacation;
        }
        
        public Worker() { }

        
        public int WorkerId { get; set; }
        public string Work { get; set; }
        public string Qualification { get; set; }
        public int Experience { get; set; }
        public double Wages { get; set; }
        public bool Insurance { get; set; }
        public int Vacation { get; set; }



    }
}
