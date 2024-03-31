Console.WriteLine();

Console.WriteLine("Digite o texto que deseja ser soletrado:");

Console.WriteLine();

string txt = Console.ReadLine()!;

Console.WriteLine("\nSoletrando fica:\n");

Console.WriteLine(string.Join("-",txt.ToUpper().ToCharArray()));

Console.WriteLine();
