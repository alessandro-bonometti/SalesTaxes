using NUnit.Framework;
using System;

namespace SalesTaxes.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void FailingTest ()
		{
			Assert.Fail ();
		}

		[Test]
		public void Input1()
		{
			var line1 = "1 book at 12.49";
			var line2 = "1 book at 12.49";
			var line3 = "1 chocolate bar at 0.85";			


			var outLine1 = "1 book : 12.49";
			var outLine2 = "1 music CD: 16.49";
			var outLine3 = "1 chocolate bar: 0.85";
			var outLine4 = "Sales Taxes: 1.50";
			var outLine5 = "Total: 29.83";


		}

		[Test]
		public void Input2()
		{
			var line1 = "1 imported box of chocolates at 10.00";
			var line2 = "1 imported bottle of perfume at 47.50";

			var outLine1 = "1 imported box of chocolates: 10.50";
			var outLine2 = "1 imported box of chocolates: 10.50";
			var outLine3 = "Sales Taxes: 7.65";
			var outLine4 = "Total: 65.15";

		}


		[Test]
		public void Input3()
		{
			var line1 = "1 imported bottle of perfume at 47.50";
			var line2 = "1 bottle of perfume at 18.99";
			var line3 = "1 packet of headache pills at 9.75";
			var line4 = "1 box of imported chocolates at 11.25";

			var outLine1 = "1 imported bottle of perfume: 32.19";
			var outLine2 = "1 bottle of perfume: 20.89";
			var outLine3 = "1 packet of headache pills: 9.75";
			var outLine4 = "1 imported box of chocolates: 11.85";
			var outLine5 = "Sales Taxes: 6.70";
			var outLine6 = "Total: 74.68";
		}



}

