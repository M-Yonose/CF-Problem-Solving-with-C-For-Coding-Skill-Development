/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
task_02_Codeforces_282A*/
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;
        string s;
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            if (s == "X++" || s == "++X")
            {
                x++;
            }
            else if (s == "X--" || s == "--X")
            {
                x--;
            }
        }
        Console.WriteLine(x);

    }
}