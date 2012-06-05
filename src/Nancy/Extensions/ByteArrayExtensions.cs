using System.IO;
using System.Text;

namespace Nancy.Extensions
{
    public static class ByteArrayExtensions
    {
        public static string DecodeAsUtf8(this byte[] source)
        {
            return Decode(source, Encoding.UTF8);
        }

        public static string Decode(this byte[] source, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream(source))
            using (var sr = new StreamReader(memoryStream, encoding))
                return sr.ReadToEnd();
        }
    }
}