using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commons.Data.Models;

[Table("Cartoes")]
public class Cartao
{
    [Key]
    public int Id { get; set; }

    [Column("Numero")]
    [Required]
    [StringLength(16, ErrorMessage = "O número do cartão deve ter 16 dígitos.")]
    public string Numero { get; set; } = string.Empty;

    [Column("Titular")]
    [Required]
    [StringLength(100, ErrorMessage = "O titular do cartão deve ter no máximo 100 caracteres.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "O titular do cartão deve conter apenas letras e espaços.")]
    public string Titular { get; set; } = string.Empty;

    [Column("DataExpiracao")]
    [Required]
    [DataType(DataType.Date)]
    public DateTime DataExpiracao { get; set; }

    [Column("CodigoSeguranca")]
    [Required]
    [StringLength(3, ErrorMessage = "O código de segurança deve ter 3 dígitos.")]
    [RegularExpression(@"^\d{3}$", ErrorMessage = "O código de segurança deve conter apenas números.")]
    public string CodigoSeguranca { get; set; } = string.Empty;

    [Column("CartaoId")]
    public int CartaoId { get; set; }

    [ForeignKey(nameof(CartaoId))]
    public Cliente Cliente { get; set; } = null!;
}