using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatanLayoutGenerator.Models;
using Generic.Infrastructure;

namespace CatanLayoutGenerator.Infrastructure {
    public class BoardLayoutRepository : GenericRepository<BoardLayout> {
        public BoardLayoutRepository(ApplicationDbContext db) : base(db) { }
    }
}
