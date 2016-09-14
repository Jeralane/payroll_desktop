using System;
using System.Security.Cryptography;
using System.Text;

namespace PayrollSystem.Helpers
{
    public static class DataConverter
    {

        internal static string ToUtf8String(object param)
        {
            return param == DBNull.Value ? string.Empty : Encoding.UTF8.GetString(ToByteArray(param));
        }

        internal static bool ToBoolean(object param)
        {
            return param != DBNull.Value && Convert.ToBoolean(param);
        }

        internal static string ToString(object param)
        {
            return param == DBNull.Value ? string.Empty : Convert.ToString(param);
        }

        internal static decimal ToDecimal(object param)
        {
            return param == DBNull.Value ? 0m : Convert.ToDecimal(param);
        }

        internal static DateTime ToDateTime(object param)
        {
            return param == DBNull.Value ? new DateTime() : Convert.ToDateTime(param);
        }

        internal static DateTime? ToNullableDateTime(object param)
        {
            return param == DBNull.Value ? (DateTime?) null : Convert.ToDateTime(param);
        }

        internal static int ToInteger(object param)
        {
            return param == DBNull.Value ? 0 : Convert.ToInt32(param);
        }

        public static char ToCharacter(object param)
        {
            return param == DBNull.Value ? ' ' : Convert.ToChar(param);
        }

        public static byte[] ToByteArray(object param)
        {
            return param == DBNull.Value ? new byte[0] : (byte[]) (param);
        }

        public static string GenerateMySQLHash(string key)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            SHA1Managed enc = new SHA1Managed();
            byte[] encodedKey = enc.ComputeHash(enc.ComputeHash(keyArray));
            StringBuilder myBuilder = new StringBuilder(encodedKey.Length);

            foreach (byte b in encodedKey)
                myBuilder.Append(b.ToString("X2"));

            return "*" + myBuilder;
        }

    }
}
