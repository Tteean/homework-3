




#region Task1
//using System.Runtime.CompilerServices;

//int n = 4;
//int m = 15;


//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }

//}
#endregion
#region Task2

//int n = 4;
//int m = 16;
//int sum = 0;


//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum +=i;
//    }
//}
//Console.WriteLine(sum); 

#endregion
#region Task3

//int m = 8;
//int res = 1; 

//for (int i = 1; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        res *= i;
//    }
//}
//Console.WriteLine(res);

#endregion
#region Task4


//int a = 8;


//    if ( a % 2 == 0 && a % 3 == 0)
//    {
//        Console.WriteLine("3-e bolunur cutdur");
//    }
//    else if ( a % 2 == 1 && a % 3 == 0) 
//    {
//        Console.WriteLine("3-e bolunur tekdir");
//    }
//    else
//{
//    Console.WriteLine("3-e bolunmur");
//}
#endregion
#region Task5

int n = 7;
int res = 0;

for (int i = 2; i < n; i++)
{
    if (n % i == 0)
    {
        res++;
    }
    else
    {
        res += 0;
    }
    if (res > 0)
    {
        Console.WriteLine("murekkeb");
    }
    else
    {
        Console.WriteLine("sade");
    }

}

#endregion
