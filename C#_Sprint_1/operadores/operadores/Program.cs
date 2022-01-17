using System;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 6;
            int value2 = 3;

            Console.WriteLine("---------Operadores Aritmeticos----------");
            Console.WriteLine("Suma: " + (value1 + value2));
            Console.WriteLine("Resta: " + (value1 - value2));
            Console.WriteLine("Multiplicacion: " + (value1 * value2));
            Console.WriteLine("Division: " + (value1 / value2));
            Console.WriteLine("Suma: " + (value1 ^ value2));
            Console.WriteLine("Resto: " + (value1 % value2));


            Console.WriteLine("---------Operadores de Asignacion----------");

            int value3 = 2;
            int value4 = 2;
            value4 += value3;
            Console.WriteLine("Resultado: += " +value4);
            value4 -= value3;
            Console.WriteLine("Resultado: -= " + value4);
            value4 *= value3;
            Console.WriteLine("Resultado: *= "  + value4);
            value4 /= value3;
            Console.WriteLine("Resultado: /= " + value4);


            Console.WriteLine("---------Operadores de comparacion----------");

            int value5 = 9;
            int value6 = 2;
            var data = value5 <= value6;
            Console.WriteLine(data);


            Console.WriteLine("---------Operadores de igualdad----------");
            int value7 = 9;
            int value8 = 2;
            Console.WriteLine("Iguales?");
            data = value7 == value8;
            Console.WriteLine(data);

            Console.WriteLine("Distintos?");

            data = value7 != value8;
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
