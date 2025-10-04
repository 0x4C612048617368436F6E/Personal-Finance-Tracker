using Microsoft.EntityFrameworkCore;
using personalfinancetrackerbackend.Model;
using personalfinancetrackerbackend.Model.ModelDTO;
namespace personalfinancetrackerbackend.DatabaseInteraction
{
    public class DataInteraction:DbContext
    {

        public DataInteraction(DbContextOptions<DataInteraction> options) : base(options)
        {

        }

        public DbSet<UserModel> userTable;
        public DbSet<AdminModel> adminTable;
        public DbSet<AccountModel> accountTable;
        public DbSet<AdminRoleModel> adminRoleTable;
        public DbSet<BudgetModel> budgetTable;
        public DbSet<TransactionModel> transactionTable;
        public DbSet<UserRoleModel> userRoleTable;
        public DbSet<RoleModel> roleTable;
        public DbSet<CategoryModel> categoryTable;

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //RoleModel
            modelBuilder.Entity<RoleModel>().HasData(
                new RoleModel { id = 1, roleType = "user" },
                new RoleModel { id = 2, roleType = "admin" }
                );
            //Category
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { id = 1, category = "Housing" },
                new CategoryModel { id = 2, category = "Transportation" },
                new CategoryModel { id = 3, category = "Food" },
                new CategoryModel { id = 4, category = "Utilities" },
                new CategoryModel { id = 5, category = "Insurance" },
                new CategoryModel { id = 6, category = "Medical & Healthcare" },
                new CategoryModel { id = 7, category = "Saving, Investing, & Debt Payments" },
                new CategoryModel { id = 8, category = "Personal Spending" },
                new CategoryModel { id = 9, category = "Recreation & Entertainment" },
                new CategoryModel { id = 10, category = "Miscellaneous" }
                );
        }

        public DbSet<UserModel> UserTable
        {
            get
            {
                return userTable;
            }
            set
            {
                userTable = value;
            }
        }

        public DbSet<AdminModel> AdminTable
        {
            get
            {
                return adminTable;
            }
            set
            {
                adminTable = value;
            }
        }

        public DbSet<AccountModel> AccountTable
        {
            get
            {
                return accountTable;
            }
            set
            {
                accountTable = value;
            }
        }

        public DbSet<AdminRoleModel> AdminRoleTable
        {
            get
            {
                return adminRoleTable;
            }
            set
            {
                adminRoleTable = value;
            }
        }

        public DbSet<BudgetModel> BudgetTable
        {
            get
            {
                return budgetTable;
            }
            set
            {
                budgetTable = value;
            }
        }

        public DbSet<TransactionModel> TransactionTable
        {
            get
            {
                return transactionTable;
            }
            set
            {
                transactionTable = value;
            }
        }

        public DbSet<UserRoleModel> UserRoleTable
        {
            get
            {
                return userRoleTable;
            }
            set
            {
                userRoleTable = value;
            }
        }

        public DbSet<RoleModel> RoleTable
        {
            get
            {
                return roleTable;
            }
            set
            {
                roleTable = value;
            }
        }

        public DbSet<CategoryModel> CategoryTable
        {
            get
            {
                return categoryTable;
            }
            set
            {
                categoryTable = value;
            }
        }

    }
}
