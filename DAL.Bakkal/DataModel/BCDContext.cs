﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Bakkal.Migrations;

namespace DAL.Bakkal.DataModel
{
    public class BCDContext : DbContext
    {
        public BCDContext() : base("BCDContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BCDContext, Configuration>("BCDContext"));
        }
        public virtual DbSet<Urunler> Urunlers { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<SatisDetay> SatisDetay { get; set; }
        public virtual DbSet<Masraf> Masraf { get; set; }
        public virtual DbSet<Tedarikci> Tedarikci { get; set; }
        public virtual DbSet<TedarikDetay> TedarikDetay { get; set; }
        public virtual DbSet<Siparis> Siparis{ get; set; }


    }
}
