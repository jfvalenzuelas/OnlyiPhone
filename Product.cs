using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Product{
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio_venta { get; set; }
        public int Precio_compra { get; set; }
        public int Cantidad_actual { get; set; }
        public int Cantidad_deseada { get; set; }
        public int Cantidad_faltante { get; set; }
        public int Proveedor { get; set; }
        public int Categoria { get; set; }
        public int Tipo { get; set; }

        public int Activo { get; set; }

        public Product()
        {

        }

        public Product(string Codigo, string Nombre, int Precio_venta, int Precio_compra, int Cantidad_actual, int Cantidad_deseada, int Cantidad_faltante, int Proveedor, int Categoria, int Tipo, int Activo)
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
            this.Activo = Activo;
        }
    }
}
