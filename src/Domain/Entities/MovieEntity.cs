﻿namespace Domain.Entities;

public class MovieEntity
{
    public int Id { get; set; } = default;
    public string Name { get; set; } = string.Empty;
    public decimal AverageRate { get; set; } = default(decimal);
}
