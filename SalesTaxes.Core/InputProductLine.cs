using System;

namespace SalesTaxes.Core
{
	public class InputLine
	{
		public int Qty {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public double LinePrice {
			get;
			set;
		}

		public bool Imported {
			get;
			set;
		}


	}
}

