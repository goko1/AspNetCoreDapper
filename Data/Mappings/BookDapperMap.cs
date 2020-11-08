using Dapper.FluentMap.Dommel.Mapping;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class BookDapperMap:DommelEntityMap<Book>
    {
        public BookDapperMap()
        {
            ToTable("Book");
            Map(b => b.Id).IsKey().IsIdentity();
        }
    }
}
