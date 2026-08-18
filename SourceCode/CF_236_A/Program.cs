/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_08_Codeforces_236_A
*/

using System;

class Programme
{
    static void Main()
    {
        string name = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < name.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (name[i] == name[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                count++;
            }
        }

        if (count % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }
    }
}