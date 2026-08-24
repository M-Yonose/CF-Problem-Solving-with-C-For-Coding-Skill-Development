/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_15_Codeforces_116_A
*/

using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int current = 0;
        int max = 0;

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            int exit = int.Parse(input[0]);
            int enter = int.Parse(input[1]);

            current = current - exit + enter;

            if(current > max)
            {
                max = current;
            }
        }
        Console.WriteLine(max);
    }
}