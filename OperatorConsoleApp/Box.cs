using System;
namespace OperatorConsoleApp
{
	public class Box
	{
		public Box()
		{
		}

		private double length;
		private double breadth;
		private double height;

		public double GetVolume()
		{
			return length * breadth * height;
		}

		public double GetLength()
		{
			return length;
		}

		public void SetLength(double len)
		{
			this.length = len;
		}

		public double GetBreadth()
		{
			return breadth;
		}

		public void SetBreadth(double bre)
		{
			this.breadth = bre;
		}

		public double GetHeight()
		{
			return height;
		}

		public void SetHeight(double hei)
		{
			this.height = hei;
		}

		// overload + operator
		public static Box operator+ (Box b, Box c)
		{
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;

        }
    }
}

