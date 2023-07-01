using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class SampleForm
    {
        private SampleFormModel sample = new SampleFormModel();

        private CascadeModel cascade = new CascadeModel();
        private Dictionary<int, string> mediaTypes = new Dictionary<int, string>();
        private Dictionary<int, string> subTypes = new Dictionary<int, string>();

        public SampleForm()
        {
            mediaTypes.Add(1, "Movies");
            mediaTypes.Add(2, "TV Shows");
            mediaTypes.Add(3, "Books");
        }

        private void HandleSecondDropDownChange(ChangeEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                return;
            }

            cascade.SecondId = int.Parse(e.Value.ToString());
        }

        private async Task HandleFirstDropDownChange(ChangeEventArgs e)
        {
            await JSRuntime.InvokeAsync<object>("ResetSecondDropDown", new object[0]);
            
            cascade.SecondId = 0;
            subTypes = new Dictionary<int, string>();

            if (string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                cascade.FirstId = 0;
                return;
            }

            cascade.FirstId = int.Parse(e.Value.ToString());
            cascade.SecondId = 0;

            switch (cascade.FirstId)
            {
                case 1:
                    subTypes = new Dictionary<int, string>();
                    subTypes.Add(1, "Top Gun");
                    subTypes.Add(2, "Fellowship of the Ring");
                    subTypes.Add(3, "Ghost in the Shell");
                    break;
                case 2:
                    subTypes = new Dictionary<int, string>();
                    subTypes.Add(4, "The Last Airbender");
                    subTypes.Add(5, "One Punch Man");
                    subTypes.Add(6, "Cowboy Bebop");
                    break;
                case 3:
                    subTypes = new Dictionary<int, string>();
                    subTypes.Add(7, "Lord of the Flies");
                    subTypes.Add(8, "The Great Gatsby");
                    subTypes.Add(9, "Grapes of Wrath");
                    break;
                default:
                    subTypes = new Dictionary<int, string>();
                    break;
            }

            await JSRuntime.InvokeAsync<object>("ResetSecondDropDown", new object[0]);
        }
    }    
};

