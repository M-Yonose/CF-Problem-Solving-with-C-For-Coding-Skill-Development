/*Bismillahir Rahmanir Rahim
Mohammed Yonose
100 CF Problems For Coding Skill Development
task_05_Codeforces_118_A
*/

using System;
class Programme
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        for ( int i= 0; i< input.Length; i++ )
        {
            char ch = input[i];
            if ( ch == 'a' || ch == 'o' || ch == 'y' || ch == 'e' || ch == 'i' || ch == 'u' )
            {

            }
            else
            {
                Console.Write("." + ch);
            }
        }
    }
}