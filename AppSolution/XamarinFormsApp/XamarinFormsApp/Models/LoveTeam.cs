using System;

namespace XamarinFormsApp.Models
{
    public class LoveTeam
    {
        public int LoveTeamId { get; set; }

        public string NameOfBoy { get; set; }

        public string NameOfGirl { get; set; }

        public string LoveTeamName => $"{NameOfBoy} loves {NameOfGirl}";

        public DateTime AnniversaryDate { get; set; }

        public string AnniversaryDetail => $"Anniversary: {AnniversaryDate:MMMM dd, yyyy}";
    }
}
