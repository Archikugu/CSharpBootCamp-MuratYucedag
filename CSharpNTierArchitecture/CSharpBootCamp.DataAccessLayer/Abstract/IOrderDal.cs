using CSharpBootCamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp.DataAccessLayer.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
    }
}
