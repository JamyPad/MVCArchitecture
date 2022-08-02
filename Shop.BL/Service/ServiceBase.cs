using AutoMapper;
using Shop.BL.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.IRepositories;

namespace Shop.BL.Service
{
    public class ServiceBase<TEntity, TModel> : IServiceBase<TModel>

    {
        protected readonly IMapper _mapper;
        protected readonly IRepository<TEntity> _repository;

        public ServiceBase(IMapper mapper,IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public TModel Add(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);
                entity = _repository.Add(entity);
                _repository.SaveChanges();
                model = _mapper.Map<TModel>(entity);
                return model;
            }
            catch (Exception ex)
            {
                return default(TModel);
            }
        }


        public TModel Delete(long id)
        {
            try
            {
                var entity = _repository.GetById(id);
                if (entity == null)
                {
                     return default(TModel);
                }
                var model = _mapper.Map<TModel>(entity);
                _repository.Delete(entity);
                _repository.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {
                return default(TModel);
            }
        }

        public IEnumerable<TModel> GetAll()
        {
            try
            {
                var query = _repository.All();
                var entityList = query;
                var model = entityList.Select(x => _mapper.Map<TModel>(x));
                return model;
            }
            catch (Exception ex)
            {
                return default(List<TModel>);
            }
        }

   

        public TModel Update(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);
                entity = _repository.Update(entity);
                _repository.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {
                return default(TModel);
            }
        }
    }
}
