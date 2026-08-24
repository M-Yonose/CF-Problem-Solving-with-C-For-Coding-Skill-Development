/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
Task_14_Codeforces_59_A
*/

using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();

        int upper = 0;
        int lower = 0;

        for( int i = 0; i < word.Length; i++ )
        {
            if (char.IsUpper(word[i]))
            {
                upper++;
            }
            else
            {
                lower++;
            }
        }
        if(upper > lower)
        {
            Console.WriteLine(word.ToUpper());
        }
        else
        {
            Console.WriteLine(word.ToLower());
        }
    }
}