using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_U2
{
    public class formula_2
    {
        private int distance;
        private int velocity;
        private int time;

        public int Distance { get => distance; set => distance = value; }
        public int Velocity { get => velocity; set => velocity = value; }
        public int Time { get => time; set => time = value; }

        public void v_cyclist(int _distance, int _velocity, int _time)
        {
            this.distance = _distance;
            this.velocity = _velocity;
            this.time = _time;
            
        }
    }
}
