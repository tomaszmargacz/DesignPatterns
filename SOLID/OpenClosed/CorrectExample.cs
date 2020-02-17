namespace OpenClosed
{
    public abstract class Export
    {
        public abstract byte[] Execute();
    }

    public class PDFExport : Export
    {
        public override byte[] Execute()
        {
            return new byte[1024];
        }
    }

    public class ExcelExport : Export
    {
        public override byte[] Execute()
        {
            return new byte[1024];
        }
    }
}
