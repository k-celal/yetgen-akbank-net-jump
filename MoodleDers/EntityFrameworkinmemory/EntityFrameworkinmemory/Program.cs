
using EntityFrameworkinmemory.Entities;
using EntityFrameworkinmemory.Persistence;

Console.WriteLine("Entity Framework Core");

NoteMasterDbContext _context = new();
_context.Notes.Add(new("Note-1"));
_context.Notes.Add(new("Note-2"));
_context.Notes.Add(new("Note-3"));

_context.SaveChanges();

List<Note> notes = _context.Notes.ToList();

Console.WriteLine();