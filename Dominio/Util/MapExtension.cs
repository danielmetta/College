using System.Collections.Generic;
using AutoMapper;

namespace Dominio.Util
{
    public static class MapExtension
    {
        public static IEnumerable<TDestino> ToMap<TOrigem, TDestino>(this List<TOrigem> obj)
        {
            return Mapper.Map<IEnumerable<TDestino>>(obj);
        }

        public static TDestino ToMap<TOrigem, TDestino>(this TOrigem obj)
        {
            return Mapper.Map<TDestino>(obj);
        }

    }
}
