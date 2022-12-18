// Arrays

// Array inicializado
int[] numerosInicializados = new int[10]{1,2,3,4,5,6,7,8,9,10};

//Array sin inicializar
int[] numeros = new int[10];

// For loop

Console.WriteLine("Resultado For:");

for(int i = 0; i < numeros.Length; i++){
    numeros[i] = i + 1;
    Console.WriteLine(numeros[i]);
}


// Foreach loop

Console.WriteLine("Resultado ForEach:");

foreach(int numero in numeros){
    Console.WriteLine(numero);
}

// While loop

int j = 0;

Console.WriteLine("Resultado While:");

while(j < numeros.Length){
    Console.WriteLine(numeros[j]);
    j++;
}

// Do While loop

int z = 0;

Console.WriteLine("Resultado Do While:");

do{
    Console.WriteLine(numeros[z]);
    z++; 
}while(z < numeros.Length);

