using System.Numerics;

class Automovil{
public int modelo;
public double precio;
public string marca;
public bool disponible;
public double cambiodolar;
public double descuento; 

public Automovil(){

}
public int definirmodelo(int ano){
    modelo=ano;
    return modelo;
}
public double definirprecio(double preciof){
    precio=preciof;
    return precio;
}
public string definirmarca(string marcas){
    marca=marcas;
    return marca;
}
public bool cambiardisponible(bool seee){
    disponible=seee;
    return disponible;
}
public double definircambio(double cambio){
    cambiodolar=cambio;
    return cambiodolar;
}
public double aplicardescuento(double descuentof){
    descuento=descuentof;
    return descuento;
}
}