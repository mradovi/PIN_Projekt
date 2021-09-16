using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mmaCrudPin.Models
{
    public enum Mma_category
    {
        [Display(Name = "Bez kategorije")]
        bezKategorije = 0,
        [Display(Name = "Laka kategorija")]
        laka = 1,
        [Display(Name = "Srednja kategorija")]
        srednja = 2,
        [Display(Name = "Teska kategorija")]
        teska = 3
    };
    public class mmaFighter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fighterId { get; set; }
        
        [Display(Name = "Naziv borca")]
        [Required(ErrorMessage ="Obvezan unos borca")]
        public string figtherName { get; set; }

        [Display(Name = "Kategorija borca")]
        [DefaultValue(0)]
        [Required(ErrorMessage = "Morate odabrati kategoriju borca")]
        public Mma_category category { get; set; }

        [Display(Name = "Kreiran")]
        [DataType(DataType.Date)]
        public DateTime? created { get; set; }
        
        [Display(Name = "Zadnja promjena")]
        [DataType(DataType.Date)]
        public DateTime? modified { get; set; }
        
        [Display(Name = "Obrisan")]
        public DateTime? deleted { get; set; }

        [Display(Name = "Starost borca")]
        public string age { get; set; }

        [Display(Name = "Omjer [W-L-D-NC]")]
        public string mma_record { get; set; }

        [Display(Name = "Vrijednost u $")]
        [Required(ErrorMessage = "Potrebno unijeti novcanu vrijednost")]
        [RegularExpression(@"\d+(,\d{1,2}|\.(\d{1,4}))?", ErrorMessage = "Unesi valjanu vrijednost novca")]
        #nullable enable
        public string? worth_salary { get; set; }


    }
}
