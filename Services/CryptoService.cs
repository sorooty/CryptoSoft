using System.Diagnostics;
using CryptoSoft.Models;

namespace CryptoSoft.Services;

public class CryptoService
{
    private const byte Key = 0xAA;

    /// <summary>
    /// XOR-encrypts (or decrypts — same operation) <paramref name="sourcePath"/> into
    /// <paramref name="destinationPath"/> and returns the elapsed time in milliseconds.
    /// </summary>
    public CryptoResult Encrypt(string sourcePath, string destinationPath)
    {
        try
        {
            var sw = Stopwatch.StartNew();

            byte[] data = File.ReadAllBytes(sourcePath);
            for (int i = 0; i < data.Length; i++)
                data[i] ^= Key;

            File.WriteAllBytes(destinationPath, data);
            sw.Stop();

            return new CryptoResult
            {
                Success = true,
                ExitCode = 0,
                DurationMs = sw.ElapsedMilliseconds,
                Message = "Encryption successful."
            };
        }
        catch (Exception ex)
        {
            return new CryptoResult
            {
                Success = false,
                ExitCode = -1,
                DurationMs = 0,
                Message = $"Encryption failed: {ex.Message}"
            };
        }
    }
}
