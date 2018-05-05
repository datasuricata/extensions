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
            return (DateTime.Compare(data, dataParametro));
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
            return (dataParametro >= dataIni && dataParametro <= dataFim);
        }

        public static bool IsTimeBetween(this TimeSpan horaParametro, TimeSpan horaIni, TimeSpan horaFim)
        {
            return (horaParametro >= horaIni && horaParametro <= horaFim);
        }
    }
}
