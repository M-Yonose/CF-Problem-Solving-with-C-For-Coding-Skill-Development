/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_13_Codeforces_617_A
*/

using System;

class Programme
{
   static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        int ans = 0;

        if(n % 5 == 0)
        {
            ans = n / 5;
        }
        else
        {
            ans = (n / 5) + 1;
        }

        Console.WriteLine(ans);      

    }
}