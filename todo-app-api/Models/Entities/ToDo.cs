using System;
namespace todo_app_api.Models.Entities
{
	public class ToDo
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
		public bool IsComplated { get; set; }
	}
}

