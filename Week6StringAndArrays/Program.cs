string hello = "we are the champions! ";
int stringLenght = hello.Length;
hello = hello.Trim();

char firstletter = hello[0];
Console.WriteLine(firstletter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter = hello[0];
Console.WriteLine(firstletter);

Console.WriteLine(hello);

//int wordcounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordcounter++;
//    }
//    }
//Console.WriteLine($"word count in {hello}: {wordcounter} words.");