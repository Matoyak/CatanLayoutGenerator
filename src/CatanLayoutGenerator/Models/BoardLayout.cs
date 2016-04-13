using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanLayoutGenerator.Models {
    public class BoardLayout {
        public int Id { get; set; }
        public string Layout { get; set; } //serialized Json of 19 hexs. (Comes from Board).
        public string LayoutImg { get; set; } //the initial idea to get project working.

        public ICollection<UserBoards> UserBoards { get; set; }
    }
}
