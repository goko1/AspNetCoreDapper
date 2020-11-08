using Data.Dapper.Common;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dapper
{
    public class AuthorDapperRepository : DapperRepositoryBase<Author>, IAuthorDapperRepository
    {
        public AuthorDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
