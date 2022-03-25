double numero1, numero2, numero3, media;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Média Aritmética de 3 números\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("digite seu primeiro numero: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("digite seu segundo numero.: ");
numero2 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("digite seu terceiro numero: ");
numero3 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

media= (numero1 + numero2 + numero3) / 3; 

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nMédia: {media:N1}");
Console.ResetColor();
