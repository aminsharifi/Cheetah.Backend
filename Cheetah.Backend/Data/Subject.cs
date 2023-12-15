using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah.Backend.Data;
public class Subject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public int Subject_Code { get; set; }
    [Required]
    [StringLength(200)]
    public string Subject_Name { get; set; } = String.Empty;
}