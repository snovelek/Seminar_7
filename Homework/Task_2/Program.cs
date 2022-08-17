// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет


System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());


System.Console.Write("Введите первый индекс массива - ");
int mm = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второй индекс массива - ");
int nn = Convert.ToInt32(Console.ReadLine());





int [,] FillMatrix (int mm, int nn){
    int [,]arr= new int [mm,nn];
    for (int i=0;i<mm;i++){
        for (int j=0;j<nn;j++){
            int rez = new Random().Next(1,10);
            arr[i,j]=rez;
            Console.Write($" {rez} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}


void FindNum(int [,] arr1,int mmm,int nnn){
    bool f=false;
    for (int i=0;i<arr1.GetLength(0);i++){
        for (int j=0;j<arr1.GetLength(1);j++){
            if (i==mmm && j==nnn){
                System.Console.WriteLine(arr1[i,j]);
                f=true;
                break;
            }
        }
    }
    if (f==false)
    System.Console.WriteLine("такого числа в массиве нет");
}
FindNum(FillMatrix(m,n),mm,nn);