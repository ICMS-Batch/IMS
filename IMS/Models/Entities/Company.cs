using System;
namespace IMS.Models.Entities
{
	public class Company
	{
		public int CompanyId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public int Fax { get; set; }
		public int Pan { get; set; }
		public string Website { get; set; }

		public ICollection<User> Users { get; set; }
	}
}

