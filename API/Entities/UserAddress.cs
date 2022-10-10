using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;

namespace API.Entities.OrderAggregates;

public class UserAddress : Address
{
    public int Id { get; set; }
}
