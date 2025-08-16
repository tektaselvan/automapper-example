namespace automapper_example.Models
{
    public class User
    {
        public int Id { get; set; }              // DB alanı gibi düşünebilirsin
        public string FullName { get; set; }     // Ekranda göstereceğiz
        public string Email { get; set; }        // Ekranda göstereceğiz
        public string Password { get; set; }     // DTO'ya gitmeyecek
    }
}
