using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {

            UniverslaArray<int> arr1 = new UniverslaArray<int>(1, 2, 3, 4, 5);

            Console.WriteLine("Количество элементов в массиве: " + arr1.getLength());
            Console.WriteLine("Элемент с индексом 3: " + arr1.getElement(3));
            Console.WriteLine(arr1.remove(3));
            Console.WriteLine(arr1.add(3, 10));
            Console.WriteLine("Элемент с индексом 3: " + arr1.getElement(3));
            Console.WriteLine(arr1.remove());
            Console.WriteLine(arr1.add(9, 8, 7, 6, 5, 4));
            Console.WriteLine("Элемент с индексом 3: " + arr1.getElement(3));
            Console.WriteLine("Количество элементов в массиве: " + arr1.getLength());
            Console.WriteLine("-----------------------------------------");

            UniverslaArray<string> arr2 = new UniverslaArray<string>(3);
            Console.WriteLine("Количество элементов в массиве: " + arr2.getLength());
            Console.WriteLine(arr2.add("Hello"));
            Console.WriteLine(arr2.add("world"));
            Console.WriteLine(arr2.add("!!!"));
            Console.Write(arr2.getElement(0) + " ");
            Console.Write(arr2.getElement(1));
            Console.WriteLine(arr2.getElement(2));
            Console.WriteLine(arr2.remove(1));
            Console.Write(arr2.getElement(0));
            Console.Write(arr2.getElement(2));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");

            UniverslaArray<double> arr3 = new UniverslaArray<double>(2.22, 3.33, 4.44, 5.55, 6.66);
            Console.WriteLine("Элемент с индексом 3: " + arr3.getElement(3));
            Console.WriteLine(arr3.remove(3));
            Console.WriteLine(arr3.add(3, 10.10));
            Console.WriteLine("Элемент с индексом 3: " + arr3.getElement(3));
            Console.WriteLine(arr3.remove());
            Console.WriteLine(arr3.add(9.99, 8.88, 7.77, 6.66, 5.55, 4.44));
            Console.WriteLine("Элемент с индексом 3: " + arr3.getElement(3));
            Console.WriteLine("Количество элементов в массиве: " + arr3.getLength());

        }
        class UniverslaArray<Arr>
        {
            Arr[] array;
            public UniverslaArray(params Arr[] array)
            {
                this.array = array;
            }
            public UniverslaArray(int size)
            {
                array = new Arr[size];
            }
            public string add(Arr addElement)
            {
                for (int i = 0; i < array.Length; i++) {
                    if (array[i] == null)
                    {
                        array[i] = addElement;
                        return "Элемент успешно добавлен";
                    }
                }
                return "В массиве нет места";
            }
            public string add(int index, Arr addElement)
            {
                
                    if (array[index] != null)
                    {
                        array[index] = addElement;
                        return "Элемент успешно добавлен";
                    }
                
                return "Такой позиции в массиве несуществует";
            }
            public string add(params Arr[] addElements)
            {

                array = addElements;

                return "Массив успешно добавлен";
            }
            public string remove(int index)
            {
                if (array[index] != null)
                {
                    array[index] = default;
                    return "Элемент успешно удалён";
                }
                return "Такого элемента не существует";
            }
            public string remove()
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = default;
                }
                return "Массив успешно очищен";
            }
            public Arr getElement(int index)
            {
                if (array[index] != null)
                {
                    return array[index];
                }
                return default;
            }
            public int getLength()
            {
                return array.Length;
            }
            
              
        }
    }
}
