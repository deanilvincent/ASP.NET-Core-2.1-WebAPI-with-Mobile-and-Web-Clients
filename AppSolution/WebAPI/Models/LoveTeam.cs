using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class LoveTeam
    {
       [Key] public int LoveTeamId { get; set; }

        public string NameOfBoy { get; set; }

        public string NameOfGirl { get; set; }

        public DateTime AnniversaryDate { get; set; }
    }
}
