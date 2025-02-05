using UtasszallitokCLI;

const string PATH = "D:\\PROJECTS\\CSHARP2025020501\\UTASSZALLITOK\\utasszallitok.txt";

List<Utasszallito> utasszallitok = [];
using StreamReader sr = new(PATH);
_ = sr.ReadLine();
while(!sr.EndOfStream) utasszallitok.Add(new(sr.ReadLine()));

Console.WriteLine($"4f: adatsorok szama: {utasszallitok.Count}");