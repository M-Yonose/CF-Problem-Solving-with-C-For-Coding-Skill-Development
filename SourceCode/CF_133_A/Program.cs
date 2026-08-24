/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_17_Codeforces_133_A
*/

using System;

class Programme
{
    static void Main()
    {
        string s = Console.ReadLine();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'H' || s[i] == 'Q' || s[i] == '9')
            {
                Console.WriteLine("YES");
                return;
            }
        }        

        Console.WriteLine("NO");
    }
}