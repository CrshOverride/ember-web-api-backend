using System.Collections.Generic;

namespace EmberWebApi.Backend.Models
{
	public class Car
	{
		public int Id { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public List<Year> Years { get; set; }
	}
}