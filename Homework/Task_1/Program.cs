// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.


// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] FillMatrix (int mm, int nn){
    double [,]arr= new double [mm,nn];
    for (int i=0;i<mm;i++){
        for (int j=0;j<nn;j++){
            arr[i,j]=100.0*new Random().Next()/2147483648-10.0;
            //Console.Write($" {arr[i,j]} ");
            //Console.Write("{0,6:F2}", arr[i,j]);
            //Console.Write(String.Format("{0,5:f1}"));
            Console.Write("    " + Math.Round(arr[i,j],2));
            //System.Console.WriteLine(arr[i,j].GetType());
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

double [,] massssive = FillMatrix(m,n);