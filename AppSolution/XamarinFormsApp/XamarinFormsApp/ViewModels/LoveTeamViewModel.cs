using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsApp.Models;
using XamarinFormsApp.RestClient;

namespace XamarinFormsApp.ViewModels
{
    public class LoveTeamViewModel : INotifyPropertyChanged
    {
        private LoveTeamService loveTeamService = new LoveTeamService();
        private List<LoveTeam> loveTeams;

        public List<LoveTeam> LoveTeams
        {
            get => loveTeams;
            set
            {
                loveTeams = value;
                OnPropertyChanged();
            }
        }

        public LoveTeamViewModel()
        {
            Task.Run(async () => { await InitializeGetStudents(); });
        }

        public Command Refresh
        {
            get
            {
                return new Command(async () => { await InitializeGetStudents(); });
            }
        }

        private async Task InitializeGetStudents()
        {
            LoveTeams = await loveTeamService.Get();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
