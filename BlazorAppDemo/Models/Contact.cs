namespace BlazorAppDemo.Models
{
    [Serializable]
    public class Contact
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string GetFullName() => this.FirstName + " " + this.LastName;
        public override string ToString() => $"Id: {FirstName}\r\nName: {LastName}\r\nAge: {Email}";
    }
}
