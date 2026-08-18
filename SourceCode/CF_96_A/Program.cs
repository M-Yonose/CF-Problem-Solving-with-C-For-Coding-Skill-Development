/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_09_Codeforces_96_A
*/

using System;

class Programme
{
    static void Main()
    {
        string players = Console.ReadLine();

        int count = 1;

        for (int i = 1; i < players.Length; i++)
        {
            if (players[i] == players[i - 1])
            {
                count++;

                if (count >= 7)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            else
            {
                count = 1;
            }
        }

        Console.WriteLine("NO");
    }
}