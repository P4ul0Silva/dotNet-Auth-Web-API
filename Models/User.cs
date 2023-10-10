namespace AuthenticationWebApi.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        // array de bytes
        public byte[] PasswordHash { get; set; } = new byte[32];

        public byte[] PasswordSalt { get; set; } = new byte[32];
    }
}
