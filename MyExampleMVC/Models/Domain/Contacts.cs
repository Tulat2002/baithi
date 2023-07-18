using System;
namespace MyExampleMVC.Models.Domain
{
	public class Contacts
	{
		public Guid Id { get; set; }
		public string ContactName { get; set;}
		public string ContactNumber { get; set; }
		public string GroupName { get; set; }
		public DateTime HireDate { get; set; }
		public DateTime Birthday { get; set; }
    }
}

