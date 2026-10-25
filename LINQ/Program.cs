using LINQ.Helpers;                      // StringCaseInsensitiveComparer (Q12)
using static LINQ.DataSources.Source;    // ProductList

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// [Q3] Sort by UnitPrice ascending
			//Console.WriteLine("--- A1-Q3 ---");
			//var a1q3 = ProductList.OrderBy(p => p.UnitPrice);
			//foreach (var p in a1q3)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");


			// [Q8] Category ascending, then UnitPrice descending
			//	Console.WriteLine("--- A1-Q8 ---");
			//	var a1q8 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
			//	foreach (var p in a1q8)
			//		Console.WriteLine($"{p.Category} | {p.ProductName} | {p.UnitPrice}");

			// [Q9] Beverages sorted by UnitsInStock descending
			//Console.WriteLine("--- A1-Q9 ---");
			//var a1q9 = ProductList
			//	.Where(p => p.Category == "Beverages")
			//	.OrderByDescending(p => p.UnitsInStock);
			//foreach (var p in a1q9)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

			// [Q12] Sort by word length, then case-insensitive alphabetical
			//Console.WriteLine("--- A1-Q12 ---");
			//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			//var a1q12 = Arr
			//	.OrderBy(w => w.Length)
			//	.ThenBy(w => w, new StringCaseInsensitiveComparer());
			//foreach (var w in a1q12)
			//	Console.WriteLine(w);
		}
	}
}