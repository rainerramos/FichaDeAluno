using System.ComponentModel.DataAnnotations;

namespace ARF.Domain
{
    public class Ficha
    {
        public Ficha()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
           
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Minímo de 3 caracteres")]
        [MaxLength(150, ErrorMessage = "Limite de 150 caracteres")]
        public string Nome { get; set; } 

        public string Supino { get; set; }

        public string Clean { get; set; }

        public string ShoulderPress { get; set; }

        public string Snatch { get; set; }

    }
}
