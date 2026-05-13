namespace CryptoSoft.Models;
public class CryptoResult
{
    public bool Success { get; set; }

    public long DurationMs { get; set; }

    public int ExitCode { get; set; }

    public string Message { get; set; } = string.Empty;
}