using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BunAndFun.Api.Models;

public class Product
{
	[Key]
	public int Id { get; set; }

	[Required]
	[MaxLength(100)]
	public string Name { get; set; } = string.Empty;

	[Required]
	public string Category { get; set; } = string.Empty;

	[Column(TypeName = "decimal(18,2)")]
	public decimal Price { get; set; }

	public string ImageUrl { get; set; } = string.Empty;
}