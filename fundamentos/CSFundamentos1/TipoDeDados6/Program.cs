Console.WriteLine("Nullable Types \n");

// declaraçao completa de Nullable
//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

// declaraçao simplificada
//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

// forma de atribuir variavel nula a uma nao nula
//int? a = null;
//int b = a ?? 0;
//Console.WriteLine(b);

// p/ expressoes todas devem ter ? caso algum valor seja nullable
//int? x = 2;
//int? y = 2;
//int? z = x * y;
//Console.WriteLine(z);

// exemplo de hasValue e value
int? b = 2;
if (b.HasValue)
{
    Console.WriteLine($"b={b.Value}");
}
else
{
    Console.WriteLine("Eh null");
}

Console.ReadLine();