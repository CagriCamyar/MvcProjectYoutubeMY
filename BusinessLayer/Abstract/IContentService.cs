using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContentService
	{
		List<Content> GetAll();
		void Add(Content content);
		Content GetById(int id);
		void ContentDelete(Content content);
		void ContentUpdate(Content content);
		List<Content> GetAllById(int id);
	}
}
