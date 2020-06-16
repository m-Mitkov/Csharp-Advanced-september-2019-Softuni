using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    class Box
    {
        private const string ErrorMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }


        public double Length
        {
            get { return length; }
            set
            {
                ValidateParameter(value, nameof(this.Length));
                this.length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                ValidateParameter(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                ValidateParameter(value, nameof(this.Height));
                this.height = value;
            }
        }

        private void ValidateParameter(double parameter, string caller)
        {
            if (parameter <= 0)
            {
                throw new ArgumentException(String.Format(ErrorMessage, caller));
            }
        }
        public double GetVolume(Box box)
        {
            return box.Length * box.Width * box.Height;
        }

        public double GetLateralSurfaceArea(Box box)
        {
            return 2 * (box.Length * box.Height) + 2 * (box.Width * box.Height);
        }

        public double GetSurfaceArea(Box box)
        {
            return 2 * (box.Length * box.Width) + 2 * (box.Length * box.Height) + 2 * (box.Width * box.Height);
        }
    }
}
