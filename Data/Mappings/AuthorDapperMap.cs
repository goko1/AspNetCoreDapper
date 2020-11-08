using Dapper.FluentMap.Dommel.Mapping;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class AuthorDapperMap : DommelEntityMap<Author>
    {
        public AuthorDapperMap()
        {
            ToTable("Author");
            Map(a => a.Id).IsKey();
        }
    }
}
