using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotnetMvcEfDbFirst.Models;

[Keyless]
public partial class DishIngredient
{
    public int? DishId { get; set; }

    public int? IngredientId { get; set; }
}
