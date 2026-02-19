namespace Mission06_Woolley.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Categories
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}