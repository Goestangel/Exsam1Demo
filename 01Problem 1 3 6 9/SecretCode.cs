using System;

class Program
{
static void Main()
  {
    int A = int.Parse(Console.ReadLine());
    int B = int.Parse(Console.ReadLine());
    int C = int.Parse(Console.ReadLine());
    int R = 0;

    switch (B)
    {   
        case 3: R = A + C; break;
        case 6: R = A * C; break;
        case 9: R = A % C; break;            
    }
    int Result = R % 3 == 0 ? R / 3 : R % 3;
    Console.WriteLine(Result);
    Console.WriteLine(R);
  }
}

