using System.Threading.Channels;

const string filePath = @"D:\projetos\files\my-file.txt";

//File.Encrypt(); // Windows only
// Criando um arquivo
//File.Create(filePath);
// Escrevendo em arquivos
// Escreve no final do arquivo
// using var file = File.AppendText(filePath);
// file.WriteLine("Olá mundo");
// file.Close();

// Subistitui o que já estava escrito no arquivo
// using var file = File.CreateText(filePath);
// file.WriteLine("Outra forma de se escrever");
// file.Close();

// Criando uma cópia do arquivo
// File.Copy(filePath, @"D:\projetos\files\outro.txt");
// var file = File.ReadAllText(@"D:\projetos\files\outro.txt");
// Console.WriteLine(file);

// Movendo um arquivo
// File.Move(filePath, @"D:\projetos\files\temp\novo.txt");

// Subistituindo arquivo
//File.Replace(@"D:\projetos\files\outro.txt", filePath, @"D:\projetos\files\beckup.txt");

// Excluindo arquivos
//File.Delete(@"D:\projetos\files\beckup.txt");

var result = File.Exists(filePath);
Console.WriteLine(result);

var time = File.GetLastAccessTime(filePath);
Console.WriteLine(time);

var attrs = File.GetAttributes(filePath);

if ((attrs & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) Console.WriteLine("ReadOnly");
if ((attrs & FileAttributes.Compressed) == FileAttributes.Compressed) Console.WriteLine("Compressed");