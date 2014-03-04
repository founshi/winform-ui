﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlw.ZPG.Infrastructure.DbContext
{
    public class DbContextFactoryImpl : IDbContextFactory
    {
        public ConfigurationSettings Settings
        {
            get;
            private set;
        }

        public DbContextFactoryImpl(ConfigurationSettings settings)
        {
            this.Settings = settings;
        }

        #region IDbContextFactory 成员

        public EFDbContext GetDbContext()
        {
            return new EFDbContext(this);
        }

        public EFDbContext GetCurrentDbContext()
        {
            if (CurrentDbContext == null)
            {
                return null;
            }
            return CurrentDbContext.GetCurrentDbContext();
        }

        public ICurrentDbContext CurrentDbContext
        {
            get
            {
                if (System.Web.HttpContext.Current != null)
                {
                    return new WebDbContext(this);
                }
                return new ThreadStaticDbContext(this);
            }
        }

        #endregion

    }
}
