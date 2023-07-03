using System.Globalization;

namespace PetTracker.Utilities;

public static class Extensions
{
    public static short ToInt16(this object obj)
        {
            short result = 0;

            if (obj != null)
            {
                if (short.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static int ToInt32(this object obj)
        {
            var result = 0;

            if (obj != null)
            {
                if (int.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static double ToDouble(this object obj)
        {
            double result = 0;

            if (obj != null)
            {
                if (double.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static long ToInt64(this object obj)
        {
            long result = 0;

            if (obj != null)
            {
                if (long.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static byte ToByte(this object obj)
        {
            byte result = 0;

            if (obj != null)
            {
                if (byte.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static byte? ToNullableByte(this object obj)
        {
            if (string.IsNullOrEmpty(obj.ToString())) return null;
            const byte result = 0;
            return byte.TryParse(obj.ToString(), out var value) ? value : result;
        }

        public static decimal ToDecimal(this object obj)
        {
            decimal result = 0;

            if (obj != null)
            {
                if (decimal.TryParse(obj.ToString(), out var value))
                    result = value;
            }

            return result;
        }

        public static int? ToIntegerNull(this object obj)
        {
            if (obj != null)
            {
                if (int.TryParse(obj.ToString(), out var value))
                {
                    return value;
                }
            }

            return null;
        }

        public static string ToSqlDateString(this object obj, bool addHour = true)
        {
            var result = string.Empty;

            if (obj != null)
            {
                if (DateTime.TryParse(obj.ToString(), out var value))
                {
                    if (addHour)
                    {
                        result =
                            $"{value.Year}-{AddZero(value.Month)}-{AddZero(value.Day)} {AddZero(value.Hour)}:{AddZero(value.Minute)}:{AddZero(value.Second)}";
                    }
                    else
                    {
                        result = $"{value.Year}-{AddZero(value.Month)}-{AddZero(value.Day)}";
                    }
                }
            }

            return result;
        }

        public static DateTime ToDateTime(this object obj)
        {
            var result = DateTime.MinValue;

            if (obj != null)
            {
                if (DateTime.TryParse(obj.ToString(), out var value))
                {
                    return value;
                }
            }

            return result;
        }

        public static DateTime ToDateTime(this object obj, string format)
        {
            var result = DateTime.MinValue;

            if (obj != null) result = DateTime.ParseExact(obj.ToString(), format, CultureInfo.InvariantCulture);
            return result;
        }

        public static TimeSpan ToTime(this object obj)
        {
            var result = TimeSpan.MinValue;

            if (obj != null)
            {
                if (TimeSpan.TryParse(obj.ToString(), out var value))
                {
                    return value;
                }
            }

            return result;
        }

        public static bool ToBoolean(this object obj)
        {
            var result = false;

            if (obj != null)
            {
                return (obj.ToInt32() > 0) || (obj.ToString().ToLower().Equals("true"));
            }

            return result;
        }

        public static bool? ToNullableBoolean(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            return (obj.ToInt32() > 0) || (obj.ToString().ToLower().Equals("true"));
        }

        public static string AddZero(int input)
        {
            if (input.ToString().Length.Equals(1))
            {
                return "0" + input;
            }

            return input.ToString();
        }
        public static IList<T> OrEmptyIfNull<T>(this IList<T> source)
        {
            return source ?? Array.Empty<T>();
        }
}