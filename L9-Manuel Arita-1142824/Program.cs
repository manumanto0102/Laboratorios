using System.Diagnostics.Contracts;
using System.Dynamic;

class Program{
    static void Main(String[] args){
int x;
double p;
string m;
bool di;
double c;
double de; 

    Automovil objcarrino= new Automovil();
int numero;
Console.WriteLine("Ingrese 1 para ver la diponibilidad");
Console.WriteLine("Ingrese 2 para ver Modificar el catalogo");
Console.WriteLine("Ingrese 3 para aplicar descuento");
Console.WriteLine("Ingrese 4 para ver la diponibilidad actualizada");
Console.WriteLine("Ingrese 5 para salir");

numero=int.Parse(Console.ReadLine());
switch(numero){
    case 1:
    Console.WriteLine("Modelo: "+objcarrino.definirmodelo(2019));
    Console.WriteLine("Precio: "+objcarrino.definirprecio(10000.00));
    Console.WriteLine("Marca: "+objcarrino.definirmarca(""));
    Console.WriteLine("Disponibilidad: "+objcarrino.cambiardisponible(false));
    Console.WriteLine("Cambio de Q a dolar: "+objcarrino.definircambio(7.50));
    Console.WriteLine("Descuento: "+objcarrino.aplicardescuento(0.00)); 
    break;
    
    case 2:
    Console.WriteLine("Ingrese el modelo");
    x=int.Parse(Console.ReadLine());
    objcarrino.definirmodelo(x);

    Console.WriteLine("Ingrese el precio");
    p=double.Parse(Console.ReadLine());
    objcarrino.definirprecio(p);

    Console.WriteLine("Ingrese la marca");
    m=Console.ReadLine();
    objcarrino.definirmarca(m);

    Console.WriteLine("Ingrese la disponibilidad");
    di=bool.Parse(Console.ReadLine());
    objcarrino.cambiardisponible(di);

    Console.WriteLine("Ingrese el tipo de cambio");
    c=double.Parse(Console.ReadLine());
    objcarrino.definircambio(c);
    break;

    case 3:
    break;

    case 4:
    break;

    default:
    break;
    }
}
}