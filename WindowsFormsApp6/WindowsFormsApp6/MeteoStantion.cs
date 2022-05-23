using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class MeteoStantion
    {
        public Point point;
        public int temperature;
        public int pressure;
        public int wind_sped;
        public int wind_rotate;

        public MeteoStantion(Point point, int temperature, int pressure, int wind_sped, int wind_rotate)
        {
            this.point = point;
            this.temperature = temperature;
            this.pressure = pressure;
            this.wind_sped = wind_sped;
            this.wind_rotate = wind_rotate;
        }
        public Point getXY()
        {
            return point;
        }
    }
}
