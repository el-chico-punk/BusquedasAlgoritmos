using System;
using System.Collections.Generic;
namespace Busquedas;
public class BusquedaSecuencial
{
    public static int SequentialSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // El elemento se encuentra en la posición i
            }
        }
        return -1; // El elemento no se encontró en el arreglo
    }
}

class BusquedaBinaria
{
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid; // Elemento encontrado, retorna el índice
            else if (array[mid] < target)
                left = mid + 1; // El elemento puede estar a la derecha
            else
                right = mid - 1; // El elemento puede estar a la izquierda
        }

        return -1; // Elemento no encontrado
    }

}

//Busquedas Por Transformacion De Claves 
class TransformacionPorModulo
{

    public static int SearchByModuleKey(List<int> data, int key)
    {
        int modulo = data.Count;
        int startIndex = key % modulo;

        for (int i = startIndex; i < startIndex + modulo; i++)
        {
            int currentIndex = i % modulo;
            if (data[currentIndex] == key)
            {
                return currentIndex;
            }
        }

        return -1;
    }
}

class TransformacionPorCuadrado
{
    public static int SearchByKeyCuadratic(List<int> data, int key)
    {
        int size = data.Count;
        int transformedKey = key * key;
        int index = transformedKey % size;

        if (data[index] == key)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}


class TransformacionPorTruncamiento
{
    static int TruncateKey(int key, int truncationValue)
    {
        return key % truncationValue;
    }

        public static int SearchByTruncatedKey(List<int> data, int targetKey, int truncationValue)
    {
        int truncatedTargetKey = TruncateKey(targetKey, truncationValue);

        foreach (int item in data)
        {
            int truncatedItemKey = TruncateKey(item, truncationValue);
            if (truncatedItemKey == truncatedTargetKey)
                return item;
        }

        return -1; 
    }
}


class TransformacionPorPlegamiento
{
    static int FoldingKey(int key)
    {
        // Sumamos los dígitos del número para hacer el plegamiento
        int sum = 0;
        while (key > 0)
        {
            sum += key % 10;
            key /= 10;
        }
        return sum;
    }

    public static int SearchByFoldedKey(List<int> data, int targetKey)
    {
        int foldedTargetKey = FoldingKey(targetKey);

        foreach (int item in data)
        {
            int foldedItemKey = FoldingKey(item);
            if (foldedItemKey == foldedTargetKey)
                return item;
        }

        return -1;
    }
}

