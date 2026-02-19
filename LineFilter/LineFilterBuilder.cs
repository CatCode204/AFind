using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineFilter
{
	public class LineFilterBuilder
	{
		private LineFilter lineFilter = new NoLineFilter();
		
		public void SetContains(bool isContains, string strToFilter)
		{
			lineFilter = isContains ? new ContainsStrLineFilterDecorator(lineFilter, strToFilter) : new NoContainsStrLineFilterDecorator(lineFilter, strToFilter);
		}

		public void SetNumberLineToFilter(int num)
		{
			lineFilter = new LineNumberFilterDecorator(lineFilter, num);
		}

		public void SetCaseInSensitiveContains(bool isContains,string strToFilter)
		{
			lineFilter = isContains ? new ContainsCaseInsensitiveLineFilterDecorator(lineFilter,strToFilter) : new NoContainsCaseInsensitiveLineFilterDecorator(lineFilter,strToFilter);
		}

		public void Reset()
		{
			lineFilter = new NoLineFilter();
		}

		public LineFilter Build() => lineFilter;
	}
}
