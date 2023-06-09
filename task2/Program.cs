﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Main();
void Main()
{
    Console.WriteLine("Для того, чтобы найти точку пересечения 2 прямых, необходимо ввести параметры коэффициентов: b и k.");
    Console.WriteLine("Введите их по очереди: сперва b и k  первой прямой, а затем второй...");
    double [] first = GetArray();
    double [] second = GetArray();
    Console.WriteLine(String.Join(", ",first));
    Console.WriteLine(String.Join(", ",second));
    double [] result = DoTheLineIntersect(first,second);
    Console.WriteLine(String.Join("|",result));
}
double[] GetArray()
{
    int i = 2;
    double[] back = new double[2];
    while(i!=0){
    back[i-1]= int.Parse(Console.ReadLine()!);
    i--;
    }
    return back;
}
double [] DoTheLineIntersect(double[] a1, double [] a2)
{
    double x = (a2[1]-a1[1])/(a1[0]-a2[0]);
    double y = (a1[0]*x +a1[1]);
    double [] back = new double[]{x,y};
    return back;
}
