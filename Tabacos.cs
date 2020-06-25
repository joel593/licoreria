using System;
using System.Collections.Generic;
using System.Text;

namespace licoreria
{
    class Tabacos
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public float Unidades { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Tabacos(int id, string marca, float unidades, double precio, int cantidad)
        {
            this.Id = id;
            this.Marca = marca;
            this.Unidades = unidades;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }



    }
}
