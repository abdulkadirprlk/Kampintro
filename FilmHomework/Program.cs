namespace FilmHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Film film1 = new Film();
            film1.adi = "prestige";
            film1.filmSuresi = "2 sa 15 dk";
            film1.IMDBpuani = 7.6;
            film1.yonetmen = "cristopher nolan";

            Film film2 = new Film();
            film2.adi = "ahlat ağacı";
            film2.filmSuresi = "2 sa 7 dk";
            film2.IMDBpuani = 6.2;
            film2.yonetmen = "nuri bilge ceylan";

            Film film3 = new Film();
            film3.adi = "donuk";
            film3.filmSuresi = "1 sa 57 dk";
            film3.IMDBpuani = 8.9;
            film3.yonetmen = "abdulkadir parlak";

            Film[] Filmlerim = new Film[] { film1, film2, film3 };

            foreach (Film film in Filmlerim)
            {
                Console.WriteLine("ad:" + film.adi + "  süre:" + film.filmSuresi + "  puan:" + film.IMDBpuani + "  yönetmen:" + film.yonetmen);
            }

            for (int i = 0; i < Filmlerim.Length; i++)
            {
                Console.WriteLine("ad:" + Filmlerim[i].adi + "  süre:" + Filmlerim[i].filmSuresi + "  puan:" + Filmlerim[i].IMDBpuani + "  yönetmen:" + Filmlerim[i].yonetmen);
            }
            int a = 0;
            while (a < Filmlerim.Length)
            {
                Console.WriteLine("ad:" + Filmlerim[a].adi + "  süre:" + Filmlerim[a].filmSuresi + "  puan:" + Filmlerim[a].IMDBpuani + "  yönetmen:" + Filmlerim[a].yonetmen);

                a++;
            }
        }
            class Film
        {
            public string filmSuresi { get; set; }

            public double IMDBpuani { get; set; }

            public string yonetmen { get; set; }
            public string adi { get; set; }
        }
    }
}
