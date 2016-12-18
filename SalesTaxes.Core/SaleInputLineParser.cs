using System;
using System.Text.RegularExpressions;

namespace SalesTaxes.Core
{
	public class TextInputLineParser : InputLineParser
	{
		
		private Regex _regEx;
		private string _assignmentPattern = @"^(\d+) (imported)?(.*) at (.*)$";


		public TextInputLineParser ()
		{
			_regEx = new Regex (_assignmentPattern);
		}

		#region InputLineParser implementation
		public InputLine Parse (string input)
		{
			if (_regEx.IsMatch (input)) {
				var matches = Regex.Matches (input, _assignmentPattern, RegexOptions.IgnoreCase);
				var qty = matches [0].Groups [1].Value;
				var imported = matches [0].Groups [2].Value;
				var desc = matches [0].Groups [3].Value;
				var price = matches [0].Groups [4].Value;
				return new InputLine {
					Description = desc.Trim(),
					Imported = !string.IsNullOrEmpty(imported),
					LinePrice = Convert.ToDouble (price),
					Qty = Convert.ToInt32 (qty)

				};
			}
			throw new ArgumentException ($"The line {input} is not valid");
				
		}
		#endregion
		
	}
}

