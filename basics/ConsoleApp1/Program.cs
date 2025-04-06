// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
//Returns boolans 
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

/*Challenge

There are two similar methods, StartsWith and EndsWith that also search for substrings in a string. 
These methods find a substring at the beginning or the end of the string. 
Try to modify the previous sample to use StartsWith and EndsWith instead of Contains.
 Search for "You" or "goodbye" at the beginning of a string. Search for "hello" or "goodbye" at the end of a string.*/

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());


//Returns boolans 
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.StartsWith("You"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));