using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbtest
{
    public class dndContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Player> Players { get; set; }

        public string DbPath { get; }

        public dndContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "dndhelperapp.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Monster
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
    } 
    public class Player
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; }
    }
}
