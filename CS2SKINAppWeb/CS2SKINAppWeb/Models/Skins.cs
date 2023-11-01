using System.ComponentModel.DataAnnotations;

namespace CS2SKINAppWeb.Models
{
    public class Skins
    {
        public int SkinsID {  get; set; }
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Caminho da Imagem")]
        public string ImagemUri { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        [Display(Name = "Data Publicada")]
        public DateTime DataCadastro { get; set; }


        public string Raridade { get; internal set; }

        [Display(Name = "Condição")]
        public string Condicao { get; internal set; }

        public string Float { get; internal set; }
        public int Pattern { get; internal set; }
    }
}
