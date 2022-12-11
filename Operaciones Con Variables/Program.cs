// Prueba de operaciones con int y float 

// Leyendo una variable a desde teclado
Console.WriteLine("Introduce el valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());

// Leyendo una variable b desde teclado
Console.WriteLine("Introduce el valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

// Sumando a y b
int c = a + b;
Console.WriteLine("La suma de a y b es " + c);

// Restando a y b
c = a - b;
Console.WriteLine("La resta de a y b es " + c);

// Multiplicando a y b
c = a * b;
Console.WriteLine("La multiplicacion de a y b es " + c);

// Dividiendo a y b enteros
c = a / b;
Console.WriteLine("La division de a y b es " + c);

// Dividiendo a y b flotantes
float z = (float)a / (float)b;
Console.WriteLine("La division flotante de a y b es " + z);


// Prueba de operaciones con string
string hola = "Hola";
string adios = " Adios";

// Sumandos dos strings
string frase = hola + adios;

Console.WriteLine(frase);