namespace BankSystem
{
    using System.Data.Entity;

    public class BankDataModel : DbContext
    {
        // Your context has been configured to use a 'BankDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BankSystem.BankDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BankDataModel' 
        // connection string in the application configuration file.
        public BankDataModel()
            : base("name=BankDataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public int UserId { get; set; }
        public float AccountBalance { get; set; }
    }

    public class User
    {
        public int AccountNumber { get; set; }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}