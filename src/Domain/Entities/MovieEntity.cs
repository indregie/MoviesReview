namespace Domain.Entities;

public class MovieEntity
{
    public int Id { get; set; } = default;
    public string Name { get; set; } = default;
    public decimal AverageRate { get; set; } = 0;
}
