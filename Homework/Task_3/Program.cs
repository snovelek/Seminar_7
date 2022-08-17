// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





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

void SrArif (int [,] arr){
    int sum = 0;
    for (int i=0;i<arr.GetLength(0);i++){
        for (int j=0;j<arr.GetLength(1);j++){
            sum=sum+arr[j,i];
        }
        double sum1;        
        System.Console.Write(Math.Round(Convert.ToDouble(sum)/arr.GetLength(1),2)+"; ");
        sum=0;
        }
}

SrArif(FillMatrix(m,n));