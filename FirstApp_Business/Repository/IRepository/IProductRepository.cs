using FirstApp_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp_Business.Repository.IRepository
{
	public interface IProductRepository
	{
		public Task<ProductDTO> Create(ProductDTO objDTO);
		public Task<ProductDTO> Update(ProductDTO objDTO);
		public Task<int> Deleted(int id);
		public Task<ProductDTO> Get(int id);
		public Task<IEnumerable<ProductDTO>> GetAll();
	}
}
