using AutoMapper;
using Puc.Clean.Livraria.Application.UseCases.CreateBook;
using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.Mapping
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, CreateBookOutput>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Isbn, opt => opt.MapFrom(src => src.Isbn));
        }
    }
}
