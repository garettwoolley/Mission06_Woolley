namespace Mission06_Woolley.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    [Key]
    public int MovieId { get; set; } //comment
    public string Title { get; set; }
    
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    
    public Categories Category { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    public bool? Edited { get; set; }
    public string? LentTo { get; set; }
    public bool CopiedToPlex { get; set; }
    public string? Notes { get; set; }
    
}