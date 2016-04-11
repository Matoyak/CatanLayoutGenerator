using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatanLayoutGenerator.Infrastructure;
using CatanLayoutGenerator.Services.Models;

namespace CatanLayoutGenerator.Services {
    public class BoardLayoutService {
        private BoardLayoutRepository _boardLayoutRepo;

        public BoardLayoutService(BoardLayoutRepository boardLayoutRepo) {
            _boardLayoutRepo = boardLayoutRepo;
        }

        public ICollection<BoardLayoutDTO> GetBoardLayouts() {
            return (from b in _boardLayoutRepo.List()
                    select new BoardLayoutDTO {
                        LayoutImg = b.LayoutImg
                    }).ToList();
        }
    }
}
