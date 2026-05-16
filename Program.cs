using CryptoSoft.Services;

if (args.Length != 2)
{
    Console.Error.WriteLine("Usage: CryptoSoft.exe <sourceFilePath> <destinationFilePath>");
    Environment.Exit(-1);
}

// Ensure only one instance of CryptoSoft runs at a time.
// EasySave detects a running instance by checking this named mutex.
using var mutex = new Mutex(initiallyOwned: true, name: "Global\\EasySave_CryptoSoft", out bool acquired);
if (!acquired)
{
    Console.Error.WriteLine("ERROR: Another CryptoSoft instance is already running.");
    Environment.Exit(-2);
}

string sourcePath = args[0];
string destinationPath = args[1];

CryptoService cryptoService = new();
var result = cryptoService.Encrypt(sourcePath, destinationPath);

if (result.Success)
    Console.WriteLine($"OK | {result.DurationMs} ms");
else
    Console.Error.WriteLine($"ERROR: {result.Message}");

mutex.ReleaseMutex();
Environment.Exit(result.ExitCode);