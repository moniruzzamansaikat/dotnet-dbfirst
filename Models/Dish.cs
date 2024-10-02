using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotnetMvcEfDbFirst.Models;

public partial class Dish
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [Column(TypeName = "decimal(18, 8)")]
    public decimal? Price { get; set; }
}
