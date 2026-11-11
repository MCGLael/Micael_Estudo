
using Microsoft.EntityFrameworkCore;
using MinimalASPWEB.Data;
using MinimalASPWEB.Models;
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
            return await _context.Produtos.ToListAsync();
            
        }

        public async Task<Product?> GetItemAsync(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            
        }

        public async Task<Product?> AddItemAsync(Product product)
        {
            bool verificationName = await _context.Produtos.AnyAsync(n => n.Name == product.Name);
            if (verificationName)
            {
                return null;
            }
            
            _context.Produtos.Add(product);

            await _context.SaveChangesAsync();

            return product;
        }
        public async Task<Product?> UpdateItemAsync(int id, Product product )
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

        public async Task<bool> DeleteItemAsync(int Id)
        {
            var item = await _context.Produtos.FirstOrDefaultAsync(i => i.Id == Id);
            if (item == null)
            {
                return false;
            }
            _context.Produtos.Remove(item);

            await _context.SaveChangesAsync();

            return true;
        }


    } 
}
    
