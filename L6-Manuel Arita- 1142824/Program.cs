class Program{
static void Main( string[]args){
int num;
string mes;
Console.WriteLine("Ingrese su numero de mes bajo la logica de: 1-enero y 12-diciembre");
num= int.Parse(Console.ReadLine());

if(num<1){
Console.WriteLine($"Error, se introdujo un numero de mes no correspondiente '{num}' introduzca uno nuevo");
num=int.Parse(Console.ReadLine());
};
if(num>12){
Console.WriteLine($"Error, el numero de mes '{num}' no existe o no es valido, introduzca uno nuevo");
num=int.Parse(Console.ReadLine());
};

Console.WriteLine($"El numero correspondiende al mes es: '{num}'");

switch(num){
    case 1:
    mes="Enero";
    break;

    case 2:
    mes="Febrero";
    break;
    
    case 3:
    mes="Marzo";
    break;

    case 4:
    mes="Abril";
    break;

    case 5:
    mes="Mayo";
    break;

    case 6:
    mes="Junio";
    break;

    case 7:
    mes="Julio";
    break;

    case 8:
    mes="Agosto";
    break;

    case 9:
    mes="Septiembre";
    break;

    case 10:
    mes="Octubre";
    break;

    case 11:
    mes="Noviembre";
    break;


    case 12:
    mes="Diciembre";
    break;

    default:
    mes="";
    Console.WriteLine("Error, se debe ingresar un numero del 1-12");
    break;}

Console.WriteLine($"Mes: '{mes}'");

int a;
int b;
int c;

Console.WriteLine("ejercicio 2");
Console.WriteLine("Ingrese 3 valores enteros mayores a 0");
Console.WriteLine("Ingrese el primer valor");
a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo valor");
b=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer valor");
c=int.Parse(Console.ReadLine());

if(a==0){
    Console.WriteLine("ingrese otro valor");
    a=int.Parse(Console.ReadLine());
} 
if(b==0){
    Console.WriteLine("ingrese otro valor");
    b=int.Parse(Console.ReadLine());
} 
if(c==0){
    Console.WriteLine("ingrese otro valor");
    c=int.Parse(Console.ReadLine());
}

if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine(a + " es el mayor.");
                if (b <= c)
                {
                    Console.WriteLine(b + " es el menor.");
                    Console.WriteLine(c + " es el del medio.");
                }
                else
                {
                    Console.WriteLine(c + " es el menor.");
                    Console.WriteLine(b + " es el del medio.");
                }
            }
            else
            {
                Console.WriteLine(c + " es el mayor.");
                Console.WriteLine(a + " es el del medio.");
                Console.WriteLine(b + " es el menor.");
            }
        }
        else
        {
            if (b >= c)
            {
                Console.WriteLine(b + " es el mayor.");
                if (a <= c)
                {
                    Console.WriteLine(a + " es el menor.");
                    Console.WriteLine(c + " es el del medio.");
                }
                else
                {
                    Console.WriteLine(c + " es el menor.");
                    Console.WriteLine(a + " es el del medio.");
                }
            }
            else
            {
                Console.WriteLine(c + " es el mayor.");
                Console.WriteLine(b + " es el del medio.");
                Console.WriteLine(a + " es el menor.");
            }
        }

Console.WriteLine("a continuacion identificaremos su signo sodiacal");
int ano;
string mes2;
int dia;
Console.Write("Coloque su año de nacimiento: ");
ano=int.Parse(Console.ReadLine());

Console.Write("Coloque su mes de nacimiento en minusculas: ");
mes2=Console.ReadLine();

Console.Write("Coloque su dia de nacimiento: ");
dia=int.Parse(Console.ReadLine());

Console.WriteLine($"Usted nacio el año de: '{ano}' ");
Console.WriteLine($"En el mes de: '{mes2}' ");
Console.WriteLine($"El dia: '{dia}' ");

if(mes2 == "enero"){
if(dia<=19){Console.WriteLine("Su signo es: capricornio");}
if(dia>=20){Console.WriteLine("su signo es: acuario");}
}

if(mes2 == "febrero"){
if(dia<=19){Console.WriteLine("Su signo es: acuario");}
if(dia>=18){Console.WriteLine("su signo es: piscis");}
}

if(mes2 == "marzo"){
if(dia<=20){Console.WriteLine("Su signo es: piscis");}
if(dia>=21){Console.WriteLine("su signo es: Aries");}
}

if(mes2 == "abril"){
if(dia<=19){Console.WriteLine("Su signo es: aries");}
if(dia>=20){Console.WriteLine("su signo es: tauro");}
}

if(mes2 == "mayo"){
if(dia<=20){Console.WriteLine("Su signo es: tauro");}
if(dia>=21){Console.WriteLine("su signo es: geminis");}
}

if(mes2 == "junio"){
if(dia<=20){Console.WriteLine("Su signo es: geminis");}
if(dia>=21){Console.WriteLine("su signo es: cancer");}
}

if(mes2 == "julio"){
if(dia<=22){Console.WriteLine("Su signo es: cancer");}
if(dia>=23){Console.WriteLine("su signo es: leo");}
}

if(mes2 == "agosto"){
if(dia<=22){Console.WriteLine("Su signo es: leo");}
if(dia>=23){Console.WriteLine("su signo es: virgo");}
}

if(mes2 == "septiembre"){
if(dia<=22){Console.WriteLine("Su signo es: virgo");}
if(dia>=23){Console.WriteLine("su signo es: libra");}
}

if(mes2 == "octubre"){
if(dia<=22){Console.WriteLine("Su signo es: libra");}
if(dia>=23){Console.WriteLine("su signo es: escorpio");}
}

if(mes2 == "noviembre"){
if(dia<=21){Console.WriteLine("Su signo es: escorpio");}
if(dia>=22){Console.WriteLine("su signo es: sagitario");}
}

if(mes2 == "diciembre"){
if(dia<=21){Console.WriteLine("Su signo es: sagitario");}
if(dia>=22){Console.WriteLine("su signo es: capricornio");}
}
}
}