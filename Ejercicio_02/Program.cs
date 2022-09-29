//#define FRASE
Console.WriteLine("Introduce una frase:");
string frase1 = Console.ReadLine();
Console.WriteLine("Introduce otra frase:");
string frase2 = Console.ReadLine();

#if FRASE
Console.WriteLine("\"{0}\"\t \\{1}\\ ", frase1, frase2);
#else
Console.WriteLine("\n{0}\t{1}\n{0}\n{1}", frase1,frase2);
#endif