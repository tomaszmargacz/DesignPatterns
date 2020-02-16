namespace OpenClosed
{
    public abstract class Export
    {
        public abstract byte[] Execute();
    }

    public class PDF : Export
    {
        public override byte[] Execute()
        {
            return new byte[1024];
        }
    }

    public class Excel : Export
    {
        public override byte[] Execute()
        {
            return new byte[1024];
        }
    }
}
