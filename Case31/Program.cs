// вариант решения студентов
int[] FillArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    Console.WriteLine($"[{string.Join(", ",array)}]");
    return array;
}

int[]array = new int[12];
FillArray(array);
int positiveSum = 0;
int negativeSum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        positiveSum = positiveSum+array[i];
    }else negativeSum = negativeSum+array[i];
}
Console.WriteLine();
Console.WriteLine($"сумма положительных элементов -> {positiveSum}");
Console.WriteLine($"сумма отрицательных элементов ->{negativeSum}");

// вариант преподавателя

// Double[] array = GetArray(12, -9.0, 9.0);
// Console.WriteLine(String.Join(" ", array));

// Double positiveSum = 0;
// Double negativeSum = 0;

// foreach (Double el in array)
// {
//     positiveSum += el > 0 ? el : 0;
// } 
// //  for (int i = 0;i < array.Length; i++){
// //     int el = array[i];
// //     positiveSum += el > 0 ? el : 0;
// //     negativeSum += el < 0 ? el : 0;
// // } 
// Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

// Double[] GetArray(int size, Double minValue, Double maxValue)
// {
//     Double[] res = new Double[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().NextDouble() * 5.0 - 2.0;
//     }
//     return res;
// }