using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassEncrypt
{
    public class encrypt
    {
        public static string encryptPass(string pass)
        {
            char[] ogPass = pass.ToCharArray();
            char[] newPass = new char[ogPass.Length];
            int different;
            for (int i =0; i < ogPass.Length;i++)
            {
                different = (int)ogPass[i] + 13;

                newPass[i] = (char)different;
            }

            string result = new string(newPass);
            return result;
        }
    }
    public class decrypt
    {
        public static string decryptPass(string pass)
        {
            char[] encrypt = pass.ToCharArray();
            char[] decrypt = new char[encrypt.Length];
            int different;
            for (int i = 0; i < encrypt.Length; i++)
            {
                different = (int)encrypt[i] - 13;
                decrypt[i] = (char)different;
            }

            string result = new string(decrypt);

            return result;
        }
    }
}

