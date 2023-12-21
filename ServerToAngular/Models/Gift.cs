using System.Text.Json.Serialization;

namespace ServerToAngular.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Donor { get; set; }
        public int Cost { get; set; } = 10;

        public string Description { get; set; }

        public string Image { get; set; }
        public int Quentity { get; set; } = 1;

        public Gift(int id, string name, string donor, int cost,string image,string description, int quentity)
        {
            Id = id;
            Name = name;
            Donor = donor;
            Cost = cost;
            Description = description;
            Image = image;
            Quentity = quentity;
        }
    }
}
