namespace Core.Security.JWT
{
    public class RefreshTokenDto
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

        public RefreshTokenDto()
        {
            Token = string.Empty;
        }

        public RefreshTokenDto(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }
    }
}
