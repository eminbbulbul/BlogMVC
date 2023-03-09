using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService :IGenericService<Blog>
	{
		//void BlogAdd(Blog blog);
		//void BlogDelete(Blog blog);
		//void BlogyUpdate(Blog blog);
		//List<Blog> GetListAll();
		//Blog GetById(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListWithByWriter(int id);
	}
}
