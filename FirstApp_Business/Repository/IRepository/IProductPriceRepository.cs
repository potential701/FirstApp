using FirstApp_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp_Business.Repository.IRepository
{
	public interface IProductPriceRepository
	{
		public Task<ProductPriceDTO> Create(ProductPriceDTO objDTO);
		public Task<ProductPriceDTO> Update(ProductPriceDTO objDTO);
		public Task<int> Deleted(int id);
		public Task<ProductPriceDTO> Get(int id);
		public Task<IEnumerable<ProductPriceDTO>> GetAll(int? id=null);
	}
}
