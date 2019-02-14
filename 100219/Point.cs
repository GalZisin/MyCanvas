using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100219
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if(x >= 0 && x <= MyCanvas.MAX_WIDTH)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Value is illegal");
            }
        }
        internal void SetY(int y)
        {
            if (y > 0 && x <= MyCanvas.MAX_HEIGHT)
            {
                this.y = y;
            }
            else
            {
                Console.WriteLine("Value is illegal");
            }
        }
        public override string ToString()
        {
            return $"Point: ({this.x},{this.y})";
        }
    }
}
