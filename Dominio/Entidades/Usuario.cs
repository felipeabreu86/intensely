using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public partial class Usuario
    {
        public int      Id              { get; set; }
        public string   Email           { get; set; }
        public string   Senha           { get; set; }
        public string   Nome            { get; set; }
        public bool     IsAdmin         { get; set; }
        public DateTime UltimoAcesso    { get; set; }
    }

    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario
    {
        public override bool Equals(object obj)
        {
            Usuario user = obj as Usuario;
            if (user == null) return false;
            return (Email.Equals(user.Email));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class UsuarioMetadado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o e-mail")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        public DateTime UltimoAcesso { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}