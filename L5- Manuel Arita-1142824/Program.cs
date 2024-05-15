class Program{
    static void Main(string[] args){
        string n;
        double a;
        double b;
        double sum;
        double res;
        double divi;
        double mult;
        double mod;


        Console.WriteLine("Ingrese su nombre");
        n= Console.ReadLine();
        Console.WriteLine("hola "+n);

        Console.WriteLine("Parte 2, ejercicio 1");
        Console.WriteLine("A continuacion ingresara 2 numeros");
        a= Double.Parse(Console.ReadLine());
        b= Double.Parse(Console.ReadLine());
        Console.WriteLine("Sus numeros son "+a+" y "+b);
        sum=a+b;
        res=a-b;
        divi= a/b;
        mult=a*b;
        mod=a%b;
        Console.WriteLine("la operacion "+a+"+"+b+" es igual a "+sum);
        Console.WriteLine("la operacion "+a+"-"+b+" es igual a "+res);
        Console.WriteLine("la operacion "+a+"/"+b+" es igual a "+divi);
        Console.WriteLine("la operacion "+a+"*"+b+" es igual a "+mult);
        Console.WriteLine("la operacion "+a+"%"+b+" es igual a "+mod);

        bool mayor= a>b;
        bool menor= a<b;
        bool igual= a==b;

        Console.WriteLine("Ejercicio 2, a continuacion se hara la comparacion booleana de sus numeros");
        Console.WriteLine("indicar si "+a+" es mayor que "+b+", este valor es "+mayor);
        Console.WriteLine("indicar si "+a+" es menor que "+b+", este valor es "+menor);
        Console.WriteLine("indicar si "+a+" es igual a "+b+", este valor es "+igual);

        double c; 

        Console.WriteLine("Ejercicio 3, a continuacion se realizara una jerarquia de operaciones, para ello ingrese un valor extra");
        c= Double.Parse(Console.ReadLine());

        double multi2= (a*b)+c;
        double sum2= a*(b+c);
        double divi2= a/(b*c);
        double divi3= ((2*a)+(3*b))/(c*c);

        Console.WriteLine("la operacion 1 es "+a+"*"+b+" +"+c+" esto es igual a "+ multi2);
        Console.WriteLine("la operacion 2 es "+a+"* "+b+"+"+c+" esto es igual a "+ sum2);
        Console.WriteLine("la operacion 3 es "+a+"/"+b+"*"+c+" esto es igual a "+ divi2);
        Console.WriteLine("la operacion 4 es 2"+a+"+3"+b+"/"+c+"² esto es igual a "+ divi3);

        Console.WriteLine("Ejercicio 4, a continuacion se realizara una cuadratica con nuevos valores diferentes de 0");
        double e;
        double f;
        double g;
        double discrim;
        double x;

        e= Double.Parse(Console.ReadLine());
        f= Double.Parse(Console.ReadLine());
        g= Double.Parse(Console.ReadLine());

        if(e==0){ Console.WriteLine("Uno de sus valores es 0, cambielo a continuacion");
        e= Double.Parse(Console.ReadLine());
        };
        if(f==0){ Console.WriteLine("Uno de sus valores es 0, cambielo a continuacion");
        f= Double.Parse(Console.ReadLine());
        };
        if(g==0){ Console.WriteLine("Uno de sus valores es 0, cambielo a continuacion");
        g= Double.Parse(Console.ReadLine());
        };

        discrim=Math.Sqrt((f*f)-(4*e*g));
        x= ((-1*e)+Math.Sqrt((f*f)-(4*e*g)))/(2*e);
        if(discrim>=0){
        Console.WriteLine("El resultado de la cuadratica es "+ x);
        }else
        {Console.WriteLine("Sus valores no se pueden resolver mediante el metodo de cuadraticas");           
        }



    }
}