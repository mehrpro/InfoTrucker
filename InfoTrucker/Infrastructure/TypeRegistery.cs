using InfoTrucker.Models;
using StructureMap;

namespace InfoTrucker.Infrastructure
{
    public class TypeRegistery : Registry

    {
        public TypeRegistery()
        {
            For<UnitofWork<AppDbContext>>();

        }
    }
}