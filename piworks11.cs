using System;
 
class Program
{
    static void Main(string[] args)
    {
        string input1 = "The weather is so sunny nowadays";
        string input2 = "Life is so beautiful";
 
        string output1 = ReverseWords(input1);
        string output2 = ReverseWords(input2);
 
        Console.WriteLine(output1);
        Console.WriteLine(output2);
    }
 
    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}