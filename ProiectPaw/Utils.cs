using System.Security.Cryptography;
using System.Text;

namespace ProiectPaw {
    public class Utils {
        public static string ComputeSHA256Hash(string input) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        internal static bool IsValidEmail(string text) {
            //using regex to check if email is valid
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
