using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XevosPractice.Models
{
	public class Employee
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Zadejte křestní jméno")]
		[MaxLength(100)]
		public string Jmeno { get; set; }

		[Required(ErrorMessage = "Zadejte přijímení")]
		[MaxLength(100)]
		public string Prijmeni { get; set; }
		public DateTime Date { get; set; }
	}
}
