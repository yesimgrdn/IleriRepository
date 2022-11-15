using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstracts;

namespace IleriRepository.Repositories.Concretes
{
    public class PersonelRep : BaseRepository<Personel>, IPersonelRep
    {
        public PersonelRep(MyContext db) : base(db)
        {
        }

        public string FullName()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAdress()
        {
            throw new NotImplementedException();
        }

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public List<PersonelDepList> ListbyDepartment()
        {
            throw new NotImplementedException();
        }

        public List<PersonelGradeList> ListbyGrade()
        {
            throw new NotImplementedException();
        }
    }
}
