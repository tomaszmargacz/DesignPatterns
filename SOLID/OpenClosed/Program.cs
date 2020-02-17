using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Export export = FindExport(args[0]);
            export.Execute();
        }

        public static Export FindExport(string type)
        {
            return type switch
            {
                "PDF" => new PDFExport(),
                "Excel" => new ExcelExport(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
