using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetAll();
        void AddHeading(Heading heading);
        void DeleteHeading(Heading heading);
        Heading GetById(int id);
        void UpdateHeading(Heading heading);
    }
}
