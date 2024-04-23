using System.ComponentModel.DataAnnotations.Schema;

namespace mf_pucminas.Modelo
{
    [Table("VeiculoUsuarios")]
    public class VeiculoUsuarios
    {
        public int Veiculoid { get; set; }
        public Veiculo Veiculo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
