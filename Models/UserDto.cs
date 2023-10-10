namespace AuthenticationWebApi.Models
{
    // dto para registrar e criar um usuario
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
