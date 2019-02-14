using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _100219;
namespace _100219
{
    class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;

        public MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
            UpdateWidthAndHeight();
        }

        internal int GetWidth()
        {
            return this.width; //= bottomRight.GetX() - topLeft.GetX();
        }
        internal int GetHeight()
        {
            return this.height; //= topLeft.GetY() - bottomRight.GetY();
        }
        private void UpdateWidthAndHeight()
        {
            this.width = bottomRight.GetX() - topLeft.GetX();
            this.height = bottomRight.GetY() - topLeft.GetY();
        }
        internal bool SetTopLeft(Point pointTopLeft)
        {
            if (pointTopLeft.GetX() < bottomRight.GetX() && pointTopLeft.GetY() < bottomRight.GetY())
            {
                this.topLeft = pointTopLeft;
                this.UpdateWidthAndHeight();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool SetBottomRight(Point pointBottomRight)
        {
            if (pointBottomRight.GetX() > topLeft.GetX() && pointBottomRight.GetY() > topLeft.GetY())
            {
                this.bottomRight = pointBottomRight;
                this.UpdateWidthAndHeight();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal Point GetTopLeft()
        {
            return this.topLeft;
        }
        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }
        public override string ToString()
        {
            return $"Button TopLeft : { this.topLeft }, bottomRight : { this.bottomRight }, Width : { this.width }, Height : { this.height }";
            //$"Top left point: {topLeft.GetX()}, {topLeft.GetY()}  Bottom Right point: {bottomRight.GetX()}, {bottomRight.GetY()} Width: {this.width} Height: {this.height}";
        }
    }
}

