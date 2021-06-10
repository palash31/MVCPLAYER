using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_Player_GIT.Models
{[Table("Player")]
    public class Player
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Team { get; set; }
    }
}