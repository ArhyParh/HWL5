// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Main();
void Main()
{
    Console.WriteLine("Введите количество чисел, которые планируете ввести");
    int size = int.Parse(Console.ReadLine()!);
    int[] need = GetArray(size);
    Console.WriteLine(String.Join(", ", need));
    int result = NumberResult(need);
    Console.WriteLine("Количество чисел больше 0 = "+result);
}
int[] GetArray(int size)
{
    int i = 0;
    int[] back = new int[size];
    while (i < size)
    {
        back[i] = int.Parse(Console.ReadLine()!);
        i++;
    }
    return back;
}
int NumberResult(int[] array)
{
    int n = 0;
foreach(int i in array){
    if( i>0){
        n++;
    }
}
return n;
}