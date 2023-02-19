int Input(string text)
    {
        Console.Write(text + " ");
        return Convert.ToInt32(Console.ReadLine());
    }
int[] CreateArray(int size)
    {
        return new int[size];
    }
void FillByRandom(int[] array)
    {
        int index = 0;
        while (index < array.Length)
        {
            array[index] = new Random().Next(1, 10);
            index++;
        }
    }
void PrintArray(int[] array)
    {
        int index = 0;
        while (index < array.Length)
        {
            Console.Write(array[index] + " ");
            index++;
        }
        Console.WriteLine();
    }
void CountSameElements(int[] array)
    {
        int indexOutside = 0;
        int number = 0;
        int count = 0;
        int indexInside = 0;
        for (indexOutside = 0; indexOutside < array.Length; indexOutside++)
        {
            number = array[indexOutside];
            for (indexInside = 0; indexInside < array.Length; indexInside++)
            {
                if (array[indexInside] == number)
                    count++;
            }
        
            Console.WriteLine(number + " repit " + count + " times");
            
            indexInside = 0;
            count = 0;
        }
    }

int numbersCount = Input("enter count of numbers: ");
int [] array = CreateArray(numbersCount);
FillByRandom(array);
PrintArray(array);
CountSameElements(array);