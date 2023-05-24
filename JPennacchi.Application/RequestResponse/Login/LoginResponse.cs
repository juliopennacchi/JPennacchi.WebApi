using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.RequestResponse.Login
{
    public class LoginResponse
    {
        public bool Autenticado { get; set; }
        public string Token { get; set; }
        public Usuario Usuario { get; set; }
    }
}
