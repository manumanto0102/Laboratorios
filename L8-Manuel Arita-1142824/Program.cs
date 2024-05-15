class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string entrada;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Ingrese 1 pasa sumatoria ");
            Console.WriteLine("Ingrese 2 para factorial");
            Console.WriteLine("Ingrese 3 para tablas");
            Console.WriteLine("Ingrese 4 para salida");
            entrada = Console.ReadLine();
            try
            {
                opcion = int.Parse(entrada);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Esta en sumatoria");
                        Console.WriteLine("Ingrese un valor positivo");
                        string entradanumero;
                        entradanumero = Console.ReadLine();
                        int n=0;
                            try{
                                n= int.Parse(entradanumero);
                            }
                            catch(FormatException){
                                Console.WriteLine("error ingrese un valor valido");
                            }
                            int i=0;
                            int sumatoria=0;
                            while(i<=n){
                                sumatoria+= i;
                                i++;
                            }
                            Console.WriteLine($"Sumatoria: {sumatoria}");

                                break;
                    case 2:
                        Console.WriteLine("Esta en factorial");
                        Console.WriteLine("Ingrese un valor positivo");
                        string entradanumero2;
                        entradanumero2 = Console.ReadLine();
                        int n2=0;
                            try{
                                n2= int.Parse(entradanumero2);
                            }
                            catch(FormatException){
                                Console.WriteLine("error ingrese un valor valido");
                            }
                            int j=1;
                            int factorial=1;
                            while(j<=n2){
                                factorial*=j;
                                j++;
                            }
                            Console.WriteLine($"Factorial: {factorial}");
                                    break;
                    case 3:
                        string titulo= "\t";
                        for(int k=1; k<=10; k++ ){
                            titulo +=k+"\t";
                        }
                        Console.WriteLine(titulo);
                        
                        string fila="";
                        for(int l=1; l<=10; l++ ){

                            fila=l+"\t";
                            for(int m=1; m<=10; m++ ){
                            fila+= l*m+"\t";
                            }
                            Console.WriteLine(fila);
                        }
                        
                                    break;
                    case 4:
                                    Console.WriteLine("Esta es la salida");
                                    break;
                    default:
                                    Console.WriteLine("ingrese un numero valido >:(");
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("error");
                            }
                        } while (opcion != 4);
                        Console.WriteLine("Gracias por participar, vuelva pronto");

                
                Console.WriteLine("A continuacion se realizara el ejercicio 2");
                int a=0;
                int b=0;
                int c=0;
                int cuenta=0;
                string pedro;

                Console.WriteLine("A continuacion ingrese su numero de cuenta y nombre del titular");
                Console.WriteLine("Cuenta:");
                cuenta=int.Parse(Console.ReadLine());
                Console.WriteLine("Titular:");
                pedro=Console.ReadLine();

                do{
                Console.WriteLine("Menu:");
                Console.WriteLine("Ingrese 1 pasa ver su saldo ");
                Console.WriteLine("Ingrese 2 para acreditar a su cuenta");
                Console.WriteLine("Ingrese 3 para debitar a su cuenta");
                Console.WriteLine("Ingrese 4 para salir");
                a = int.Parse(Console.ReadLine());
                switch(a){
                    case 1:
                    Console.WriteLine($"Su saldo es de: Q{c}");
                    break;

                    case 2:
                    Console.WriteLine("A continuacion ingrese la cantidad que desea acreditar a su cuenta");
                    b=int.Parse(Console.ReadLine());
                    c+=b;
                    Console.WriteLine($"Se acredito con exito la cantidad de: Q{b}");  
                    break;

                    case 3:
                    Console.WriteLine("A continuacion ingrese la cantidad que desea debitar de su cuenta");
                    b=int.Parse(Console.ReadLine());
                    c-=b;
                    Console.WriteLine($"Se debito con exito la cantidad de: Q{b}");                    
                    break;

                    case 4:
                    Console.WriteLine("Gracias vuelva pronto");
                    break;
                    
                    default:
                    Console.WriteLine("Por favor ingrese un numero valido");
                    break;

                }}while (a != 4);
                        Console.WriteLine("Gracias por participar, vuelva pronto");
                }
            }