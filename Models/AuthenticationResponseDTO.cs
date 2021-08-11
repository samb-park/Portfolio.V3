using System;

namespace Models
{
    public class AuthenticationResponseDTO
    {
        public bool IsAuthSuccessful { get; set; }
        public String ErrorMessage { get; set; }
        public string Token { get; set; }
        public UserDTO userDTO { get; set; }
    }
}