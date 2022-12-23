using BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class PermissionContext : DbContext
    {
        public PermissionContext() { }
        public PermissionContext(DbContextOptions<PermissionContext> options) : base(options)
        {

        }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
    }
}
