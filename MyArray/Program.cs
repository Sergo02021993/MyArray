// Строка текста.
Console.WriteLine("Введите необходимые данные для создания массива: ");

// Ввод необходимых данных для построения массива.
int InputInt(string message) 
{
    System.Console.Write($"{message} "); 
    int value;  
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if(isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Необходимо ввести число!Попробуйте снова.");
    Environment.Exit(1);
    return 0;
}
int length = InputInt (">Длина массива: ");
int minValue = InputInt (">Минимальное значение: ");
int maxValue = InputInt (">Максимальное значение: ");

// Массив.
System.Console.Write("Ваш массив: [");
int [] array = new int [length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(minValue,maxValue + 1);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine("]");

// Функция нахождения суммы положительных и суммы отрицательных значений.
int sumSign (int[]array, bool isPositive = true)
{
//Знак проверки числа(+/-);
    int sign = 1;  
    if (!isPositive)
    {
        sign = -1;
    }

//Накапливаем сумму в значение "sum";
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] * sign > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
System.Console.WriteLine($"-Сумма положительных элементов массива: {sumSign(array, true)}.");
System.Console.WriteLine($"-Сумма отрицательных элементов массива: {sumSign(array, false)}.");

int digitsPositive(int[]array)
{
    int countPosDigits = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        countPosDigits++;
    }
    return countPosDigits;
}
System.Console.WriteLine($"-Колличество положительных чисел в массиве: {digitsPositive(array)}.");
int digitsNegativ(int[]array)
{
    int countNegDigits = 0;
    for (int i = length - 1; i >= 0 ; i--)
    {
        if (array[i] < 0)
        countNegDigits++;        
    }
    return countNegDigits;
}
System.Console.WriteLine($"-Колличество отрицательных чисел в массиве: {digitsNegativ(array)}.");

// // !!!НЕРАБОТАЕТ!!! Функция меняет знак на противоположный.
// int[] InvertArray(int[]array)
// {
//     for (int i = 0; i < length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }
// System.Console.WriteLine ($"!!!НЕРАБОТАЕТ!!! Массив противоположный по значению: {InvertArray(array)}");

// Функция поиска многозначных чисел чисел:
int searchTwoDigits(int[]array)
{
    int countDigits = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 9 && array[i] < 100 || array[i] < -9 && array[i] > -100)
        countDigits++;
    }
    return countDigits;
}
System.Console.WriteLine($"-Колличество двузначных чисел в массиве: {searchTwoDigits(array)}.");

// Функция поиска четных чисел.
int SearchChetDigits(int[]array)
{
    int countDigits = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i] %2 == 0) countDigits++;
    }
    return countDigits;
}
System.Console.WriteLine($"-Количество четных чисел массиве: {SearchChetDigits(array)}");

// Функция поиска разницы между максимальным и минимальным элементом массиваю
int searchMax = array[0]; int searchMin = array[0];
for(int i = 1; i < array.Length; i++)
{
    if (array[i] >= searchMax ) searchMax = array[i];    
    if (array[i] <= searchMin ) searchMin = array[i];  
}
System.Console.WriteLine($"-Разница между максимальным элементом {searchMax} и минимальным элементом {searchMin} массива = {searchMax - searchMin}");
