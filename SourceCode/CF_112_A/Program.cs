/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
task_04_Codeforces_112_A
*/
using System;
class Programme
{
    static void Main()
    {
        string a = Console.ReadLine().ToUpper();
        string b = Console.ReadLine().ToUpper();

        int result = string.Compare(a, b);

        if (result > 0)
        {
            Console.WriteLine("1");
        }
        else if(result <0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}