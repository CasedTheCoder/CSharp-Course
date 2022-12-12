// Prueba de operaciones con int y float 

// Leyendo una variable a desde teclado
Console.WriteLine("Introduce el valor de a: ");
float a = Convert.ToSingle(Console.ReadLine());

// Leyendo una variable b desde teclado
Console.WriteLine("Introduce el valor de b: ");
float b = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("*******************");
Console.WriteLine("Introduce operacion");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");
Console.WriteLine("*******************");

// Leyendo un carácter desde teclado
char operacion = Convert.ToChar(Console.Read());

float c;


// Ejemplo de condicionales if, else if y else
if(operacion == '+'){
    c = a + b;    
    Console.WriteLine("El resultado es " + c);
}else if(operacion == '-'){
    c = a - b;
    Console.WriteLine("El resultado es " + c);
}else if(operacion == '*'){
    c = a * b;
    Console.WriteLine("El resultado es " + c);
}else if(operacion == '/'){
    c = a / b;
    Console.WriteLine("El resultado es " + c);
}else{
    Console.WriteLine("Operación no reconocida");
}


// Ejemplo de condicionales con Switch - Case
switch(operacion){
    case '+':
        c = a + b;    
        Console.WriteLine("El resultado es " + c);
        break;
    case '-':
        c = a - b;    
        Console.WriteLine("El resultado es " + c);
        break;
    case '*':
        c = a * b;    
        Console.WriteLine("El resultado es " + c);
        break;
    case '/':
        c = a / b;    
        Console.WriteLine("El resultado es " + c);
        break;
    default:
        Console.WriteLine("Operación no reconocida");
        break;
}