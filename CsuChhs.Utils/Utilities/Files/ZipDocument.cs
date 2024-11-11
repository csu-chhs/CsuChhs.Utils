namespace CsuChhs.Utils.Utilities.Files
{
    public class ZipDocument
    {
        public ZipDocument()
        {
            DocumentName = string.Empty;
            Document = [];
        }
        public string DocumentName { get; set; }
        public byte[] Document { get; set; }
    }
}
