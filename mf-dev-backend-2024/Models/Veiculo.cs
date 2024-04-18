﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public int AnoModelo { get; set; }
    }
}