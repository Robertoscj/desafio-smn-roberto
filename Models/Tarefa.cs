using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dotnet.Models;

namespace dotnet_app_roberto.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Mensagem { get; set; }

        [Required]
        public DateTime DataLimite { get; set; }

        // Chave estrangeira para Usuario
        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; } 

        public string UsuarioEmail { get; set; }

        public bool Concluida { get; set; } = false;

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
