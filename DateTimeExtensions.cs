using System;

namespace SuricataModeler.Build.Domain.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime? FirstTimeOfDay(this DateTime data)
        {
            return data.Date;
        }

        public static DateTime? LastTimeOfDay(this DateTime data)
        {
            return data.Date.AddDays(1).AddSeconds(-1);
        }

        public static DateTime? FirstTimeOfDay(this DateTime? data)
        {
            return data.Value.Date;
        }

        public static DateTime? LastTimeOfDay(this DateTime? data)
        {
            return data.Value.Date.AddDays(1).AddSeconds(-1);
        }

        public static int DiffDays(this DateTime data, DateTime dataParametro)
        {
            var date = (DateTime.Compare(data, dataParametro));
            return date;
        }

        public static int DiffDays(this DateTime data, DateTime? dataParametro)
        {
            var dias = ((dataParametro ?? DateTime.Now) - data).Days + 1;
            return dias;
        }

        public static int DiffDaysNow(this DateTime data)
        {
            var dias = (DateTime.Now - data).Days + 1;

            return dias;
        }

        public static bool IsDateBetween(this DateTime dataParametro , DateTime dataIni, DateTime dataFim)
        {
            return (dataParametro.Date >= dataIni.Date && dataParametro.Date <= dataFim.Date);
        }

        public static bool IsTimeBetween(this TimeSpan horaParametro, TimeSpan horaIni, TimeSpan horaFim)
        {
            return (horaParametro >= horaIni && horaParametro <= horaFim);
        }

        public static DateTime FirstDayOfMonth(this DateTime data)
        {
            return new DateTime(data.Year,data.Month,1);
        }

        public static DateTime ToDateTime(this string data)
        {
            return !string.IsNullOrEmpty(data) ? DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture) : DateTime.MinValue;
        }

        public static DateTime ToDateTimehhmm(this string data)
        {
            return !string.IsNullOrEmpty(data) ? DateTime.ParseExact(data, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.MinValue;
        }

        public static DateTime? ToNullableDateTime(this string data)
        {
            return !string.IsNullOrEmpty(data) ? DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture) : (DateTime?)null;
        }

        public static DateTime LastDayOfMonth(this DateTime data)
        {
            var first = new DateTime(data.Year, data.Month, 1);
            return first.AddMonths(1).AddDays(-1);
        }

        public static TimeSpan IncrementMinutes(this TimeSpan time, int value)
        {
            return TimeSpan.FromMinutes(time.TotalMinutes + value);
        }
    }
}
