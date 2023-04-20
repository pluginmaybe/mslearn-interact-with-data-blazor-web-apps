using System.ComponentModel.DataAnnotations;

namespace BlazingPizza;

public class Address
{
  public int Id { get; set; }
  
  [Required, MinLength(3, ErrorMessage ="Please use a Name longer than 3 characters"), MaxLength(100, ErrorMessage ="Please use a name shorter than 100 characters")]
  public string Name { get; set; }
  
  [Required, MinLength(5, ErrorMessage ="Please use an Address longer than 5 characters"), MaxLength(100, ErrorMessage ="Please use an Address shorter than 100 characters")]
  public string Line1 { get; set; }
  
  [MaxLength(100)]
  public string Line2 { get; set; }
  
  [Required, MinLength(3, ErrorMessage ="Please use a City name longer than 3 characters"), MaxLength(50, ErrorMessage ="Please use a City name shorter than 50 characters")]
  public string City { get; set; }
  
  [Required, MinLength(3, ErrorMessage ="Please use a Region longer than 3 characters"), MaxLength(20, ErrorMessage ="Please use a Region shorter than 20 characters")]
  public string Region { get; set; }

  [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage ="Please use a valid Postal Code")]
  public string PostalCode { get; set; }
}
