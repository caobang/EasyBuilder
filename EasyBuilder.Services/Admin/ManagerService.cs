using EasyBuilder.Core.Repositories;
using EasyBuilder.Domain.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Services.Admin
{
    public class ManagerService : ServiceBase<Admin_Manager>, IManagerService
    {
        public ManagerService(IRepository repository)
            : base(repository) { }

        public Admin_Manager Login(string username, string password)
        {
            return this.Repository.QuerySingle<Admin_Manager>(a => (a.Name == username || a.Username == username) && a.Password == password);
        }

    }
}
