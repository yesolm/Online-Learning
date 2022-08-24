using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Tests
{
    public abstract class ServiceTest
    {
        public TestContext TestContext { get; set; }    
        public DbContextOptions<ApplicationDbContext> ApplicationContextOptions { get; set; }

        public ApplicationDbContext InMemoryApplicationDbContext => _InMemoryApplicationDbContext ?? (_InMemoryApplicationDbContext = new ApplicationDbContext(ApplicationContextOptions));
        private ApplicationDbContext _InMemoryApplicationDbContext;

        [TestInitialize]
        public void BaseSetup()
        {
            ApplicationContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(TestContext.TestName).Options;
        }

        public virtual void AddSeedData(Action<ApplicationDbContext> seedAction)
        {
            using (var context = new ApplicationDbContext(ApplicationContextOptions))
            {
                seedAction(context);
                context.SaveChanges();  
            }
        }

        public virtual void ResetSeedData()
        {
            _InMemoryApplicationDbContext?.Database?.EnsureDeleted();
            BaseCleanup();
        }

        [TestCleanup]
        public void BaseCleanup()
        {
           _InMemoryApplicationDbContext?.Dispose();
           _InMemoryApplicationDbContext = null;    

        }
    }
}
