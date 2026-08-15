/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_03_Codeforces_263A
*/

using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Split();

            for (int j = 0; j < 5; j++)
            {
                int x = int.Parse(input[j]);

                if (x == 1)
                {
                    Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
                    return;
                }
            }
        }
    }
}