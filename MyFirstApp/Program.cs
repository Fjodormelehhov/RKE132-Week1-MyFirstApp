//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name: ");// output
//stringe - sõne
string username;

username = Console.ReadLine();// input

Console.WriteLine("Hello" + ", " + username + "!");// output

// string interpolation
Console.WriteLine($"Hello, {username}!"); // output