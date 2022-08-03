using FirstApp_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp_Business.Repository.IRepository
{
	public interface ICategoryRepository
	{
		public CategoryDTO Create(CategoryDTO objDTO);
		public CategoryDTO Update(CategoryDTO objDTO);
		public int Deleted(int id);
		public CategoryDTO Get(int id);
		public IEnumerable<CategoryDTO> GetAll();
	}
}
