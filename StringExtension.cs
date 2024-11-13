using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMessage
{
    public static class StringExtension
    {
        public static string f(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsFull(this string value)
        {
            return !IsNullOrEmpty(value);
        }

        public static string q(this object value)
        {
            if (value is string str)
                return q(str);
            else if (value is double dbl)
                return q(dbl);
            else if (value is float sng)
                return q(sng);
            else if (value is decimal dic)
                return dic.ToString().Replace(",", "."); //TODO: Aggiungere .q() per Decimal
            else if (value is bool bol)
                return q(bol);
            else if (value is DateTime dt)
                return q(dt);
            else if (value == null && value is string)
                return "''";
            else if (value == null)
                return "NULL";
            return value.ToString();
        }
        public static string qt(this object value, bool considerTime = false)
        {
            if (value is DateTime dt)
                return qt(dt, considerTime);
            else if (value == null && value is string)
                return "''";
            else if (value == null)
                return "NULL";
            return value.ToString();
        }

        public static string q(this bool value)
        {
            return value ? "1" : "0";
        }

        public static string q(this bool? value)
        {
            return value.HasValue ? value.Value.q() : "NULL";
        }

        public static string q(this double value)
        {
            return value.ToString().Replace(",", ".");
        }

        public static string q(this float value)
        {
            return value.ToString().Replace(",", ".");
        }

        public static string q(this string value)
        {
            return $"'{value?.Replace("'", "''")}'";
        }

        public static string q(this DateTime value)
        {
            return "'{0:MM.dd.yyyy}'".f(value);
        }


    }
}
