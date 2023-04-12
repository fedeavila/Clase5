using System.ComponentModel.DataAnnotations;

namespace Clase5.Models;

public class Car
{
	public int Id { get; set; }

	[Display(Name = "Marca")]
	public string? Brand { get; set; }
	public string? Modelo { get; set; }

	[Display(Name = "Año")]
	public int Year { get; set; }

	[Display(Name = "Patente")]
	public string? Plate { get; set; }
	public string? Color { get; set; }
}