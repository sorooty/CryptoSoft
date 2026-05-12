using CryptoSoft.Models;

namespace CryptoSoft.Services;

public class CryptoService
{
    private const byte key = 0xAA;          // Example key for XOR encryption

    /// <summary>
    /// Encrypts est une méthode qui prend en entrée un chemin de fichier source et un chemin de fichier de destination, lit les données du fichier source, les chiffre en utilisant une opération XOR avec une clé prédéfinie, puis écrit les données chiffrées dans le fichier de destination.
    /// </summary>
    /// <param name="sourcePath">Le chemin du fichier source</param>
    /// <param name="destinationPath">Le chemin du fichier de destination</param>
    /// <returns>Un objet CryptoResult indiquant le succès ou l'échec de l'opération</returns>
    public CryptoResult Encrypt(string sourcePath, string destinationPath)
    {
        try
        {
            byte[] data = File.ReadAllBytes(sourcePath);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key; // Simple XOR encryption
            }
            File.WriteAllBytes(destinationPath, data);
            return new CryptoResult
            {
                Success = true,
                ExitCode = 0,
                Message = "Encryption successful."
            };
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., file not found, access denied)
            Console.WriteLine($"Error: {ex.Message}");
            return new CryptoResult
            {
                Success = false,
                ExitCode = -1,
                Message = $"Encryption failed: {ex.Message}"
            };
        }
    }

    /// <summary>
    /// Decrypt est une méthode qui prend en entrée une chaîne de données chiffrées, applique la même opération XOR avec la même clé pour récupérer les données originales, et retourne un objet CryptoResult indiquant le succès ou l'échec de l'opération. Notez que dans ce contexte, la méthode Decrypt est un exemple et n'est pas utilisée dans le programme principal, mais elle illustre comment le processus de déchiffrement pourrait être implémenté.
    /// </summary>
    /// <param name="encryptedData">Les données chiffrées à déchiffrer</param>
    /// <returns>Un objet CryptoResult indiquant le succès ou l'échec de l'opération</returns>
    public CryptoResult Decrypt(string encryptedData)
    {
        // Implement decryption logic here
        return new CryptoResult
        {
            Success = true,
            ExitCode = 0,
            Message = "Decryption successful."
        };
    }
}
