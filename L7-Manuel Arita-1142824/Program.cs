using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program{
   static void Main(string[] args){

    int nfibonacci;
    bool conversion=false;
    bool positivo=false;

    int a=0;
    int b=1;
    int c=0;
    int i=2;
    string resultado="";

    Console.WriteLine("a continuacion ingrese un numero mayor a 0");

    if(!int.TryParse(Console.ReadLine(), out nfibonacci)){
        do{
            Console.WriteLine("ingrese un numero mayor a 0");
            conversion= int.TryParse(Console.ReadLine(), out nfibonacci);
            if(conversion){
                if(nfibonacci>0){
                    positivo=true;
                }
            }
        }while(!conversion || !positivo);
    }

    if(nfibonacci>0){
        resultado=a + ", ";
        
        if(nfibonacci>1){
        resultado += b +", " ;

        while(i<nfibonacci){  
            c= a+b;
            resultado +=c+ ", ";
            a=b;
            b=c;
            i = i+1; 
        }
        
        Console.WriteLine($"su sucecion es: {resultado}");
    }}else{Console.WriteLine($"su numero es: {resultado}");}

   Console.WriteLine("trarea 1 parte 2");
   int x;
   int A;
   int k=0;
   int n;
   int e=0;
   double z=0;
   int y=1;
   double y2=0;
   double y3=0;
   double y1=1;
   string j="";
   string l="";

   Console.Write("Ingrese su primer valor: ");
   x=int.Parse(Console.ReadLine());
   Console.Write("Ingrese su segundo valor: ");
   A=int.Parse(Console.ReadLine());
   Console.Write("Ingrese su tercer valor: ");
   n=int.Parse(Console.ReadLine());
   
   Console.WriteLine("A continuacion de hara (x/1)+(x/2)+.....+(x/n)");
while(e!=n){
    z=x/y;
    j += z+",";
    y++;
    e++;
}Console.WriteLine(j);
e=0;
Console.WriteLine("A continuacion de hara (x/2^1)+(x/2^2)+.....+(x/2^n)");
while(e!=n){
    z=x/(2*y1);
    l += z+",";
    y1=y1*2;
    e++;
}Console.WriteLine(l);

Console.WriteLine("A continuacion de hara 𝑥ᵏ·𝑎ⁿ⁻ᵏ");
y2=Math.Pow(x, k);
y3=Math.Pow(A, (n-k));
z=y2*y3;
Console.WriteLine(z);   
   
   } 
}



