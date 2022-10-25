using System.Text;

namespace Spoleto.PaymentCallback.AtolOnline
{
    public static class DefaultSettings
    {
        public const string ContentType = "application/json";
        public const string Charset = "utf-8";
        public readonly static Encoding Encoding = Encoding.GetEncoding(Charset);
    }
}
