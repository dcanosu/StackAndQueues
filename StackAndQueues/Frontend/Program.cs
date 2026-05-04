using System.ComponentModel.Design;
using Backend;

// // try
// // {
//     var stack = new StackUsingArray<string>(5);
// //     stack.Push("Perro");
// //     stack.Push("Gato");
// //     stack.Push("Pájaro");
// //     stack.Push("Pez");
// //     stack.Push("Conejo");
// //     for (int i = 0; i < 10; i++)
// //     {
// //         Console.WriteLine(stack.Pop());
// //     }
// // }
// // catch (Exception ex)
// // {
    
// //     Console.WriteLine("An error occurred: " + ex.Message);
// // }


//     var option = string.Empty;

//     do
//     {
//         option = Menu();
//         switch (option)
//         {
//             case "1":
//                 Console.Write("Ingrese el elemento a apilar: ");
//                 var element = Console.ReadLine() ?? string.Empty;
//                 stack.Push(element);
//                 Console.WriteLine($"Elemento '{element}' apilado.");
//                 break;
//             case "2":
//                 try
//                 {
//                     var poppedElement = stack.Pop();
//                     Console.WriteLine($"Elemento '{poppedElement}' desapilado.");
//                 }
//                 catch (InvalidOperationException ex)
//                 {
//                     Console.WriteLine("Error: " + ex.Message);
//                 }
//                 break;
//             case "3":
//                 try
//                 {
//                     var topElement = stack.Peek();
//                     Console.WriteLine($"El tope de la pila es: '{topElement}'.");
//                 }
//                 catch (InvalidOperationException ex)
//                 {
//                     Console.WriteLine("Error: " + ex.Message);
//                 }
//                 break;
//             case "0":
//                 Console.WriteLine("Saliendo del programa...");
//                 break;
//             default:
//                 Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
//                 break;
//         }
//     } while (option != "0");

//     string Menu()
//     {
//         Console.WriteLine("Select an option:");
//         Console.WriteLine("1. Apilar");
//         Console.WriteLine("2. Desapilar");
//         Console.WriteLine("3. Ver tope");
//         Console.WriteLine("0. Salir");
//         Console.Write("Digite su opción: ");
//         return Console.ReadLine() ?? string.Empty;
//     }

// try
// {
    var stack = new StackUsingArray<string>(5);
//     stack.Push("Perro");
//     stack.Push("Gato");
//     stack.Push("Pájaro");
//     stack.Push("Pez");
//     stack.Push("Conejo");
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine(stack.Pop());
//     }
// }
// catch (Exception ex)
// {
    
//     Console.WriteLine("An error occurred: " + ex.Message);
// }

// For Queue
    var queue = new QueueUsingArray<string>(5);
    var option = string.Empty;

    do
    {
        option = Menu();
        switch (option)
        {
            case "1":
                try
                {
                    Console.Write("Ingrese el elemento a encolar: ");
                    var element = Console.ReadLine() ?? string.Empty;
                    queue.Enqueue(element);
                    Console.WriteLine($"Elemento '{element}' encolado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            case "2":
                try
                    {
                        var dequeueElement = queue.Dequeue();
                        Console.WriteLine($"Elemento '{dequeueElement}' desencolado.");
                    }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            case "0":
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                break;
        }
    } while (option != "0");

    string Menu()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Encolar");
        Console.WriteLine("2. Desencolar");
    
        Console.WriteLine("0. Salir");
        Console.Write("Digite su opción: ");
        return Console.ReadLine() ?? string.Empty;
    }