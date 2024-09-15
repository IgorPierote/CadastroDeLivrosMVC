using System.ComponentModel.DataAnnotations;

namespace LivrariaMVC.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O autor principal é obrigatório")]
        [StringLength(100)]
        public string Autor1 { get; set; }

        [StringLength(100)]
        public string? Autor2 { get; set; }

        [Required(ErrorMessage = "A editora é obrigatória")]
        [StringLength(100)]
        public string Editora { get; set; }

        [Required(ErrorMessage = "O ano de lançamento é obrigatório")]
        [Range(1, 9999)]
        public int AnoLancamento { get; set; }

        [Required(ErrorMessage = "A edição é obrigatória")]
        [Range(1, int.MaxValue)]
        public int Edicao { get; set; }

        [Required(ErrorMessage = "O preço sugerido é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal PrecoSugerido { get; set; }
    }
}