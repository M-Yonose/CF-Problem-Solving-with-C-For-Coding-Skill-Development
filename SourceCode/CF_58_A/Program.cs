/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_16_Codeforces_58_A
*/

using System;

class Programme
{
    static void Main()
    {
        string word = Console.ReadLine();

        string target = "hello";
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (count < target.Length && word[i] == target[count])
            {
                count++;
            }
        }

        if (count == target.Length)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}