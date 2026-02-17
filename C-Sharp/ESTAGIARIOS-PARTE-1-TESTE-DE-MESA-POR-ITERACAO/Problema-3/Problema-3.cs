using System;
class Programa
{
    static void Main()
    {
        int a, b;

        a = 7;
        b = a - 6;

        int[] vetor = new int[6];

        while (b < a)
        {
            vetor[b] = b + a; 
            b = b + 2;


        }
    }
}