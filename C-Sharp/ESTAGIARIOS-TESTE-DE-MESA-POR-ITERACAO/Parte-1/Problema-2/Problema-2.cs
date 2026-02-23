using System;

class Programa
{
    static void Main()
    {
        int a;

        a = 2;
        int[] vetor = new int[6];

        while (a < 6)
        {
            vetor[a] = 10 * a;

            a += 1;
            
        }
    }
}
