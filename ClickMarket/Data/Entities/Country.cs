using System.ComponentModel.DataAnnotations;

namespace ClickMarket.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string Name { get; set; }


    }
}
