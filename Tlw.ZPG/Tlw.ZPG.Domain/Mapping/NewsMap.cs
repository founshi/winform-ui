//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tlw.ZPG.Domain.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using Tlw.ZPG.Domain.Models;
    
    internal partial class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {                        
              this.HasKey(t => t.NewsId);        
              this.ToTable("C_News");
              this.Property(t => t.NewsId).HasColumnName("NewsId");
              this.Property(t => t.Title).HasColumnName("Title").IsRequired().HasMaxLength(100);
              this.Property(t => t.Content).HasColumnName("Content").IsRequired();
              this.Property(t => t.NewsType).HasColumnName("NewsType");
              this.Property(t => t.CreateTime).HasColumnName("CreateTime");
              this.Property(t => t.CreatorId).HasColumnName("CreatorId");
              this.Property(t => t.CreatorUser).HasColumnName("CreatorUser").IsRequired().HasMaxLength(50);
         }
    }
}
