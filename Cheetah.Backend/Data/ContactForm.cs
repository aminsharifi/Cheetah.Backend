using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah.Backend.Data;
public class ContactForm
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage ="لطفا نام را وارد نمایید")]
    [StringLength(200)]
    public String Name { get; set; } = String.Empty;

    public String PhoneNumber { get; set; } = String.Empty;
    
    [Required(ErrorMessage ="ایمیل ضروری می باشد")]
    [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نمی باشد")]
    public String Email { get; set; } = String.Empty;

    [Required]
    public Subject Subject { get; set; } = new Subject();

    [Required]
    [StringLength(1024)]
    public String Message { get; set; } = String.Empty;
}
