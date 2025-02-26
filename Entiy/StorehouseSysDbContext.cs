﻿using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entiy
{
    public class StorehouseSysDbContext: DbContext
    {
        public StorehouseSysDbContext(DbContextOptions<StorehouseSysDbContext> options) : base(options)
        {
        }

        public StorehouseSysDbContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer($"Data Source=.;Initial Catalog=StorehouseSys;User ID=sa;Password=123");
        //}


        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<DepartmentInfo> DepartmentInfo { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<R_UserInfo_RoleInfo> R_UserInfo_RoleInfo { get; set; }
        public DbSet<MenuInfo> MenuInfo { get; set; }
        /// <summary>
        /// 类别数据集
        /// </summary>
        public DbSet<Category> Category { get; set; }

        /// <summary>
        /// 耗材数据集
        /// </summary>
        public DbSet<ConsumableInfo> ConsumableInfo { get; set; }

        /// <summary>
        /// 耗材记录数据集
        /// </summary>
        public DbSet<ConsumableRecord> ConsumableRecord { get; set; }
        /// <summary>
        ///  菜单绑定数据集
        /// </summary>
        public DbSet<R_RoleInfo_MenuInfo> R_RoleInfo_MenuInfo { get; set; }
        /// <summary>
        /// 工作流实列数据集
        /// </summary>
        public DbSet<WorkFlow_Instance> WorkFlow_Instance { get; set; }
        /// <summary>
        /// 工作流步骤表数据集
        /// </summary>
        public DbSet<WorkFlow_InstanceStep> WorkFlow_InstanceStep { get; set; }
        /// <summary>
        /// 工作流模板表数据集
        /// </summary>
        public DbSet<WorkFlow_Model> WorkFlow_Model { get; set; }
    }
}
