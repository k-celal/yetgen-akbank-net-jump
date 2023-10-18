using EntityFrameworkExample.Entities;
using EntityFrameworkExample.Persistence;

EntityFEDbContext _context = new();

var category = new Category()
{
    Id = 1,
    Name = "Bilgisayar"
};

var category2 = new Category()
{
    Id = 2,
    Name = "Ekran kartı"
};


_context.Products.Add(new("Asus pc", 400, category));
_context.Products.Add(new("Monster pc", 200, category));
_context.Products.Add(new("3050ti gpu", 200, category2));
_context.Products.Add(new("4090ti gpu", 800, category2));

_context.Products.AddRange(new List<Product>
{
    new Product ("Lenovo pc",300, category),
    new Product ("Macbook pc", 500, category),
    new Product ("2050ti", 100, category2),
    new Product ("4060 gpu", 400, category2),
});

_context.SaveChanges();

_context.Products.RemoveRange(_context.Products.Where(x => x.Name == "Notebook 1"));

_context.SaveChanges();

var product = _context.Products.First();
product.Name = "Asus pc 4080";


List<Product> products = _context.Products.ToList();


Console.WriteLine();