using CryptoSoft.Services;

// Vérifie que l'utilisateur a bien fourni les deux chemins nécessaires :
// 1. le chemin du fichier source
// 2. le chemin du fichier de destination
if (args.Length != 2)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(
        "Usage : CryptoSoft.exe <sourceFilePath> <destinationFilePath>"
    );

    Console.ResetColor();
    
    // Code Erreur : paramètres invalides
    Environment.Exit(-1);
}

// Récupère les chemins du fichier source et du fichier de destination à partir des arguments de la ligne de commande
string sourcePath = args[0];
string destinationPath = args[1];

// Affichage des informations sur les chemins fournis par l'utilisateur
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("===== CryptoSoft =====");
Console.WriteLine($"Source      : {sourcePath}");
Console.WriteLine($"Destination : {destinationPath}");

Console.ResetColor();

// Création d'une instance de CryptoService pour effectuer l'opération de chiffrement
CryptoService cryptoService = new();

var result = cryptoService.Encrypt(sourcePath, destinationPath);

// Affichage du résultat selon le succès ou l'échec de l'opération
if (result.Success)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine(result.Message);
    Console.WriteLine($"Duration : {result.DurationMs} ms");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Encryption failed");
    Console.WriteLine(result.Message);
}

Console.ResetColor();

// Retourne le code de sortie au système.
// EasySave pourra ensuite lire ce code pour savoir si CryptoSoft a réussi ou échoué.
Environment.Exit(result.ExitCode);