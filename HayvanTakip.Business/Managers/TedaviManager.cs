using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HayvanTakip.Business.Managers
{
    public class TedaviManager
    {
        private readonly TedaviRepository _repository;

        public TedaviManager()
        {
            _repository = new TedaviRepository();
        }

        public List<Tedavi> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Tedavi tedavi)
        {
            _repository.Add(tedavi);
        }

        public bool Delete(int id)
        {
           return _repository.Delete(id);
        }

        public void Update(Tedavi tedavi)
        {
            _repository.Update(tedavi);
        }

        public Tedavi GetById(int id)
        {
            return _repository.GetById(id);
        }
    }

}
