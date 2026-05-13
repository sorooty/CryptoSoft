namespace CryptoSoft.Utils;

public static class FileHelper
{
    /// <summary>
    /// FileExists est une méthode qui prend en entrée un chemin de fichier et vérifie si le fichier existe à ce chemin. Elle retourne true si le fichier existe, sinon false.
    /// </summary>
    /// <param name="path">Le chemin du fichier à vérifier</param>
    /// <returns>true si le fichier existe, sinon false</returns>
    public static bool FileExists(string path)
    {
        return File.Exists(path);

    }

    /// <summary>
    /// EnsureDirectory est une méthode qui prend en entrée un chemin de fichier et vérifie si le répertoire de ce fichier existe. Si le répertoire n'existe pas, il est créé.
    /// </summary>
    /// <param name="path">Le chemin du fichier pour lequel s'assurer de l'existence du répertoire</param>
    public static void EnsureDirectory(string path)
    {
        string? directory = Path.GetDirectoryName(path);

        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
    }
}