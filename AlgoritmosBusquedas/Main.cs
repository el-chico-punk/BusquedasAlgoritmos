using Busquedas;

internal class Program
{
    private static void Main(string[] args)
    {

        int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = 2;

        int Sequentialresult = BusquedaSecuencial.SequentialSearch(sortedArray, target);

        if (Sequentialresult != -1)
        {
            Console.WriteLine($"Secuencial: El elemento {target} se encuentra en la posición {Sequentialresult}.");
        }
        else
        {
            Console.WriteLine($"Secuencial: El elemento {target} no se encontró en el arreglo.");
        }


        int binaryResult = BusquedaBinaria.BinarySearch(sortedArray, target);

        if (binaryResult != -1)
        {
            Console.WriteLine($"Binaria: El elemento {target} se encuentra en la posición {binaryResult}.");
        }
        else
        {
            Console.WriteLine($"Binaria: El elemento {target} no se encontró en el arreglo.");
        }

        //Busquedas Por Transformacion De Claves 

        List<int> data = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        int key = 50;

        int moduleIndex = TransformacionPorModulo.SearchByModuleKey(data, key);

        if (moduleIndex != -1)
        {
            Console.WriteLine($"TransformacionPorModulo: El valor {key} fue encontrado en el índice {moduleIndex}.");
        }
        else
        {
            Console.WriteLine($"TransformacionPorModulo: El valor {key} no fue encontrado en la lista.");
        }

        int cuadraticIndex = TransformacionPorCuadrado.SearchByKeyCuadratic(data, key);

        if (cuadraticIndex != -1)
        {
            Console.WriteLine($"TransformacionPorCuadrado: El valor {key} fue encontrado en el índice {cuadraticIndex}.");
        }
        else
        {
            Console.WriteLine($"TransformacionPorCuadrado: El valor {key} no fue encontrado en la lista.");
        }

        int truncationValue = 10;
        int truncateIndex = TransformacionPorTruncamiento.SearchByTruncatedKey(data, key, truncationValue);

        if (truncateIndex != -1)
        {
            Console.WriteLine($"TransformacionPorTruncamiento: El valor {key} fue encontrado en el índice {truncateIndex}.");
        }
        else
        {
            Console.WriteLine($"TransformacionPorTruncamiento: El valor {key} no fue encontrado en la lista.");
        }

        int foldIndex = TransformacionPorPlegamiento.SearchByFoldedKey(data, key);

        if (truncateIndex != -1)
        {
            Console.WriteLine($"TransformacionPorPlegamiento: El valor {key} fue encontrado en el índice {foldIndex}.");
        }
        else
        {
            Console.WriteLine($"TransformacionPorPlegamiento: El valor {key} no fue encontrado en la lista.");
        }

    }
}