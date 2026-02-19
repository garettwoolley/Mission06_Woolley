namespace Mission06_Woolley.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    [Key]
    public int MovieId { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Category is required.")]
    public int CategoryId { get; set; }

    public Categories Category { get; set; }

    [Required(ErrorMessage = "Year is required.")]
    [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100.")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Director is required.")]
    public string Director { get; set; }

    [Required(ErrorMessage = "Rating is required.")]
    public string Rating { get; set; }

    public bool? Edited { get; set; }
    public string? LentTo { get; set; }

    [Required] // optional, but helps avoid null weirdness
    public bool CopiedToPlex { get; set; }

    [MaxLength(25, ErrorMessage = "Notes must be 25 characters or less.")]
    public string? Notes { get; set; }
}