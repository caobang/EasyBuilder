using EasyBuilder.Core.ObjectContainers.Extension;
using EasyBuilder.Domain.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Services.Admin
{
    public interface IMenuService : IServiceBase<Admin_Menu>, IAssemblyDependency
    {
        List<Admin_Menu> GetSubMenus(Guid Key);
    }
}
