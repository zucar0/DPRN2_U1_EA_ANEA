using System;
public class Factura{
    //Constructor vacío
    public void factura(){
    }
    //Declaración de datos miembro
    private string numeroDePieza;
    private string descripcionDePieza;
    private int cantidadDeArticulosAComprar =0;
    private double precioDelArticulo = 0.0;
    //Interfaz para el precio del artículo
    public double Precio{
        get{
            return precioDelArticulo;
        }
        set{
            if(value < 0){
                precioDelArticulo=0.0;
            }
            else{
                precioDelArticulo = value;
            }
        }
    }
    //Interfaz para la cantidad de artículos a comprar
    public int Cantidad{
        get{
            return cantidadDeArticulosAComprar;
        }
        set{
            if(value <= 0){
                cantidadDeArticulosAComprar=0;
            }
            else{
                cantidadDeArticulosAComprar=value;
            }
        }
    }
    //Interfaz para la descripcion del articulo o pieza
    public string Descripcion{
        get{
            return descripcionDePieza;
        }
        set{ 
            descripcionDePieza = value;
        }
    }
    //Interfaz para el número de pieza
    public string Numero{
        get{
            return numeroDePieza;
        }
        set{
            numeroDePieza=value;
        }
    }
    //Método obtenerMontoFactura con dos parámetros
    public double obtenerMontoFactura(double preciodelarticulo, int cantidaddearticulosacomprar){
        if(cantidaddearticulosacomprar<0 ){
            cantidaddearticulosacomprar=0;
        }
        if(preciodelarticulo<0){
            preciodelarticulo=0.0;
        }
        double montoSinIva= preciodelarticulo * cantidaddearticulosacomprar;
        double iva = preciodelarticulo * 0.16;
        double montoTotal = montoSinIva + iva;
        Console.WriteLine("Subtotal: " + montoSinIva);
        Console.WriteLine("Iva: " + iva);
        System.Console.WriteLine("Total: " + montoTotal);
        return montoTotal;
    }
    //Método obtenerMontoFactura con cuatro parámetros
    public double obtenerMontoFactura(double preciodelarticulo, int cantidaddearticulosacomprar, string numerodepieza, string descripciondepieza){
        if(cantidaddearticulosacomprar<0 ){
            cantidaddearticulosacomprar=0;
        }
        if(preciodelarticulo<0){
            preciodelarticulo=0.0;
        }
        double montoSinIva= preciodelarticulo * cantidaddearticulosacomprar;
        double iva = preciodelarticulo * 0.16;
        double montoTotal = montoSinIva + iva;
        Console.WriteLine("Subtotal: " + montoSinIva);
        Console.WriteLine("Iva: " + iva);
        Console.WriteLine("Total: " + montoTotal);
        return montoTotal;
    }
    //Destructor
    ~Factura() {
        numeroDePieza=""; 
        descripcionDePieza="";
        cantidadDeArticulosAComprar=0;
        precioDelArticulo = 0.0;
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}