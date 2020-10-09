using System.Collections.Generic;
using BeforeIDie.Models;
using Microsoft.EntityFrameworkCore;

namespace BeforeIDie.Db
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var data = new List<Goal>()
            {
                new Goal(){Id = 1, Title = "Wielki Kanion Kolorado", Localization = "Arizona USA", ImgUrl = "https://goryiludzie.pl/sites/default/files/atoms/image/2016/12/15/1280px-grand_canyon_march_2013.jpg", Description = "przełom rzeki Kolorado w stanie Arizona w USA przez Płaskowyż Kolorado. Za początek kanionu uznaje się Lee's Ferry (niewielka stacja z motelem i przystanią dla łodzi leżąca około 12 km od miejscowości Page), natomiast koniec kanionu leży w rejonie Grand Wash Cliff leżącym około 20 km od początku jeziora Mead[1]. Odległość pomiędzy tymi punktami mierzona nurtem rzeki Kolorado wynosi 446 km[1]. Najgłębszym rejonem Wielkiego Kanionu jest Granite Gorge (Wąwóz Granitowy)[2], w którym najgłębsze miejsce leży poniżej krawędzi o 1857 m (6093 stóp)[3]. Szerokość kanionu waha się od ok. 800 m (pod punktem widokowym Toroweap na North Rim – Północnej Krawędzi) do 29 km w najszerszym miejscu. Jest to największy przełom rzeki na świecie (jednak nie najgłębszy)."},
                new Goal(){Id = 2, Title = "Zorza Polarna", Localization = "Biegun Północny", ImgUrl = "https://cdn.pixabay.com/photo/2018/10/14/20/17/aurora-3747376_1280.jpg", Description = "Na Ziemi zorze występują na wysokich szerokościach geograficznych, głównie za kołami podbiegunowymi, chociaż w sprzyjających warunkach bywają widoczne nawet w okolicach 50. równoleżnika. Zdarza się, że zorze polarne obserwowane są nawet w krajach śródziemnomorskich. Na półkuli północnej zorza jest określana łacińską nazwą Aurora borealis, a południowa zorza polarna nosi nazwę Aurora australis."},
                new Goal(){Id = 3, Title = "Koloseum", Localization = "Rzym, Włochy", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d8/Colosseum_in_Rome-April_2007-1-_copie_2B.jpg", Description = "Amfiteatr Flawiuszów jest najbardziej znanym symbolem Wiecznego Miasta i zarazem jedną z najwspanialszych budowli antycznych, które dotrwały do naszych czasów. Jest on doskonałym świadectwem wielkiego poziomu architektury i budownictwa Imperium Rzymskiego."},
            };
            modelBuilder.Entity<Goal>().HasData(data);
        }

        public DbSet<Goal> GoalItems { get; set; }
        public DbSet<RealizedGoal> RealizedGoalsItems { get; set; }
    }
}