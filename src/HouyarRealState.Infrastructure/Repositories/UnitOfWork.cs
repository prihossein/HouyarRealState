using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HouyarRealState.Application.Contracts;
using HouyarRealState.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ComplateAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new FluentValidation.ValidationException("خطای ذخیره اطلاعات! با مدیر سایت تماس بگیرید", new List<FluentValidation.Results.ValidationFailure>());
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
