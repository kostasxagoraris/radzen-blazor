using System;
using System.Collections.Generic;
using Olympus.Cronus.DomainModel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadzenBlazorDemos.Models.Northwind
{
  [Table("CustomerDemographics")]
  public partial class CustomerDemographic
  {
    [Key]
    public string CustomerTypeID
    {
      get;
      set;
    }


    [InverseProperty("CustomerDemographic")]
    public ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    public string CustomerDesc
    {
      get;
      set;
    }
  }
}
