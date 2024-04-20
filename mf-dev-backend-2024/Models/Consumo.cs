using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models;

public enum TipoCombustivel
{
    Gasolina,
    Etanol
}

[Table(("Consumos"))]
public class Consumo
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatório.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Obrigatório.")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "Obrigatório.")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "Obrigatório.")]
    public int Km { get; set; }

    [Display(Name = "Tipo de Combustível")]
    public TipoCombustivel Tipo { get; set; }

    [Required(ErrorMessage = "Obrigatório.")]
    public int VeiculoId { get; set; }
    
    [ForeignKey("VeiculoId")]
    public Veiculo Veiculo { get; set; }
}