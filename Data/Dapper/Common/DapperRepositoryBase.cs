using Dapper.Contrib.Extensions;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Data.Mappings;
using Domain.Interfaces.Repositories.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data.Dapper.Common
{
    public abstract class DapperRepositoryBase<Tentity> : IRepositoryBase<Tentity> where Tentity : class
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection conn;

        public DapperRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;

            if (FluentMapper.EntityMaps.IsEmpty)
            {
                FluentMapper.Initialize( c=>
                {
                    c.AddMap(new BookDapperMap());
                    c.AddMap(new AuthorDapperMap());
                    c.ForDommel();
                });
            }

            conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
        public void Delete(Tentity obj)
        {
            conn.Delete(obj);
        }

        public virtual IEnumerable<Tentity> GetAll()
        {
            return conn.GetAll<Tentity>();
        }

        public virtual Tentity GetById(int? id)
        {
            return conn.Get<Tentity>(id);
        }

        public void Update(Tentity obj)
        {
            conn.Update(obj);
        }

        public void Add(Tentity obj)
        {
            conn.Insert(obj);
        }

        private bool _disposed = false;

        public void Dispose()
        {
            if (Equals(!_disposed))
            {
                conn.Close();
                conn.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
