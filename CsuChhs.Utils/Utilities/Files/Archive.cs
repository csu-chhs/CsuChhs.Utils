using System.IO.Compression;

namespace CsuChhs.Utils.Utilities.Files
{
    public class Archive
    {
        private ICollection<ZipDocument> _zipDocuments;

        public Archive()
        {
            _zipDocuments = new List<ZipDocument>();
        }

        public Archive(List<ZipDocument> documents)
        {
            _zipDocuments = documents;
        }

        /// <summary>
        /// Adds a Zip Document to the collection to be zipped up.
        /// </summary>
        /// <param name="document"></param>
        public void AddDocument(ZipDocument document)
        {
            _zipDocuments.Add(document);
        }

        /// <summary>
        /// Returns a compressed zip byte[] of
        /// Zip Documents
        /// </summary>
        /// <returns></returns>
        public byte[] CreateZipArchive()
        {
            byte[] zipArchive;

            using (var archiveStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                {
                    foreach (var item in _zipDocuments)
                    {
                        var zipArchiveEntry = archive.CreateEntry(item.DocumentName, CompressionLevel.Fastest);
                        using(var zipStream = zipArchiveEntry.Open())
                            zipStream.Write(item.Document, 0, item.Document.Length);
                    }
                }

                zipArchive = archiveStream.ToArray();
            }

            return zipArchive;
        }
    }
}
