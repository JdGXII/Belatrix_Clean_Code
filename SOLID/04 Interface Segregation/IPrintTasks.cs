using System;

namespace SOLID._04_Interface_Segregation
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }

    public interface IBasicPrintable
    {
        bool PrintContent(string content);
    }

    public interface ICopyPrintable
    {
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    public interface IDuplexPrintable
    {
        bool PrintDuplexContent(string content);
    }

    public interface IFaxable
    {
        bool FaxContent(string content);
    }

    public class HPLaserJet : IBasicPrintable, ICopyPrintable, IDuplexPrintable, IFaxable
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }

    public class CannonMG2470 : IBasicPrintable, ICopyPrintable
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}
