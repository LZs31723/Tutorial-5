using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_5.DTO;
using Tutorial_5.Data;
using Tutorial_5.Entity;

namespace Tutorial_5.Services;

public class DbService : IDbService
{

    private readonly AppDbContext _context;

    public DbService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PcGet>> GetPcsAsync()
    {
        return await _context.PCs
            .Select(e => new PcGet
            {
                Id = e.Id,
                Name = e.Name,
                Weight = e.Weight,
                Warranty = e.Warranty,
                CreatedAt = e.CreatedAt,
                Stock = e.Stock
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<PcComponentDto>> GetPcComponents(int id)
    {
        var pcExists = await _context.PCs.AnyAsync(e => e.Id == id);
        if (!pcExists)
        {
            return null;
        }

        return await _context.PCComponents
            .Where(pc => pc.PCId == id)
            .Select(pc => new PcComponentDto
            {
                Code = pc.Component.Code,
                Name = pc.Component.Name,
                Description = pc.Component.Description,
                ManufacturerAbbreviation = pc.Component.ComponentManufactures.Abbreviation,
                TypeAbbreviation = pc.Component.ComponentType.Abbreviation,
                Amount = pc.Amount
            })
            .ToListAsync();
    }

    public async Task<PcGet> CreatePcAsync(PcCreate dto)
    {
        var pc = new PC
        {
            Name = dto.Name,
            Weight = dto.Weight,
            Warranty = dto.Warranty,
            CreatedAt = dto.CreatedAt,
            Stock = dto.Stock
        };
        
        _context.PCs.Add(pc);
        await _context.SaveChangesAsync();

        return new PcGet
        {
            Id = pc.Id,
            Name = pc.Name,
            Weight = pc.Weight,
            Warranty = pc.Warranty,
            CreatedAt = pc.CreatedAt,
            Stock = pc.Stock
        };
    }

    public async Task<PcGet> UpdatePcAsync(int id, PcUpdate dto)
    {
        var pc = await _context.PCs.FindAsync(id);
        if (pc == null)
        {
            return null;
        }
        pc.Name = dto.Name;
        pc.Weight = dto.Weight;
        pc.Warranty = dto.Warranty;
        pc.CreatedAt = dto.CreatedAt;
        pc.Stock = dto.Stock;
        
        await _context.SaveChangesAsync();

        return new PcGet
        {
            Id = pc.Id,
            Name = pc.Name,
            Weight = pc.Weight,
            Warranty = pc.Warranty,
            CreatedAt = pc.CreatedAt,
            Stock = pc.Stock
        };
    }

    public async Task<bool> DeletePcAsync(int id)
    {
       var pc = await _context.PCs.FindAsync(id);
       if (pc == null)
       {
           return false;
       }
       _context.PCs.Remove(pc);
         await _context.SaveChangesAsync();
         return true;
    }
}