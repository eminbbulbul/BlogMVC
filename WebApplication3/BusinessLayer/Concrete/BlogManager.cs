using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal; 
	

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogyUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDal.GetListAll();
			
		}

		public Blog TGetById(int id)
		{
            return _blogDal.GetById(id);

        }
		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(b => b.BlogID == id); 
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}
		public List<Blog> GetListWithCategoryByWriterbm(int id)
		{
			return _blogDal.GetListWithCategoryByWriter(id);

		}
		public List<Blog> GetListAll()
		{
			throw new NotImplementedException();
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogListWithByWriter(int id)
		{
			return _blogDal.GetListAll(b => b.WriterID == id);
		}

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
           _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
