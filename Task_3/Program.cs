// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Попробуйте найти сумму элементов главной диагонали в одном цикле

System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

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

void DiagSumm(int [,] arr){
    int summa=0;
    for (int i=0;i<arr.GetLength(0);i++){
        for (int j=0;j<arr.GetLength(1);j++){
            if (i==j){
                summa=summa+arr[i,j];
            }
        }
    }
    System.Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {summa}");            
}

DiagSumm(FillMatrix(m,n));
