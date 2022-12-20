using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarBuyKaro.Models
{
    public class Card
    {
        /* id number */
        [Key]
        public int Id { get; set; }

        /* car Img */

        [Display(Name = "Upload Car Image")]
        public string? Image_Path { get; set; }

        [Required]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        /* car number*/

        [Required(ErrorMessage = "Car Number Can't be Blank")]
        [Display(Name = "Car Number")]
        //[Remote(action: "IsCardCarNumberExist", "Card", ErrorMessage = "CarNumber already Exists")]
        public int Car_no { get; set; }

        /* car model name */

        [Required(ErrorMessage = "Model name Can't be Blank")]
        [Display(Name = "Model Name")]
        public string? Model_Name { get; set; }

        /* Car Age */

        [Required(ErrorMessage = "Car age Can't be Blank")]
        [Display(Name = "Car age")]
        public string? Car_age { get; set; }

        /* car_base_price */

        [Required(ErrorMessage = "Car Base Price Can't be Blank")]

        [Display(Name = "Base Price")]
        public int Car_base_price { get; set; }

        /*Insurence Premium */

        [Required(ErrorMessage = "Insurence Premium Price Can't be Blank")]

        [Display(Name = "Insurence Premium Price")]
        public int Car_insurence_price { get; set; }

        /* Road Tax */

        public int Car_tax { get; set; }


        /* Insurence cost */

        public int Car_ins { get; set; }

        /* Selling Price */

        public int Selling_price { get; set; }
    }
}
