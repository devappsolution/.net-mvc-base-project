using System.Text.RegularExpressions;
using System.Web;

namespace BoilerPlate.App.Extensions
{
    public static class HttpContextBaseExtension
    {
        public static string Token(this HttpRequestBase httpContext)
        {
            HttpCookie cookie = httpContext.Cookies["token"];

            if (cookie == null)
            {
                return null;
            }

            string token = cookie.Value;

            if (!Regex.IsMatch(token, "^[0-9A-F]{32}$"))
            {
                return null;
            }

            return token;
        }
    }
}
