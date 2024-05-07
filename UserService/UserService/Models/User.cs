namespace UserService.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string Phone { get; set; }
        public class UserViewModel : User
        {
            public string NameSearch { get; set; }
        }
    }
}
