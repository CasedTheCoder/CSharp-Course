using Calculator;

class Program{
    static void Main(string[] args){
        Program program = new Program();
        IntegerCalculator integerCalculator = new IntegerCalculator();
        FloatingCalculator floatingCalculator = new FloatingCalculator();

        program.PrintTitle();

        Console.WriteLine("Pulsa cualquier tecla para empezar");
        Console.ReadKey();

        // Integers
        int a = 1;
        integerCalculator.SetA(a);
        int b = 3;
        integerCalculator.SetB(b);

        int suma = integerCalculator.Suma();
        int resta = integerCalculator.Resta();
        int multiplicacion = integerCalculator.Multiplicacion();
        int division = integerCalculator.Division();

        Console.WriteLine("\nSuma de valores pre-establecidos: " + suma);
        Console.WriteLine("\nResta de valores pre-establecidos: " + resta);
        Console.WriteLine("\nMultiplicacion de valores pre-establecidos: " + multiplicacion);
        Console.WriteLine("\nDivision de valores pre-establecidos: " + division);

        Console.WriteLine("\nIntroduce valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIntroduce valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        integerCalculator.SetA(a);
        integerCalculator.SetB(b);

        suma = integerCalculator.Suma();
        resta = integerCalculator.Resta();
        multiplicacion = integerCalculator.Multiplicacion();
        division = integerCalculator.Division();

        Console.WriteLine("Suma de valores introducidos por teclado: " + suma);
        Console.WriteLine("\nResta de valores introducidos por teclado: " + resta);
        Console.WriteLine("\nMultiplicacion de valores introducidos por teclado: " + multiplicacion);
        Console.WriteLine("\nDivision de valores introducidos por teclado: " + division);


        Console.WriteLine("Integers listos, pulsa cualquier tecla para continuar");
        Console.ReadKey();

        // Float
        float af = 1;
        float bf = 3;

        floatingCalculator.SetA(af);
        floatingCalculator.SetB(bf);

        float sumaF = floatingCalculator.Suma();
        float restaF = floatingCalculator.Resta();
        float multiplicacionF = floatingCalculator.Multiplicacion();
        float divisionF = floatingCalculator.Division();

        Console.WriteLine("\nSuma de valores pre-establecidos: " + sumaF);
        Console.WriteLine("\nResta de valores pre-establecidos: " + restaF);
        Console.WriteLine("\nMultiplicacion de valores pre-establecidos: " + multiplicacionF);
        Console.WriteLine("\nDivision de valores pre-establecidos: " + divisionF);

        Console.WriteLine("\nIntroduce valor de a: ");
        af = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIntroduce valor de b: ");
        bf = Convert.ToInt32(Console.ReadLine());

        floatingCalculator.SetA(af);
        floatingCalculator.SetB(bf);
        
        sumaF = floatingCalculator.Suma();
        restaF = floatingCalculator.Resta();
        multiplicacionF = floatingCalculator.Multiplicacion();
        divisionF = floatingCalculator.Division();

        Console.WriteLine("Suma de valores introducidos por teclado: " + sumaF);
        Console.WriteLine("\nResta de valores introducidos por teclado: " + restaF);
        Console.WriteLine("\nMultiplicacion de valores introducidos por teclado: " + multiplicacionF);
        Console.WriteLine("\nDivision de valores introducidos por teclado: " + divisionF);

    }

    public void PrintTitle(){                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        Console.WriteLine("     CCCCCCCCCCCCC                                                   CCCCCCCCCCCCC                  lllllll                                       lllllll                           tttt                                               ");
        Console.WriteLine("   CCC::::::::::::C     ######    ######                           CCC::::::::::::C                  l:::::l                                       l:::::l                        ttt:::t                                               ");
        Console.WriteLine(" CC:::::::::::::::C     #::::#    #::::#                         CC:::::::::::::::C                  l:::::l                                       l:::::l                        t:::::t                                               ");
        Console.WriteLine("C:::::CCCCCCCC::::C     #::::#    #::::#                        C:::::CCCCCCCC::::C                  l:::::l                                       l:::::l                        t:::::t                                               ");
        Console.WriteLine("C:::::C       CCCCCC######::::######::::######                  C:::::C       CCCCCC  aaaaaaaaaaaaa    l::::l     ccccccccccccccccuuuuuu    uuuuuu   l::::l   aaaaaaaaaaaaa  ttttttt:::::ttttttt       ooooooooooo   rrrrr   rrrrrrrrr   ");
        Console.WriteLine("C:::::C              #::::::::::::::::::::::::#                 C:::::C                a::::::::::::a   l::::l   cc:::::::::::::::cu::::u    u::::u   l::::l   a::::::::::::a t:::::::::::::::::t     oo:::::::::::oo r::::rrr:::::::::r  ");
        Console.WriteLine("C:::::C              ######::::######::::######                 C:::::C                aaaaaaaaa:::::a  l::::l  c:::::::::::::::::cu::::u    u::::u   l::::l   aaaaaaaaa:::::at:::::::::::::::::t    o:::::::::::::::or:::::::::::::::::r ");
        Console.WriteLine("C:::::C                   #::::#    #::::#      --------------- C:::::C                         a::::a  l::::l c:::::::cccccc:::::cu::::u    u::::u   l::::l            a::::atttttt:::::::tttttt    o:::::ooooo:::::orr::::::rrrrr::::::r");
        Console.WriteLine("C:::::C                   #::::#    #::::#      -:::::::::::::- C:::::C                  aaaaaaa:::::a  l::::l c::::::c     cccccccu::::u    u::::u   l::::l     aaaaaaa:::::a      t:::::t          o::::o     o::::o r:::::r     r:::::r");
        Console.WriteLine("C:::::C              ######::::######::::###### --------------- C:::::C                aa::::::::::::a  l::::l c:::::c             u::::u    u::::u   l::::l   aa::::::::::::a      t:::::t          o::::o     o::::o r:::::r     rrrrrrr");
        Console.WriteLine("C:::::C              #::::::::::::::::::::::::#                 C:::::C               a::::aaaa::::::a  l::::l c:::::c             u::::u    u::::u   l::::l  a::::aaaa::::::a      t:::::t          o::::o     o::::o r:::::r            ");
        Console.WriteLine(" C:::::C       CCCCCC######::::######::::######                  C:::::C       CCCCCCa::::a    a:::::a  l::::l c::::::c     cccccccu:::::uuuu:::::u   l::::l a::::a    a:::::a      t:::::t    tttttto::::o     o::::o r:::::r            ");
        Console.WriteLine("C:::::CCCCCCCC::::C     #::::#    #::::#                        C:::::CCCCCCCC::::Ca::::a    a:::::a l::::::lc:::::::cccccc:::::cu:::::::::::::::uul::::::la::::a    a:::::a      t::::::tttt:::::to:::::ooooo:::::o r:::::r            ");
        Console.WriteLine(" CC:::::::::::::::C     #::::#    #::::#                         CC:::::::::::::::Ca:::::aaaa::::::a l::::::l c:::::::::::::::::c u:::::::::::::::ul::::::la:::::aaaa::::::a      tt::::::::::::::to:::::::::::::::o r:::::r            ");
        Console.WriteLine("   CCC::::::::::::C     ######    ######                           CCC::::::::::::C a::::::::::aa:::al::::::l  cc:::::::::::::::c  uu::::::::uu:::ul::::::l a::::::::::aa:::a       tt:::::::::::tt oo:::::::::::oo  r:::::r            ");
        Console.WriteLine("     CCCCCCCCCCCCC                                                   CCCCCCCCCCCCC  aaaaaaaaaa  aaaallllllll    cccccccccccccccc    uuuuuuuu  uuuullllllll  aaaaaaaaaa  aaaa         ttttttttttt     ooooooooooo    rrrrrrr            ");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        


        Console.WriteLine("\n");
    }
    
}
