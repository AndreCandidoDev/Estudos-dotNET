Console.WriteLine("struct Tipo DateTime \n");

// pega a data e hora atuais
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// cria data especifica
DateTime dataHoje = new DateTime(2025, 01, 08);
Console.WriteLine(dataHoje);

// cria data com hora
DateTime dataHoraHoje = new DateTime(2025, 01, 08, 14, 26, 00);
Console.WriteLine($"hoje {dataAtual}\n");

// extrai informaçoes de dataAtual
//Console.WriteLine(dataAtual.Year);
//Console.WriteLine(dataAtual.Month);
//Console.WriteLine(dataAtual.Day);
//Console.WriteLine(dataAtual.Hour);
//Console.WriteLine(dataAtual.Minute);
//Console.WriteLine(dataAtual.Second);
//Console.WriteLine(dataAtual.Millisecond);

// adicionando valores
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(2));
Console.WriteLine(dataAtual.AddYears(1));
Console.WriteLine(dataAtual.AddHours(2));

// obter dia da semana e do ano
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

// data no formato curto e longo
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadLine();
