using AFindOptions;
using LineSource;
using LineFilter;
using LinePrinter;

namespace AFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("FIND: Parameter format not correct");
            }

            AFindOptionsBuilder builder = new AFindOptionsBuilder();
            AFindOptionsDirector optionsDirector = new AFindOptionsDirector(builder);
            var options = optionsDirector.Direct(args);

            var sources = !string.IsNullOrEmpty(options.Path) ? LineSourceFactory.CreateFileLinesSource(options.Path,options.IsSkipOffline) : [LineSourceFactory.CreateConsoleLineSource()];
        
            var lineFilterBuilder = new LineFilterBuilder();
            var lineFilterDirector = new LineFilterDirector(lineFilterBuilder);

            var lineFilterOptions = new FilterOptions();
            lineFilterOptions.FilterContains = options.IsContains;
            lineFilterOptions.FilterStrings.Add(options.StrToFind);

            var lineFilter = lineFilterDirector.Direct(lineFilterOptions);

            var linePrinterBuilder = new PrinterStragetyBuilder();
            // linePrinterBuilder.PrintOptions.FileName = options.Path;
            linePrinterBuilder.PrintOptions.PrintMode = options.IsCountMode ? PrintMode.TOTAL_LINE_NUMBER : PrintMode.LINE_MODE;
            linePrinterBuilder.PrintOptions.PrintLineNumber = options.IsShowLineNumbers;

            PrinterContext printerContext = new PrinterContext();

            foreach (var source in sources)
            {
                var lines = source.GetLines();
                var filteredLines = lineFilter.Filter(lines);

                // Try casting and assign to builder option path
                FileLineSource? fileLineSource = source as FileLineSource;
                linePrinterBuilder.PrintOptions.FileName = fileLineSource != null ? fileLineSource.Path : String.Empty;
                var stragety = linePrinterBuilder.Build(filteredLines);

                printerContext.Stragety = stragety;
                printerContext.Excute();

                Console.WriteLine("===================================================\n\n\n\n");
            }
        }
    }
}
