Console.WriteLine("String Object e Dynamic");
Console.WriteLine();

// strings sao imutaveis, cada alteração aloca mais um valor na memoria
string nome = "Alguma coisa";
String titulo = "Algo";

Console.WriteLine(nome);
Console.WriteLine(titulo);

dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "coisa";
object ativo = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativo);
Console.WriteLine(letra);

Console.ReadLine();