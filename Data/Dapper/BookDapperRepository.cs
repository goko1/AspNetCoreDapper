using Data.Dapper.Common;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dapper
{
    class BookDapperRepository : DapperRepositoryBase<Book>, IBookDapperRepository
    {
        public BookDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public override IEnumerable<Book> GetAll()
        {
            //TODO:Will Add
            return null;
        }

        public override Book GetById(int? id)
        {
            //TODO:Will Add
            return null;
        }
    }
}
