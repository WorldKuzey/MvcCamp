using EntityLayer2.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayre.Concrete
{
     public class Context:DbContext
    {
        //Proportyleri Sql e yansıtma işlemi
        //Context sınıfı içerisimnde tanımlanacak olan
        //proportyler birer tablo ismi olarak karşılık bulucak SQL'de

        public DbSet<About> Abouts { get; set; }//About'u burda kullanamzsın çünkü about başka bir katmanda
                                                    //başka bir katmanın metotlarını,proportylerini
                                                    //sınıflarını kullanmak istiyosan o katmanı buraya
                                                    //referans olarak ekliyeceksin
                                                    //refans eklemek istersen ilgili referans için ekliceğin
                                                    //kısımdaki referansa sağ tık yap add referanc de ve oradan
                                                    //projeyi seç ve eklemek istediğin katmanı ekleyebilirsin :D
                                                    //pillur'u layz denen olayda oluşturduğumuz proportydeki 
                                                    //sol kısım sınıf sağındaki kısım sql deki tablonun ismidir
                                                    //(s takılı olan kısım)
        public DbSet<Category>     /*Tablo İsmi*/ Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }


       



    }
}
