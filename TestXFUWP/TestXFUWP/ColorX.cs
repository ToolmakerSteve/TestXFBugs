using System;
using System.Collections.Generic;
using System.Text;

namespace TestXFUWP
{
	class ColorX
	{
		public static ColorX MakeMe()
		{
			return new ColorX(5.0);

		}

		public ColorX(float a)
		{

		}

		public ColorX(double a) : this((float)a) {

		}
	}
}
