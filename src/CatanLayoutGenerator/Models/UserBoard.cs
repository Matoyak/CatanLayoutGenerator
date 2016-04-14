using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatanLayoutGenerator.Models {
    public class UserBoard {
        public string UserId { get; set; }
        public int BoardLayoutId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        [ForeignKey("BoardLayoutId")]
        public BoardLayout BoardLayout { get; set; }
    }
}
