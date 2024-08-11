using PracticeIMDB;

class Program
{
    public static void Main(string[] args)
    {
        //
        List<Movies> movieList = new List<Movies>();
        string continueInput;
        do
        {
            Console.WriteLine("Lütfen Flim Adını Giriniz");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen IMDB Puanı Giriniz");
            double point;
            while (!double.TryParse(Console.ReadLine(), out point))
            {
                Console.WriteLine("Lütfen Geçerli Bir puan Giriniz");
            }
            // Yeni bir Movie nesnesi oluştur ve listeye ekle
            Movies movie = new Movies(name, point);
            movieList.Add(movie);

            Console.WriteLine("Başka Bir Flim Eklemek İstermisiniz Evet/Hayır");
            continueInput = Console.ReadLine().ToLower();
        } while (continueInput == "evet");
            
        //Listele
        foreach(var movies in movieList)
        {
            movies.DisplayMovie();
        }

        // IMDB Puanı 4 ile 9 Arasında Olan Filmleri Listele
        //Burada Where Yöntemini Kullanarak 4 ile 9 arası olan flimleri alıyoruz ve geçici olarak filteredMovies aktarıyoruz
        Console.WriteLine("\nIMDB Puanı 4 ile 9 Arasında Olan Filmler:");
        var filteredMovies = movieList.Where(m => m.Point >= 4 && m.Point <= 9);
        foreach (var movie in filteredMovies)
        {
            movie.DisplayMovie();
        }

        // İsmi 'A' ile Başlayan Filmler ve IMDB Puanları
        //Where Yöntemini Kullanarak A ile başlayan flimleri filtreliyoruz
        //, StringComparison.OrdinalIgnoreCase büyük Küçük harf duyarlılığını kaldırır
        //StartsWith Başlangıcı kontrol etmek için Kullandığımız stringler için bir methoddur
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler ve IMDB Puanları:");
        var moviesStartingWithA = movieList.Where(m => m.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var movie in moviesStartingWithA)
        {
            movie.DisplayMovie();
        }

    }
}