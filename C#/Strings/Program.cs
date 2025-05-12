// See https://aka.ms/new-console-template for more information
/*Findings
1. Comments type and Semicolon same as C 
2. '' cannot be used instead of ""
3. Not pointer type like Python, once a variable declared it cannot be reasigned
*/
string aFriend = "Bill"; 
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);


//4. $ instead of f in Python
Console.WriteLine($"Hello {aFriend}");


// 5. Length property to measure the no of characters in a string
Console.WriteLine("No of characters: " + aFriend.Length);


// 6. Trim property is used to handle the spaces
string greeting = " Hello World! ";
Console.WriteLine($"[{greeting}]"); 

string trimmedGreeting = greeting.TrimStart(); 
Console.WriteLine($"[{trimmedGreeting}]"); 

trimmedGreeting = greeting.TrimEnd(); 
Console.WriteLine($"[{trimmedGreeting}]"); 

trimmedGreeting = greeting.Trim(); 
Console.WriteLine($"[{trimmedGreeting}]");


// 7. Replace property
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);


// 8. Upper and Lower 
Console.WriteLine(sayHello.ToUpper()); 
Console.WriteLine(sayHello.ToLower());


// 9. Contains property returns True or False
string songLyrics = "You say goodbye, and I say hello"; 
Console.WriteLine(songLyrics.Contains("goodbye")); 
Console.WriteLine(songLyrics.Contains("greetings"));


// 10. StartsWith and EndsWith properties returns True or False
Console.WriteLine(songLyrics.StartsWith("You")); 
Console.WriteLine(songLyrics.EndsWith("greetings"));