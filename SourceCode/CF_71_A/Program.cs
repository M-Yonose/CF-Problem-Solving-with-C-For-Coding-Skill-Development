/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
task_1_Codeforces_71A*/
using System;
class Programme
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] results = new string[n];
        for (int i = 0; i < n; i++)
        {
            string words = Console.ReadLine();
            if (words.Length > 10)
            {
                results[i] = words[0] + (words.Length - 2).ToString() + words[words.Length - 1];
            }
            else
                results[i] = words;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(results[i]);
        }

    }
}