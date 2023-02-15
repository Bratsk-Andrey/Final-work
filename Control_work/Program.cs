// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

class Project
{
    static void Main()
    {
        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        Console.Clear();
        string[] arrayString = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
        int size = 0;
        Console.WriteLine("Исходный массив: ");
        PrintArray(arrayString);

        for (int i = 0; i < arrayString.Length; i++)
        {
            if (arrayString[i].Count() <= 3) size++;
        }

        string[] array3 = new string[size];
        int k = 0;
        Console.WriteLine();

        for (int j = 0; j < arrayString.Length; j++)
        {
            if (arrayString[j].Count() <= 3) array3[k++] = arrayString[j];
        }

        Console.WriteLine("Новый массив: ");
        PrintArray(array3);
    }
}
