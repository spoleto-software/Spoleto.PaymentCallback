using System;
using System.Security.Cryptography;
using System.Text;

namespace Spoleto.PaymentCallback.Service.Helpers
{
    public static class HMACHelper
    {
        /// <summary>
        /// Вычисляет HMAC-SHA256 и кодирует в Base64
        /// https://www.jokecamp.com/blog/examples-of-creating-base64-hashes-using-hmac-sha256-in-different-languages/#csharp
        /// </summary>
        /// <returns></returns>
        public static string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        /// <summary>
        /// Читает тело запроса как строку для проверки HMAC. Включает буферизацию.
        /// </summary>
        public static async Task<string> ReadRequestBodyAsync(HttpRequest request, Encoding encoding = null)
        {
            if (!request.Body.CanSeek)
            {
                request.EnableBuffering();
            }

            request.Body.Position = 0;

            encoding ??= Encoding.UTF8;
            using var reader = new StreamReader(request.Body, encoding, detectEncodingFromByteOrderMarks: false, leaveOpen: true);
            var body = await reader.ReadToEndAsync();

            request.Body.Position = 0; 

            return body;
        }

        /// <summary>
        /// Проверяет HMAC подпись из заголовка запроса
        /// </summary>
        /// <param name="request">HTTP-запрос</param>
        /// <param name="secret">Секретный ключ (API secret)</param>
        /// <param name="headerName">Имя заголовка с HMAC (по умолчанию X-Content-HMAC)</param>
        /// <returns>true, если подпись совпадает</returns>
        public static async Task<bool> VerifyRequestHmacAsync(HttpRequest request, string secret, string headerName = "X-Content-HMAC")
        {
            var body = await ReadRequestBodyAsync(request);
            var expectedHmac = CreateToken(body, secret);
            var receivedHmac = request.Headers[headerName].FirstOrDefault();

            return string.Equals(expectedHmac, receivedHmac, StringComparison.Ordinal);
        }
    }
}
