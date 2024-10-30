// AND (&&) and OR ( ||) logical opererator

//OR 
// true || true ==> true
// true || false ==> true
// false || true ==> true
// false || false ==> false

string username, password; // username: admin ; password admin: admin1234

Console.WriteLine("Enter username: ");
username = Console.ReadLine();

Console.WriteLine("Enter password: ");
password = Console.ReadLine();

if (username != "admin" || password != "admin1234")// != NOT
{
    Console.WriteLine("Invalid user credential");
}
else
{
    Console.WriteLine("Welcome!");
}
