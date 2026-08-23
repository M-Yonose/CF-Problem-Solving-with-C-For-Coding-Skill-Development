/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_11_Codeforces_791_A
*/

using System;

class Programme
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int year = 0;

        while (a <= b)
        {
            a = a * 3;
            b = b * 2;

            year++;
        }

        Console.WriteLine(year);
    }
}