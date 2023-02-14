using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IT_Lab5_181199.Models
{
    public class FriendModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Range(0, 200, ErrorMessage = "ID must be an Integer between 0 and 200")]
        public int Id{ get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string MestoZiveenje { get; set; }

        //public FriendModel(int id, string ime, string mestoZiveenje)
        //{
        //    Id = id;
        //    Ime = ime;
        //    MestoZiveenje = mestoZiveenje;
        //}
    }
}