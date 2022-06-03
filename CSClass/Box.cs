using System;

namespace CSClass
{
    internal class Box
    {
        //prop 친후 fullprop에서 Tab키 
        /*private int myVar; 

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/

        private int width;

        public int Width { 
            get { return width; }
            set {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }
        
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }

        public int Area
        {
            get { return this.Width * this.Height; }
        }
        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

    }
}