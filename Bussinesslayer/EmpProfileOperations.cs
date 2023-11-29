using DataAccesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinesslayer
{
    public class EmpProfileOperations
    {
        EmpProfileRepository empProfileRepository = new EmpProfileRepository(new EmsContext());

        public void insertEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Insert(empProfile);

        }

        public List<EmpProfile> ListOfEmployee()
        {
            return empProfileRepository.GetAll().ToList();
        }

    }

}
