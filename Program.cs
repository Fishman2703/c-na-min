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

while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine();
index = 1;
// Искл. элементов нарушения возрастания
int currentElement = A[0];
Console.WriteLine(currentElement);
while(index<10)
{
    if(A[index]>currentElement)
    {
    Console.WriteLine(A[index]);
    currentElement = A[index];
    }
    index++;
} 

Console.WriteLine();
index = 0;
// Искл те, которые больше сред ариф массива А
int summ = 0;


