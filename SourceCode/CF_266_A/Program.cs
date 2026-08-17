/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_06_Codeforces_266_A
*/
using System;
class Programme
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string stones = Console.ReadLine();
        int count = 0;

        for(int i = 0; i < n - 1; i++)
        {
            if (stones[i] == stones[i+1])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}