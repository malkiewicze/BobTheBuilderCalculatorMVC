using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.Mapping
{
    public interface IMapFrom<T>
    {
        //w każdej klasie, która będzie implementowała ten interfejs będzie metoda Mapping
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
