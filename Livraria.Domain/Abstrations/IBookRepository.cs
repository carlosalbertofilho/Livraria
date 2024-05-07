﻿using Livraria.Domain.Entities;

namespace Livraria.Domain.Abstrations;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllAsync ();
    Task<Book> GetByIdAsync ( int id );
    Task<Book> CreateAsync ( Book book );
    Task<Book> UpdateAsync ( Book book );
    Task DeleteAsync ( int id );
}
