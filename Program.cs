using CryptoSoft.Services;

if (args.Length != 2)
{
    Console.Error.WriteLine("Usage: CryptoSoft.exe <sourceFilePath> <destinationFilePath>");
    Environment.Exit(-1);
}

string sourcePath = args[0];
string destinationPath = args[1];

CryptoService cryptoService = new();
var result = cryptoService.Encrypt(sourcePath, destinationPath);

if (result.Success)
    Console.WriteLine($"OK | {result.DurationMs} ms");
else
    Console.Error.WriteLine($"ERROR: {result.Message}");

Environment.Exit(result.ExitCode);