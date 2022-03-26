double milha;

Console.Write("Entre com a milha: ");
milha = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"{milha * 1.609:N2}");