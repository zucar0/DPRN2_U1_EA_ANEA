using System;
namespace DPRN2_U1_EA_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Evidencia de aprendizaje*/
            Factura factura = new Factura();
            Console.WriteLine("Ingresar el número de pieza");
            var numberofpiece = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto");
            var priceofproduct =  Console.ReadLine();
            double price = double.Parse(priceofproduct);
            Console.WriteLine("Ingresa la cantidad de artículos a comprar");
            var amountofitems =  Console.ReadLine();
            int amount = int.Parse(amountofitems);
            Console.WriteLine("Ingresa la descripción del artículo");
            var description = Console.ReadLine();
            // factura.Numero=numberofpiece;
            // factura.Precio=price;
            // factura.Cantidad=amount;
            // factura.Descripcion=description;
            Console.WriteLine("*************Método con dos parámetros**************");
            var montoCantidades = factura.obtenerMontoFactura(price,amount);
            Console.WriteLine("La factura es por un monto total de " + montoCantidades + " considerando un precio de " + price + " y una cantidad de " + amount );
            Console.WriteLine("*************Método con cuatro parémtros**************");
            var montoConDatos = factura.obtenerMontoFactura(price,amount,numberofpiece,description);
            Console.WriteLine("La factura es por un monto total de " + montoConDatos + " considerando un precio de " + price + " y una cantidad de " + amount );
            Console.WriteLine("El número de serie es " + numberofpiece + " y la descripción del producto es  " + description);
        }
    }
}
