using System;
using System.Collections.Generic;
using System.Text;

namespace licoreria
{
    class Licores
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public float Peso { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Licores(int id, string marca, float peso, double precio, int cantidad)
        {
            this.Id = id;
            this.Marca = marca;
            this.Peso = peso;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }



    }
}
