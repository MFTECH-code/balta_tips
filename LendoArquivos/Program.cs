const string filePath = "D:\\projetos\\files\\text-file.txt";

// File
// var data = File.ReadAllText(filePath);
// Console.WriteLine(data);

// ReadAllText lê o aqruivo inteiro

// var data = File.ReadAllLines(filePath);
// var count = 0;
// foreach (var line in data)
// {
//     count++;
//     Console.WriteLine($"Linha: {count} - {line}");
// }

// ReadAllLines lê linha a linha e guarda em um vetor

// StreamReader -> recomendado para arquivos mais pesados, pois ele não lê tudo de uma só vez
using var file = new StreamReader(filePath);
string? line;
while ((line = file.ReadLine()) != null)
    Console.WriteLine(line);


file.Close();