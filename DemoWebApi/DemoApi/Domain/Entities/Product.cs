using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApi.Domain.Entities
{
    //A record in C# is a class or struct that provides special syntax and behavior for working with data models.

    [Table("product")]
    public record Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; init; }

        [Column("product_name")]
        [MaxLength(100)]
        public string? ProductName { get; init; }


        [Column("product_code")]
        [MaxLength(10)]
        public string? ProductCode { get; init;}

        [Column("price", TypeName = "decima(7, 2)")]
        [MaxLength(10)]
        public decimal Price { get; init; }
    }
}
