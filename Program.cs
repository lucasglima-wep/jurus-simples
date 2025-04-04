Console.Clear();
decimal capital, taxa, meses, juros, montante;

Console.WriteLine("juros simples");

Console.Write("capital:(R$):");
capital= Convert.ToDecimal(Console.ReadLine());

Console.Write("taxa:(t):");
taxa= Convert.ToDecimal(Console.ReadLine());

Console.Write("Tempo [t] (meses)......: ");
meses = Convert.ToDecimal(Console.ReadLine());


juros = capital * (taxa / 100) * meses;
montante = capital + juros;


Console.WriteLine($"Juros.....: {juros:C2}");
Console.WriteLine($"Montante..: {montante:C2}");