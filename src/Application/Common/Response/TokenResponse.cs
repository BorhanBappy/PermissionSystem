namespace Common.Response;

public class TokenResponse
{
    public string  Token { get; set; }
    public string RefreshToken { get; set; }
    public string RefreshTokenExpiryTime { get; set; }
}