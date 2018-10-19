using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Product_Display
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio_venta { get; set; }
        public int Precio_compra { get; set; }
        public int Cantidad_actual { get; set; }
        public int Cantidad_deseada { get; set; }
        public int Cantidad_faltante { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }

        public int Active { get; set; }

        public Product_Display()
        {

        }

        public Product_Display(string Codigo, string Nombre, int Precio_venta, int Precio_compra, int Cantidad_actual, int Cantidad_deseada, int Cantidad_faltante, string Proveedor, string Categoria, string Tipo, int Active)
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Precio_venta = Precio_venta;
            this.Precio_compra = Precio_compra;
            this.Cantidad_actual = Cantidad_actual;
            this.Cantidad_deseada = Cantidad_deseada;
            this.Cantidad_faltante = Cantidad_faltante;
            this.Proveedor = Proveedor;
            this.Categoria = Categoria;
            this.Tipo = Tipo;
            this.Active = Active;
        }
    }
}
