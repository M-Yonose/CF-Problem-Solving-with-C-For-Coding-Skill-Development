/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_12_Codeforces_977_A
*/

using System;

class Programme
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);     

        for (int i = 0; i < k; i++)
        {   
            if(n % 10 == 0)
            {
                n = n / 10;
            }
            else
            {
                n = n - 1;
            }
        }
        Console.WriteLine(n);

    }
}