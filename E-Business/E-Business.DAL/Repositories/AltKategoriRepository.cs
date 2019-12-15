using Core.DataAccess.BaseClasses.EntityFramework;
using E_Business.DAL.IRepositories;
using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.DAL.Repositories
{
   public class AltKategoriRepository: EFRepositoryBase<AltKategori, int, E_BusinessContext>,IAltKategoriRepository
    {
        public AltKategoriRepository():base(new E_BusinessContext())
        {

        }
    }

}
