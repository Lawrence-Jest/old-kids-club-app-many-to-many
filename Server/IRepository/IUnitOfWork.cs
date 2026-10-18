using KidsClubApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Parent> Parents { get;}
        IGenericRepository<Child> Children { get;}
        IGenericRepository<Address> Addresses { get;}
        IGenericRepository<SignInSheetEntry> SignInSheetEntries { get;}

    }
}
