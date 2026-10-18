using KidsClubApp.Server.Data;
using KidsClubApp.Server.IRepository;
using KidsClubApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Parent> _parents;
        private IGenericRepository<Child> _children;
        private IGenericRepository<Address> _addresses;
        private IGenericRepository<SignInSheetEntry> _signInSheetEntries;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Parent> Parents => _parents ??= new GenericRepository<Parent>(_context);
        public IGenericRepository<Child> Children => _children ??= new GenericRepository<Child>(_context);
        public IGenericRepository<Address> Addresses => _addresses ??= new GenericRepository<Address>(_context);
        public IGenericRepository<SignInSheetEntry> SignInSheetEntries => _signInSheetEntries ??= new GenericRepository<SignInSheetEntry>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries().Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;

                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }



            await _context.SaveChangesAsync();
        }
    }
}
