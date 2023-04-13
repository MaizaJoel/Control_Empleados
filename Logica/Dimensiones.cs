using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Empleados.Logica
{
    public class Dimensiones
    {
        public static void DiseñoDataGridView(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Listado.BackgroundColor = Color.FromArgb(82, 69, 158);
            Listado.BackgroundColor = Color.Purple;
            Listado.EnableHeadersVisualStyles = false;

            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            Listado.RowHeadersVisible = false;

            Listado.ReadOnly = true;

            DataGridViewCellStyle titulos = new DataGridViewCellStyle();
            //titulos.Alignment = DataGridViewContentAlignment.BottomCenter;
            titulos.BackColor = Color.FromArgb(82, 69, 158);
            titulos.ForeColor = Color.Black;
            titulos.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = titulos;
        }
        public static void DiseñoEliminadosDataGridView(ref DataGridView Listado)
        {
            foreach (DataGridViewRow row in Listado.Rows)
            {
                string estado;
                estado = row.Cells["Estado"].Value.ToString();
                if (estado.Equals("ELIMINADO"))
                {
                    row.DefaultCellStyle.Font = new Font("ARIAL", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.LightPink;
                }
            }
        }

        public static object ValidacionNumerosDecimales(TextBox textBox, KeyPressEventArgs e)
        {
            //Convierte , a . por eso se asigna la posicion 0 que indico en el IF
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            //Valida que no se haga 12.2.2.2
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~textBox.Text.IndexOf(".") != 0))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && textBox.Text.IndexOf(",") >= 0)
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
            else
            {
                e.Handled = true;
            }
            return null;
        }
        #region PROBAR VERIFICACIÓN DECIMALES
        public static object Decimals(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if (IsDecimalSeparator(e.KeyChar))
            {
                e.KeyChar = GetDecimalSeparator();
            }
            else if (IsDigitOrControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (IsRepeatedDecimalSeparator(CajaTexto.Text, e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

            return null;
        }

        private static bool IsDecimalSeparator(char c)
        {
            return c == '.' || c == ',';
        }

        private static char GetDecimalSeparator()
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
        }

        private static bool IsDigitOrControl(char c)
        {
            return char.IsDigit(c) || char.IsControl(c);
        }

        private static bool IsRepeatedDecimalSeparator(string text, char c)
        {
            return (c == '.' && text.Contains(".")) || (c == ',' && text.Contains(","));
        }
        #endregion
        
        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
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
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
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
            else
            {
                e.Handled = true;
            }
            return null;
        }
    
        public static object SoloNumeros(TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
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
        
        public static long DateDiff (DateInterval intervalType, DateTime dateOne, DateTime dateTwo){
            switch (intervalType)
            {
                case DateInterval.DayOfYear:
                    TimeSpan spanForDays = dateTwo - dateOne;
                    return (long)spanForDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanForHours = dateTwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanForMinutes = dateTwo - dateOne;
                    return (long)spanForMinutes.TotalMinutes;
                case DateInterval.Month:
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanForSeconds = dateTwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanForWeekdays = dateTwo - dateOne;
                    return (long)(spanForWeekdays.TotalDays / 7.0);
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
