using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinePrinter
{
	public class PrintOptions
	{
		public string FileName { get; set; } = String.Empty;
		public bool PrintLineNumber { get; set; } = false;

		public PrintMode PrintMode { get; set; } = PrintMode.LINE_MODE;
	}
}
