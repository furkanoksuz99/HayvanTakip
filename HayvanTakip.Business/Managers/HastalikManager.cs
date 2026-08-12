using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;
using System.Collections.Generic;

namespace HayvanTakip.Business.Managers
{
    public class HastalikManager
    {
        private readonly HastalikRepository _repository;

        public HastalikManager()
        {
            _repository = new HastalikRepository();
        }

        public List<Hastalik> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Hastalik hasta)
        {
            _repository.Add(hasta);
        }

        public void Update(Hastalik hasta)
        {
            _repository.Update(hasta);
        }

        public Hastalik GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}