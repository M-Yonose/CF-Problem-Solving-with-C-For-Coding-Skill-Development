/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_10_Codeforces_546_A
*/

using System;

class Programme
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int k = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        int w = int.Parse(input[2]);

        int totalCost = 0;

        for (int i = 1; i <= w; i++)
        {
            totalCost += i * k;
        }

        if (totalCost > n)
        {
            Console.WriteLine(totalCost - n);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}