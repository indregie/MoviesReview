using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response;

public class RateResponse
{
    public DateTime Date { get; set; }
    public string Currency { get; set; }
    public decimal Rate { get; set; }
    public decimal Difference { get; set; }
}
