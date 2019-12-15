using E_Business.BLL.IServices;
using E_Business.BLL.Services;
using E_Business.DAL.Repositories;
using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.BLL.Controller
{
        public class YorumController : ServiceBase<Yorum, int>, IYorumServices
        {
            public YorumController() : base(new YorumRepository())
            {

            }
        }
}
