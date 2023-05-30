using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynter_CourseProject_part2
{
    public class Benefits
    {
        //attributs
        private string healthInsurance;
        private int lifeInsurance;
        private int vacation;

        public Benefits()
        {
            healthInsurance = "N/A";
            lifeInsurance = 0;
            vacation = 0;
        }

        public Benefits(string healthInsurance, int lifeInsurance, int vacation)
        {
            this.healthInsurance = healthInsurance;
            this.lifeInsurance = lifeInsurance;
            this.vacation = vacation;
        }

        //BEHAVIORS
        public override string ToString()
        {
            return "healthInsurance=" + healthInsurance + ", lifeInsurance=" + lifeInsurance + ", vacation=" + vacation;
        }
        //props

        public string HealthInsurance
        {
            get { return healthInsurance; }
            set { healthInsurance = value; }
        }

        public int LifeInsurance
        {
            get { return lifeInsurance; }
            set { lifeInsurance = value; }

        }
        public int Vacation
        {
            get { return vacation; }
            set { vacation = value; }
        }
    }
}
