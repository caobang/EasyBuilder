using EasyBuilder.Core.Repositories;
using EasyBuilder.Domain.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Services.Admin
{
    public class RoleService : ServiceBase<Admin_Role>, IRoleService
    {
        public RoleService(IRepository repository)
            : base(repository) { }
    }
}
