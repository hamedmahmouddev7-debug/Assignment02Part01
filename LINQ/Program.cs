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
			//}
		}
	}
}