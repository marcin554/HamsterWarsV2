using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.API.Models;

namespace Domain.API.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        {

        }


        public virtual DbSet<Hamster> Hamsters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hamster>().HasData(
                new Hamster { HamsterId = 1, HamsterName = "Pinokio", HamsterAge = 2, FavFood = "Seeds", Loves = "Running", ImgName = "hamster-1.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 2, HamsterName = "Chrome", HamsterAge = 2, FavFood = "Carrot", Loves = "Jumping", ImgName = "hamster-2.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 3, HamsterName = "Firefox", HamsterAge = 1, FavFood = "Cucumber", Loves = "Eating", ImgName = "hamster-3.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 4, HamsterName = "Safari", HamsterAge = 3, FavFood = "Tomato", Loves = "Wheel", ImgName = "hamster-4.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 5, HamsterName = "Opera", HamsterAge = 2, FavFood = "Seed sticks", Loves = "Running Away", ImgName = "hamster-5.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 6, HamsterName = "Zebra", HamsterAge = 2, FavFood = "Honey", Loves = "Sleep", ImgName = "hamster-6.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 7, HamsterName = "Rabbit", HamsterAge = 2, FavFood = "Dirt", Loves = "Dreaming", ImgName = "hamster-7.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 8, HamsterName = "Elephant", HamsterAge = 4, FavFood = "Kefir", Loves = "Pats", ImgName = "hamster-8.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 9, HamsterName = "Fly", HamsterAge = 3, FavFood = "Milk", Loves = "Walking", ImgName = "hamster-9.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 10, HamsterName = "Horse", HamsterAge = 1, FavFood = "Spaghetti", Loves = "Laying", ImgName = "hamster-10.jpg", Wins = 0, Losses = 0, Games = 0 },

                new Hamster { HamsterId = 11, HamsterName = "Pinokio", HamsterAge = 2, FavFood = "Seeds", Loves = "Running", ImgName = "hamster-11.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 12, HamsterName = "Chrome", HamsterAge = 2, FavFood = "Carrot", Loves = "Jumping", ImgName = "hamster-12.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 13, HamsterName = "Firefox", HamsterAge = 1, FavFood = "Cucumber", Loves = "Eating", ImgName = "hamster-13.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 14, HamsterName = "Safari", HamsterAge = 3, FavFood = "Tomato", Loves = "Wheel", ImgName = "hamster-14.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 15, HamsterName = "Opera", HamsterAge = 2, FavFood = "Seed sticks", Loves = "Running Away", ImgName = "hamster-15.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 16, HamsterName = "Zebra", HamsterAge = 2, FavFood = "Honey", Loves = "Sleep", ImgName = "hamster-16.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 17, HamsterName = "Rabbit", HamsterAge = 2, FavFood = "Dirt", Loves = "Dreaming", ImgName = "hamster-17.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 18, HamsterName = "Elephant", HamsterAge = 4, FavFood = "Kefir", Loves = "Pats", ImgName = "hamster-18.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 19, HamsterName = "Fly", HamsterAge = 3, FavFood = "Milk", Loves = "Walking", ImgName = "hamster-19.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 20, HamsterName = "Horse", HamsterAge = 1, FavFood = "Spaghetti", Loves = "Laying", ImgName = "hamster-20.jpg", Wins = 0, Losses = 0, Games = 0 },

                new Hamster { HamsterId = 21, HamsterName = "Pinokio", HamsterAge = 2, FavFood = "Seeds", Loves = "Running", ImgName = "hamster-21.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 22, HamsterName = "Chrome", HamsterAge = 2, FavFood = "Carrot", Loves = "Jumping", ImgName = "hamster-22.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 23, HamsterName = "Firefox", HamsterAge = 1, FavFood = "Cucumber", Loves = "Eating", ImgName = "hamster-23.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 24, HamsterName = "Safari", HamsterAge = 3, FavFood = "Tomato", Loves = "Wheel", ImgName = "hamster-24.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 25, HamsterName = "Opera", HamsterAge = 2, FavFood = "Seed sticks", Loves = "Running Away", ImgName = "hamster-25.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 26, HamsterName = "Zebra", HamsterAge = 2, FavFood = "Honey", Loves = "Sleep", ImgName = "hamster-26.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 27, HamsterName = "Rabbit", HamsterAge = 2, FavFood = "Dirt", Loves = "Dreaming", ImgName = "hamster-27.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 28, HamsterName = "Elephant", HamsterAge = 4, FavFood = "Kefir", Loves = "Pats", ImgName = "hamster-28.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 29, HamsterName = "Fly", HamsterAge = 3, FavFood = "Milk", Loves = "Walking", ImgName = "hamster-29.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 30, HamsterName = "Horse", HamsterAge = 1, FavFood = "Spaghetti", Loves = "Laying", ImgName = "hamster-30.jpg", Wins = 0, Losses = 0, Games = 0 },


                new Hamster { HamsterId = 31, HamsterName = "Pinokio", HamsterAge = 2, FavFood = "Seeds", Loves = "Running", ImgName = "hamster-31.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 32, HamsterName = "Chrome", HamsterAge = 2, FavFood = "Carrot", Loves = "Jumping", ImgName = "hamster-32.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 33, HamsterName = "Firefox", HamsterAge = 1, FavFood = "Cucumber", Loves = "Eating", ImgName = "hamster-33.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 34, HamsterName = "Safari", HamsterAge = 3, FavFood = "Tomato", Loves = "Wheel", ImgName = "hamster-34.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 35, HamsterName = "Opera", HamsterAge = 2, FavFood = "Seed sticks", Loves = "Running Away", ImgName = "hamster-35.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 36, HamsterName = "Zebra", HamsterAge = 2, FavFood = "Honey", Loves = "Sleep", ImgName = "hamster-36.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 37, HamsterName = "Rabbit", HamsterAge = 2, FavFood = "Dirt", Loves = "Dreaming", ImgName = "hamster-37.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 38, HamsterName = "Elephant", HamsterAge = 4, FavFood = "Kefir", Loves = "Pats", ImgName = "hamster-38.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 39, HamsterName = "Fly", HamsterAge = 3, FavFood = "Milk", Loves = "Walking", ImgName = "hamster-39.jpg", Wins = 0, Losses = 0, Games = 0 },
                new Hamster { HamsterId = 40, HamsterName = "Abaddo", HamsterAge = 1, FavFood = "Spaghetti", Loves = "Laying", ImgName = "hamster-40.jpg", Wins = 0, Losses = 0, Games = 0 }


                );
        }

    }
}
