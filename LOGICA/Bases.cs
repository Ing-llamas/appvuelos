using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading.Tasks;




namespace Proyecto.LOGICA
{
  public class Bases
    {
        public static void DiseñoDtv(ref DataGridView Listado) {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Listado.BackgroundColor = Color.Red;   
            // Listado.BackgroundColor = Color.FromArgb(29, 29 ,29);
            Listado.BackgroundColor = Color.Gray;
            Listado.EnableHeadersVisualStyles = false; //Desabilitar el estilo a la cabecera
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;




            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
          

            cabecera.BackColor = Color.FromArgb(0, 77, 243);
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

        }

        public static object Decimales(TextBox cajaTexto, KeyPressEventArgs e) {

            if ((e.KeyChar == '.') || (e.KeyChar == ',')) {

                //  comvierte la coma en punto  video agregar cargo min 25
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if ((e.KeyChar == ',') && (~cajaTexto.Text.IndexOf(",")) != 0)
            {
                e.Handled = true;
            }

            else if (e.KeyChar == '.')
            {
                e.Handled = false;

            }


            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }

            else {
                e.Handled = true;
            }

            return null;

        }

        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year

        }
        // CALCULAR LA DIFERENCIA ENTRE HORAS LONG TRABAJAR FECHA
        public static long DateDiff(DateInterval intervaloType, DateTime dateOne, DateTime dateTwo)
        {

            switch (intervaloType)
            {

                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    TimeSpan spanForDay = dateTwo - dateOne;
                    return (long)spanForDay.TotalDays;

                case DateInterval.Hour:
                    TimeSpan spanForHour = dateTwo - dateOne;
                    return (long)spanForHour.TotalHours;

                case DateInterval.Minute:
                    TimeSpan spanForMinute = dateTwo - dateOne;
                    return (long)spanForMinute.TotalMinutes;

                case DateInterval.Month:
                    return ((dateTwo.Year - dateOne.Year) * 12 + (dateTwo.Month - dateOne.Month));

                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;

                case DateInterval.Second:
                    TimeSpan spanForSeconds = dateTwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;


                case DateInterval.Weekday:
                    TimeSpan spanForWeekday = dateTwo - dateOne;
                    return (long)(spanForWeekday.TotalDays / 7.0);

                case DateInterval.WeekOfYear:
                    DateTime dateOneModified = dateOne;
                    DateTime dateTwoModified = dateTwo;

                    while (dateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {

                        dateTwoModified = dateTwoModified.AddDays(-1);
                    }

                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {

                        dateOneModified = dateOneModified.AddDays(-1);
                    }

                    TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
                    return (long)(spanForWeekOfYear.TotalDays / 7.0);

                case DateInterval.Year:
                    return dateTwo.Year - dateOne.Year;

                default:
                    return 0;

            }

        }

    }
}
