using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFindOptions
{
	public class AFindOptionsDirector
	{
		private readonly AFindOptionsBuilder optionsBuilder;

		public AFindOptionsDirector(AFindOptionsBuilder optionsBuilder) 
		{ 
			this.optionsBuilder = optionsBuilder;
		}

		public AFindOptions Direct(string[] args)
		{
			foreach (var arg in args)
			{
				if (arg == "/v")
				{
					optionsBuilder.IsContains = false;
				} else if (arg == "/c")
				{
					optionsBuilder.IsCountMode = true;
				} else if (arg == "/n")
				{
					optionsBuilder.IsShowLineNumbers = true;
				} else if (arg == "/i")
				{
					optionsBuilder.IsCaseSensitive = false;
				} else if (arg == "/offline" || arg == "/off")
				{
					optionsBuilder.IsSkipOffline = false;
				} else if (arg == "/?")
				{
					optionsBuilder.IsHelpMode = true;
				}
				else
				{
					if (String.IsNullOrEmpty(optionsBuilder.StrToFind))
					{
						optionsBuilder.StrToFind = arg;
					}
					else if (String.IsNullOrEmpty(optionsBuilder.Path))
					{
						optionsBuilder.Path = arg;
					}
					else
					{
						throw new ArgumentException();
					}
				}
			}
			return optionsBuilder.Build();
		}
	}
}