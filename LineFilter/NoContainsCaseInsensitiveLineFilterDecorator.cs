using LineSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineFilter
{
	public class NoContainsCaseInsensitiveLineFilterDecorator(LineFilter lineFilter, string strToFilter) : LineFilterDecorator(lineFilter)
	{
		private readonly string strToFilter = strToFilter.ToUpper();

		public override Line[] Filter(Line[] lines)
		{
			var linesFiltered = lineFilter.Filter(lines);
			return linesFiltered.Where(x => x.Text.ToUpper().Contains(strToFilter)).ToArray();
		}
	}
}
