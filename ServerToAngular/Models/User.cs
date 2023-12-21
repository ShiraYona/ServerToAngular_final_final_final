namespace ServerToAngular.Models
{
    public class User
    {
        public User(int Id, string UserName, string Password, string CreditCard, List<Gift> Tickets)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Password = Password;
            this.CreditCard = CreditCard;
            this.Tickets = Tickets;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string CreditCard { get; set; }
        
        public List<Gift> Tickets { get; set; } = new List<Gift>();

       

    }
}
