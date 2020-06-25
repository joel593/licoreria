
using System;

namespace licoreria


{
    class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();

            int id = generador.Next();

            Console.WriteLine("FACTURACION");
            Console.WriteLine("");


            Console.WriteLine("Factura para el cliente");
            Console.WriteLine("");
            Persona persona = new Persona("Darwin", 175526, 20, 0987654321);

            Console.WriteLine("Nombre: {0}", persona.Nombre);
            Console.WriteLine("Cedula: {0}", persona.NumeroCedula);
            Console.WriteLine("Edad: {0}", persona.Edad);
            Console.WriteLine("Telefono: {0}", persona.Telefono);

            Console.WriteLine("");
            Console.WriteLine("detalles de compra");
            Console.WriteLine("1 funda de doritos");
            Console.WriteLine("");
            Snack snack = new Snack(1, "Fritos Tostitos Lay's", 60, 0.75, 1);

            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Marca: {0}", snack.Marca);
            Console.WriteLine("Peso: {0}g", snack.Peso);
            Console.WriteLine("Precio: {0}", snack.Precio);
            Console.WriteLine("Cantidad: {0}", snack.Cantidad);

            Console.WriteLine("");
            Console.WriteLine("1 Java de Cerveza");
            Console.WriteLine("");
            Licores licores = new Licores(2, "Club", 12, 18, 1);

            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Marca: {0}", licores.Marca);
            Console.WriteLine("Peso: {0}L", licores.Peso);
            Console.WriteLine("Precio: {0}$", licores.Precio);
            Console.WriteLine("Cantidad: {0}", licores.Cantidad);

            Console.WriteLine("");
            Console.WriteLine("1 cajetilla de tabacos");
            Console.WriteLine("");
            Tabacos tabacos = new Tabacos(3, "Larck", 20, 6.56, 1);

            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Marca: {0}", tabacos.Marca);
            Console.WriteLine("Unidades: {0}", tabacos.Unidades);
            Console.WriteLine("Precio: {0}$", tabacos.Precio);
            Console.WriteLine("Cantidad: {0}", tabacos.Cantidad);



        }
    }
}
