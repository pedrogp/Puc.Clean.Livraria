using AutoMapper;
using Puc.Clean.Livraria.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.Mapping
{
    public class OutputConverter : IOutputConverter
    {
        private readonly IMapper mapper;

        public OutputConverter()
        {
            mapper = new MapperConfiguration(cfg => {
                cfg.AddProfile<BooksProfile>();
            }).CreateMapper();
        }

        public T Map<T>(object source)
        {
            T model = mapper.Map<T>(source);
            return model;
        }
    }
}
