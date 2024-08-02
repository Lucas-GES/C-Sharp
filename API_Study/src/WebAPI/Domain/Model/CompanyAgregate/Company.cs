using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Domain.Model.CompanyAgregate
{
    [Table("company")]
    public class Company
    {
        [Key]
        public int id {get; set;}
        public string name {get; set;}
    }
}