using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
    public class FriendViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public Friend FriendModel { get; set; }
        private INavigation Navigation;

        public FriendViewModel(INavigation navigation)
        {
            FriendModel = new Friend();
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public FriendViewModel(INavigation navigation, Friend friend)
        {
            FriendModel = friend;
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public async Task SaveFriend()
        {
            await App.DataBase.SaveFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }

    }
}
