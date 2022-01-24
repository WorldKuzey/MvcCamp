﻿using DataAccesLayre.Concrete.Repostories;
using EntityLayer2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer2.Concrete
{
    public class CategoryManager
    {

        GenericRepository<Category> repo = new GenericRepository<Category>();


        public List<Category> GetAllBl()
        {
            return repo.List();
        }


        public void CategoryAddBl(Category p)
        {
            if(p.CategoryName ==""|| p.CategoryName.Length < 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                //Hata mesajı
            }
            else
            {
                repo.Insert(p);
            }

        }


    }
}