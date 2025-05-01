using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Project.WinFormUI.ViewModels
{
	public class ProductVM
	{
		public int ID { get; set; }
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public string CategoryName { get; set; }
		public int? CategoryID { get; set; }

		public override string ToString()
		{
			return $"{ProductName}, Price => {UnitPrice:C2}, Category => {CategoryName}";
		}
	}
}
