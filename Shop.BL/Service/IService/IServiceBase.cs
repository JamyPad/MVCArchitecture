using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.IService
{
    public interface IServiceBase<TModel>
    {
        TModel Add(TModel model);
        TModel Delete(long id);
        TModel Update(TModel model);
         IEnumerable<TModel> GetAll();
    }
}
