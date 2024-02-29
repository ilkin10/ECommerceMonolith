using App.Core.DataAccess.EntityFrameWork;
using App.DataAccess.Abstract;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Concrete.EFEntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
    }
}
