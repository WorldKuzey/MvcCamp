using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayre.Abstract
{
    public interface IRepository<T>
    {
        //BÜTÜN TABLOLAR İÇİN AYRI AYRI TANIMLAMA YAPMAK DRY İLKESİNE
        //AYKIRI O YUZDEN ORTAK Bİ İNTERFACE ÜZERİNDEN BU İŞİ YAPALIM

        ////CRUD İŞLEMLERİNİ methot olarak tanımlıcaz
        ////C--->lİSTELEME
        ////R--->Okuma
        ////U---> Güncelleme
        ////D---> Silme
     

        //Listeleme İçin
        List<T> List(T p);

        ////Ekleme İçin
        void Insert(T p);

        ////Güncelleme
        void Update (T p);

        ////Silme
        void Delete(T p);   

        //Filtreleme
        List<T> List(Expression<Func<T,bool>>filter);


       

 

    }
}
