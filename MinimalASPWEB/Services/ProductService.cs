using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalASPWEB.Data;
using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;
using System;


namespace MinimalASPWEB.Services

{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Product>> GetAllAsync()
        {
            var itens = await _context.Produtos.ToListAsync();
            return itens;
        }

        public async Task<Product?> GetItemAsync(int id)
        {
            var item = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            return item;
        }

        public async Task<Product?> AddItemAsync(Product product)
        {
            bool verificationName = await _context.Produtos.AnyAsync(n => n.Name == product.Name);
            if (verificationName == false)
            {
                return null;
            }
            //var item = new Product(product);
            await _context.Produtos.AddAsync(product);

            await _context.SaveChangesAsync();

            return product;
        }
        public async Task<Product?> UpdateItemAsync(int id, Product product)
        {
            if (id != product.Id) 
            {
                return null;
            }
            var updateItem = await _context.Produtos.FirstOrDefaultAsync(i => i.Id == product.Id);
            if (updateItem == null)
            {
                return null;
            }
            updateItem.Name = product.Name;
            updateItem.Price = product.Price;
            updateItem.Stock = product.Stock;

            await _context.SaveChangesAsync();

            return updateItem;
        }

        public async Task<Product?> DeleteItemAsync(int Id)
        {
            var item = await _context.Produtos.FirstOrDefaultAsync(i => i.Id == Id);
            if (item == null)
            {
                return false;
            }
            Shelf.Remove(item);

            return true;
        }


    } }
     
    }
