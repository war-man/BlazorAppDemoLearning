using BlazorAppDemo.Models;

namespace BlazorAppDemo.Pages
{
    public partial class Index
    {
        private List<string>? name = null;
        private List<Contact>? Contacts = null;
        private Dictionary<string, object> MyTextBoxAttributes = new()
        {
            { "disabled", "disabled" },
            { "placeholder", "New Contact 02" },
            { "type", "text" }
        };
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            Contacts = new()
            {
                new() { FirstName = "John", LastName = "Kevin", Email = "K@gmail.com" },
                new() { FirstName = "John1", LastName = "Kevin1", Email = "K1@gmail.com" },
                new() { FirstName = "John2", LastName = "Kevin2", Email = "K2@gmail.com" }

            };
            await base.OnInitializedAsync();
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            name = new()
            {
                "Base1",
                "Base1",
                "Base1",
                "Base1",
                "Base1",
                "Base1",
            };
        }
        private string username = "john";
        private int TestNum { get; set; } = 1;
        private string TernaryOperator = "Raw";
        private string Getusername() => $"{username} Thomas";
        private void ChangeName() => username = "Peter";
    }
}
