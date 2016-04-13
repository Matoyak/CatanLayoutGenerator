using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanLayoutGenerator.Models {
    public class UserBoards {
        public int UserId { get; set; }
        public int BoardLayoutId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public BoardLayout BoardLayout { get; set; }
    }
}
