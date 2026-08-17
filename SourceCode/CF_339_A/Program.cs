/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_05_Codeforces_339A
*/
using System;
class Programme
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] numbers = s.Split('+');

        Array.Sort(numbers);
        Console.WriteLine(string.Join("+", numbers));

    }
}