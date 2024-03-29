﻿using CourseProject.Domain.Entities.Infrastructure;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseProject.Data.IRepositories;

public interface IGenericRepository<T> where T : BaseEntity
{
	IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true);
	ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, bool isTracking = true, string[] includes = null);
	ValueTask<T> CreateAsync(T entity);
	ValueTask<bool> DeleteAsync(int id);
	T Update(T entity);
	ValueTask SaveChangesAsync();
}
