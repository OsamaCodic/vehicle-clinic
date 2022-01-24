﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vehicle_clinic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class vehicle_clinicEntities : DbContext
    {
        public vehicle_clinicEntities()
            : base("name=vehicle_clinicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }
    
        //public virtual ObjectResult<GetUsers_Result> GetUsers()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsers_Result>("GetUsers");
        //}
    
        //public virtual ObjectResult<get_users_Result> get_users()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_users_Result>("get_users");
        //}
    
        //public virtual ObjectResult<getUsers2_Result> getUsers2()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUsers2_Result>("getUsers2");
        //}
    
        public virtual ObjectResult<readUsers_Result> readUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<readUsers_Result>("readUsers");
        }
    
        public virtual int deleteUser(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteUser", user_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> totalUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("totalUsers");
        }
    
        public virtual ObjectResult<getSingleUser_Result> getSingleUser(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSingleUser_Result>("getSingleUser", userIDParameter);
        }
    
        public virtual ObjectResult<getCategories_Result> getCategories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCategories_Result>("getCategories");
        }
    
        public virtual int deleteCategory(Nullable<int> category_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCategory", category_idParameter);
        }
    
        public virtual int deleteCategory2(Nullable<int> categoryID)
        {
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("categoryID", categoryID) :
                new ObjectParameter("categoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCategory2", categoryIDParameter);
        }
    }
}
