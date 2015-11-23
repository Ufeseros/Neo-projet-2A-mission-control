using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Jour
    {
        int num;
        List<Activitée> activitées;

        public Jour(int num)
        {
            this.num = num;
            // journée type
            activitées = new List<Activitée>();

            Activitée a = new Activitée("Living", "Spleeping", 0, 7, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating", 7, 8, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 8, 12, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating",12, 14, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 14, 19, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating", 19, 21, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 21, 23, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Sleeping", 23, 24, this.num);
            activitées.Add(a);
        }

        public int getNum()
        {
            return num;
        }

    }
}
