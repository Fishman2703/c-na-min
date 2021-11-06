// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// Задать массив

int[] A = new int[10];

int index = 0;

while (index < 10)
{
    A[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
Console.WriteLine("Массив А");

while (index < 10)
{
    Console.Write(A[index] + " ");
    index++;
}

Console.WriteLine();
index = 1;
// Искл. элементов нарушения возрастания
int currentElement = A[0];
Console.WriteLine("нарушители");
Console.Write(currentElement + " ");
while(index<10)
{
    if(A[index]>currentElement)
    {
    Console.Write(A[index] + " ");
    currentElement = A[index];
    }
    index++;
} 
Console.WriteLine( );
index = 0;
// Искл те, которые больше сред ариф массива А

int temp = 0;
while (index<10)
{
      temp = A[index] + temp;
      index++;
}
int midA = temp / 10;
Console.WriteLine($"среднее арифметическое А = {midA}");
// Искл.
index = 0;
int currentMidA = midA;
while(index<10)
{
    if(A[index]>currentMidA)
    {
        Console.Write(A[index]+" ");
        currentMidA = A[index];
    }
    index++;
}
//четные
Console.WriteLine();
index = 0;
Console.WriteLine($"четные числа массива А ");
while(index<10)
{
    if(A[index] % 2 ==0)
    {
        Console.Write (A[index] +" ");
    }
    index++;
}
Console.WriteLine(); 

// Вот как сделать массив B из массива A, я не понял((((
