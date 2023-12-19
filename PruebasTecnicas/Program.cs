using PooEnCSharp;
using PruebasTecnicas;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejercicio palindromo
         * 
        Palindromo p = new Palindromo("anita lava la tina");
        ResultadoPalindromo rs = p.esPalindromo();
        if (rs.Sucess == true)
        {
            Console.WriteLine("Es palindromo");
        }
        else
        {
            Console.WriteLine("No es palindromo");
        }

        */

        /*
         * Ejercicio TwoSum
         * 
        int[] numbers = { 7, 25, 11, 2 };
        int target = 9;
        
        TwoSum ts = new TwoSum(numbers, target);
        ResultadoSuma result = ts.sumaObjetivo();
        if (result.Sucess == true)
        {
            Console.WriteLine($"Indices: [{result.IndiceOperando1}, {result.IndiceOperando2}]");
        }
        else
        {
            Console.WriteLine("No se ha encontrado solucion");
        }

        */

        int Numbers = 19;
        HappyNumber hn = new HappyNumber(Numbers);
        ResultadoHappyNumber Resultado = hn.isHappyNumber();

        if (Resultado.Sucess == true)
        {
            Console.WriteLine($"El numero {Numbers} es un numero feliz");
        }
        else
        {
            Console.WriteLine($"El numero {Numbers} no es un numero feliz");
        }

        String _ransomNote = "aa";
        String _magazine = "aab";

        RansomNote rn = new RansomNote(_ransomNote,_magazine);
        ResultadoRansomNote resultadoRansomNote = rn.CanConstruct();

        if (resultadoRansomNote.Sucess = true)
        {
            Console.WriteLine($"Se puede construir RansomNote {_ransomNote} con las palabras obtenidas de {_magazine}");
        }
        else
        {
            Console.WriteLine("No se puede construir una RansomNote");
        }

        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        MaxArea mx = new MaxArea(height);
        ResultadoMaxArea rmx = mx.Contenedor();
        Console.WriteLine($"La superficie maxima obtenida del array es {rmx.SuperficieContenedor}");
    }
}