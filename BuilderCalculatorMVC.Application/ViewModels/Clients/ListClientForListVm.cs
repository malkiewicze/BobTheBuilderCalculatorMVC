using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels
{
    public class ListClientForListVm
    {
        public List<ClientForListVm> Clients { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }

    }
}
