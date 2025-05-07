static bool IsPalindrome(string x, int start, int end)
{
    if (start >= end)
    {
        return true;
    }
    else if (x[start] != x[end])
    {
        return false;
    }
    return IsPalindrome(x, start+1, end-1);
}

Console.Write("Please enter word to determine if it is a palindrome: ");
string x=Console.ReadLine().ToLower();
bool result = IsPalindrome(x,0, x.Length-1);

if (result)
{
    Console.WriteLine($"{x} is a palindrome");
}
else
{
    Console.WriteLine($"{x} is not a palindrome");
}

Console.ReadKey();