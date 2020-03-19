namespace _102170301_HoangDucThanh_17TCLC2
{
    using _102170301_HoangDucThanh_17TCLC2.DTO;
    using _102170301_HoangDucThanh_17TCLC2.DAL;
    using System;
    using System.Data.Entity;
    using System.Linq;
    
    public class QLNV : DbContext
    {
        // Your context has been configured to use a 'QLNV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_102170301_HoangDucThanh_17TCLC2.QLNV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLNV' 
        // connection string in the application configuration file.
        public QLNV()
            : base("name=QLNV")
        {
            Database.SetInitializer(new CreateDB());
        }
        public virtual DbSet<Employees> Employs{ get; set; }
        public virtual DbSet<Departments> Departs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}