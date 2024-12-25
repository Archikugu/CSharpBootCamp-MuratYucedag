using CSharpBootCamp.DataAccessLayer.Abstract;
using CSharpBootCamp.DataAccessLayer.Repositories;
using CSharpBootCamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
