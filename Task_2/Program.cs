// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());
//int [,] mas = new int [m,n];

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

void CorrectMatrix(int [,]arr1,int mmm, int nnn){
    for (int i=0;i<mmm;i++){
        for (int j=0;j<nnn;j++){
            if (i%2==0 && j%2==0){
            //if (i!=0 &&j !=0){
                arr1[i,j]=arr1[i,j]*arr1[i,j];
                            
            }
            Console.Write($" {arr1[i,j]} ");
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine();
CorrectMatrix(FillMatrix(m,n),m,n);

