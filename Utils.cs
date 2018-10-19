using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace OnlyIphone
{
    /// <summary>
    /// Class that contains several utility methods
    /// </summary>
    public class Utils
    {


        /// <summary>
        /// Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(text);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// <summary>
        /// Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(text);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        /// <summary>
        /// Firsts the letter to upeer.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string FirstLetterToUpeer(string text)
        {
             text = text.ToLower().Trim();
             text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
             return text;
 
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)

                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)

                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                table.Rows.Add(row);
            }
            return table;
        }


    }
}
