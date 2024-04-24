using System.ComponentModel.DataAnnotations;

namespace mf_pucminas.Modelo
{
    public class AuthenticateDto
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
