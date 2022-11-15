using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstracts
{
    public interface IPersonelRep
    {
        public int GetAge();
        public string FullName();
        public List<string> GetAdress();
        public List<PersonelGradeList> ListbyGrade();
        public List<PersonelDepList> ListbyDepartment();
    }
}
