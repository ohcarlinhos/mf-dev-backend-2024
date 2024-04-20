
using System.ComponentModel.DataAnnotations;

namespace mf_dev_backend_2024.Models;

public enum Perfil
{
    Admin,
    User
}

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "Obrigatório")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }
    
    [Required(ErrorMessage = "Obrigatório")]
    public Perfil Perfil { get; set; }
}