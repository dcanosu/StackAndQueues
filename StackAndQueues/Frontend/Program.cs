using Backend;

try
{
    var stack = new StackUsingArray<string>(5);
    stack.Push("Perro");
    stack.Push("Gato");
    stack.Push("Pájaro");
    stack.Push("Pez");
    stack.Push("Conejo");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(stack.Pop());
    }
}
catch (Exception ex)
{
    
    Console.WriteLine("An error occurred: " + ex.Message);
}