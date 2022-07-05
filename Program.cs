using System.Collections;
using System.Text.RegularExpressions;
bool validWord = false;
string newWord = "";
Console.WriteLine("Enter a word");

//making sure we can use the info 
// i don't love this yet, because when I only accept letters with regex, it kicks back any
// spaces entered too 


while (!validWord)
{
    try
    {
        newWord = Console.ReadLine();

        if (!Regex.IsMatch(newWord, "^[a-zA-Z]+$"))
        {
            throw new Exception("Please, no numbers/symbols");
        }
        else
        {
            validWord = true;
        }
    }

    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Enter a new word");
        
    }

}

Console.WriteLine(Reverse(newWord));


static String Reverse(String str)
{
    char[] charArr = str.ToCharArray();
    int size = charArr.Length;
    Stack stack = new Stack(size);

    int i;
    for (i = 0; i < size; ++i)
    {
        stack.Push(charArr[i]);
    }

    for (i = 0; i < size; ++i)
    {
        charArr[i] = (char)stack.Pop();
    }

    return String.Join("", charArr);
}



