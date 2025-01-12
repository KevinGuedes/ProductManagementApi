﻿using FluentResults;
using ProductManagement.Application.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Service
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken);
        Task<Result<ProductDto>> GetProductByCodeAsync(int code, CancellationToken cancellationToken);
        Task<Result> DeleteProductByCodeAsync(int code, CancellationToken cancellationToken);
        Task<Result<ProductDto>> CreateProductAsync(CreateProductDto createProductDto, CancellationToken cancellationToken);
        Task<Result<ProductDto>> UpdateProductAsync(UpdateProductDto updateProductDto, CancellationToken cancellationToken);
    }
}
