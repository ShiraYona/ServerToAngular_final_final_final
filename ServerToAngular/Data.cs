using ServerToAngular.Models;

namespace ServerToAngular
{
    public class Data
    {
        public static List<Donor> donors = new List<Donor>
        {
            new Donor(1,"Michael","Michael@gmail.com") ,
            new Donor(2,"Rochild","Rochild@gmail.com"),
            new Donor(3,"Moshe","Moshe@gmail.com")

        };

        public static List<Gift> gifts = new List<Gift>
        {
            new Gift(1,"camera",donors[0].Name,30,"camera.png","Quality camera with zoom 5",1) ,
            new Gift(2,"car",donors[1].Name,40,"car.png","CHERRY TIGO company car",1),
            new Gift(3,"Children's trampoline",donors[2].Name,50,"trampoline.png","Children's trampoline radius of 9 meters",1),
            new Gift(4,"Makeup Kit",donors[1].Name,60,"2.png","Yossi Biton's professional makeup kit",1),
            new Gift(10,"vacation",donors[0].Name,30,"vacation.png","Family vacation 2 nights in Beit Khalkia",1) ,
            new Gift(5,"Surprise ",donors[0].Name,30,"Surprise.png","A surprise prize worth NIS 800",1) ,
            new Gift(6,"Photo",donors[0].Name,30,"1.png"," day Photo  free",1) ,
            new Gift(7,"fly",donors[2].Name,30,"fly.png","Free flight to Hungary",1) ,
            new Gift(8,"bed",donors[0].Name,30,"bed.png","A comfortable bed by Lady",1) ,
             new Gift(9,"headphones",donors[2].Name,10,"headphones.png","jbl headphones",1) ,
            //new Gift(11,"car",donors[1].Name,40,"2.png","good car",1),
            //new Gift(12,"house",donors[2].Name,50,"3.png","good house",1),
            //new Gift(13,"gift",donors[1].Name,60,"4.png","good gift",1)
        


        };
        
        public static List<User> users = new List<User>
        {
            new User(1,"Mashe","user1","12345678",gifts),
            new User(2,"Rochild","user2","44444444",gifts),
            new User(3,"Michael","user3","87878787",gifts)
        };
    }
}
