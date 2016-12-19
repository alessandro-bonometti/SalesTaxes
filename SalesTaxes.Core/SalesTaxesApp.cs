using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SalesTaxes.Core
{
	public class SalesTaxesApp : SalesTaxes
	{
		ProductFactory _productFactory;

		TaxCalculator _taxCalculator;

		ProductPrinter _productPrinter;
		
		public SalesTaxesApp (ProductFactory productFactory, TaxCalculator taxCalculator, ProductPrinter productPrinter)
		{
			_productPrinter = productPrinter;
			_taxCalculator = taxCalculator;
			_productFactory = productFactory;
			
		}

		#region SalesTaxes implementation

		public void PrintSalesTaxes (IEnumerable<string> productLines)
		{

            _productFactory.CreateProducts(productLines)
                    .Select(p => p.CalculateTaxes(_taxCalculator))    
		    .ToList()
                    .PrintWith(_productPrinter);            		                        			
		}

		#endregion
	}


    public static class ProductExt
    {
        public static void PrintWith(this IEnumerable<Product> products, ProductPrinter printer)
        {
            printer.Print(products);
        }
    }

}

