using LINQ.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace LINQ.Homework
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }
        static void Main(string[] args)
        {
            Init();// this method fills the arrays above with data


            // - print the mass of the earth on July 1895 XD
            /*
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░░
                ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░
                ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒███░░░░
                ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░
                ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▄██▄▒▒▒▒▄██▄▒▒▒███░
                ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒██
                ░░░█████████████▒▒▒▒▀██▀▒▒▒▒▀██▀▒▒▒▒▒██
                ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒██
                ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒██▒▒▒▒██
                ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒██
                █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒███████▒▒▒▒▒▒▒██
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░
                ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░
                ░██▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░
                ░░████████████░░░████████████████░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░▄█████▄░▄███████▄░▄███████▄░██████▄░░
                ░░██▒▒▒▒█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░██▒▒▒▒▒░██▒▒▒▒▒██░██▒▒▒▒▒██░██▒▒▒██░░
                ░░██▒▒▒▀█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░▀█████▀░▀███████▀░▀███████▀░██████▀░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░▄█████░██▒▒▒▒██▀░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▀▒▒▒░██▒▒▒██░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▒▒▒▒░█████▀░░░░░░░
                ░░░░██▒▒▒▒░██▄▒▄██░██▄▒▒▒░██▒▒▒██░░░░░░
                ░░░░▀█████░▀█████▀░▀█████░██▒▒▒▒██▄░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            */

            // QUERIES!
            foreach (Artist artist in Artists)
            {
                foreach (Album album in artist.Albums)
                    Console.WriteLine($"{artist.FullName}, {artist.Albums.Count} {album.Name}");

            }
            Console.WriteLine("---------------------------------");
            Albums.ForEach(album => Console.WriteLine($"{album.Name}, {album.Genre}, {album.Year}, {album.Songs.Count}"));
            Console.WriteLine("---------------------------------");
            foreach (Album album in Albums)
            {
                foreach (Song song in album.Songs)
                {
                    Console.WriteLine($"{album.Name}, {song.Name}, {song.Duration}");
                }
            }
            Console.WriteLine("---------------------------------");


            // - how many Songs start with the letter 'a' (case insensitive)

            var songsStartWithA = from song in Songs
                                  where song.Name.StartsWith('a') || song.Name.StartsWith('A')
                                  select song;
                                  
            Console.WriteLine($"{songsStartWithA.ToList().Count} songs start(s) with A");
            Console.WriteLine("---------------------------------");


            // - how many artists end with letter 'a' (case insensitive)

            var artistEndWithA = from artist in Artists
                                 where artist.FullName.EndsWith('a') || artist.FullName.EndsWith('A')
                                 select artist;

            Console.WriteLine($"{artistEndWithA.ToList().Count} artist end(s) with A");
            //artistEndWithA.ToList().ForEach(artist => Console.WriteLine(artist.FullName));
            Console.WriteLine("---------------------------------");


            // - whats the name of the song with longest duration

            var longestSong = from song in Songs
                              orderby song.Duration
                              select song.Name;
           
            Console.WriteLine($"The name of the longet song is {longestSong.LastOrDefault()}");
            Console.WriteLine("---------------------------------");


            // - whats the total Duration of all Songs

            var totalDuration = from song in Songs
                                select song.Duration;

            Console.WriteLine($"The total duration of all songs is {totalDuration.ToList().Sum()} seconds");
            Console.WriteLine("---------------------------------");


            // - how many albums have Songs longer than 300 seconds

            var albumsWithSongOver300 = from album in Albums
                                        from song in album.Songs
                                        where song.Duration > 300
                                        select album;

            Console.WriteLine($"{albumsWithSongOver300.Distinct().ToList().Count} album have(has) song(s) longer than 300 seconds");
            //albumsWithSongOver300.ToList().ForEach(album => Console.WriteLine(album.Name));
            Console.WriteLine("---------------------------------");


            // - print the names of the artists(separated with "--"), that have more than one album of PopRock genre

            var artistsWithPoprockAlbum = from artist in Artists
                                          from album in artist.Albums
                                          where album.Genre == Genre.PopRock
                                          select artist;

            var moreThenOne = from artist in artistsWithPoprockAlbum.Distinct().ToList()
                              where artist.Albums.Count > 1
                              select artist.FullName;
            Console.WriteLine("These artists have more than one album of PopRock genre:");
            moreThenOne.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------------");


            // - print the name of the album that has highest Average duration of a song

            var albumSongsHigherAverage = from album in Albums
                                          orderby album.Songs.ToList().Average(song => song.Duration)
                                          select album.Name;

            Console.WriteLine($"The name of the album that has highest Average duration of a song is {albumSongsHigherAverage.LastOrDefault()}");
            Console.WriteLine("---------------------------------");


            // - how many characters has the song that has the shortest Duration

            var shortestSongChars = from song in Songs
                                    orderby song.Duration
                                    select song;

            Console.WriteLine($"The shortest song has {shortestSongChars.ToList().FirstOrDefault().Name.Length} characters");
            Console.WriteLine("---------------------------------");


            // - print the name and the genre of the album that has most songs

            var albumWithMostSongs = from album in Albums
                                     orderby album.Songs.Count
                                     select album;
           
            Console.WriteLine($"The album that has most songs is {albumWithMostSongs.LastOrDefault().Name}," +
                $" genre: {albumWithMostSongs.LastOrDefault().Genre}");
            Console.WriteLine("---------------------------------");


            // - print the name of the artist that has most songs

            var artistWithMostSongs = from artist in Artists
                                      from album in artist.Albums
                                      orderby artist.Albums.ToList().Sum(album => album.Songs.Count)
                                      select artist.FullName;

            Console.WriteLine($"{artistWithMostSongs.LastOrDefault()} has most songs");
            Console.WriteLine("---------------------------------");


            // - print the type of the artist(SoloArtist/Band) that has most albums published before year 2000

            var artistWithMostalbumsBefore2000 = from artist in Artists
                                                 from album in artist.Albums
                                                 where album.Year < 2000
                                                 orderby artist.Albums.Count
                                                 select artist;

            Console.WriteLine(artistWithMostalbumsBefore2000.ToList().LastOrDefault().ArtistType);
            Console.WriteLine("---------------------------------");


            // - print the average song duration, of the album that has most songs

            var albumFilterMost = from album in Albums
                                  orderby album.Songs.Count
                                  select album;
            var averageSongDuration = from song in albumFilterMost.LastOrDefault().Songs
                                      select song.Duration;

            Console.WriteLine($"The average song duration of album that has most songs is {averageSongDuration.Average()} seconds");
            Console.WriteLine("---------------------------------");


            // Bonus:
            // - print the longest song duration of the album that has least songs

            var albumFilterLess = from album in Albums
                                  orderby album.Songs.Count
                                  select album;

            int least = albumFilterLess.ToList().FirstOrDefault().Songs.Count;
            var filteredAlbums = from album in albumFilterLess
                                 where album.Songs.Count == least
                                 select album;

            var longestSongDur = from album in filteredAlbums
                                 from song in album.Songs
                                 orderby song.Duration
                                 select song.Duration;

            Console.WriteLine($"The longest song duration in the album that has least songs is {longestSongDur.LastOrDefault()} seconds");
            Console.WriteLine("---------------------------------");


            // - print the name of the album that has most songs that contain letter 'a' in the name

            var mostSongsThatContainA = from album in Albums
                                         from song in album.Songs
                                         where song.Name.Contains('a')
                                         group album by album.Name;

            var albumName = from name in mostSongsThatContainA
                            orderby name.Count()
                            select name;

            Console.WriteLine($"The name of the album that has most songs that contain letter 'a' in the name is" +
                $" {albumName.ToList().LastOrDefault().Key}");
            //albumName.ToList().ForEach(album => Console.WriteLine(album.Key));
            Console.WriteLine("---------------------------------");


            // - print the name of the artist that has most songs that end with letter 'd'

            var mostSongsThatEndWithD = from artist in Artists
                                        from album in artist.Albums
                                        from song in album.Songs
                                        where song.Name.EndsWith('d')
                                        group artist by artist.FullName;

            var artistName = from name in mostSongsThatEndWithD
                             orderby name.Count()
                             select name;

            Console.WriteLine($"The name of the artist that has most songs that end with letter 'd' is " +
                $"{artistName.ToList().LastOrDefault().Key}");
            //artistName.ToList().ForEach(artist => Console.WriteLine(artist.Key));


            // ************ Don't mind the structure, focus on the lists declared on the beginning of Program.cs ****************

            // 3, 2, 1.... GO! :)



            Console.ReadLine();
        }



        #region Data Initialization
        private static void Init()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
            FillAlbums();
            FillArtists();
        }
        private static void FillAlbums()
        {
            foreach (var album in Albums)
            {
                album.Songs = Songs.Where(x => x.AlbumId == album.Id).ToList();
            }
        }
        private static void FillArtists()
        {
            foreach (var artist in Artists)
            {
                artist.Albums = Albums.Where(album => album.ArtistId == artist.Id).ToList();
            }
        }
        private static void InitArtists()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));
            Artists.Add(new Artist(3, "Rammstein", ArtistType.Band));
            Artists.Add(new Artist(4, "Coldplay", ArtistType.Band));
            Artists.Add(new Artist(5, "Beyonce", ArtistType.SoloArtist));
        }
        private static void InitAlbums()
        {
            Albums = new List<Album>();
            Albums.Add(new Album(1, 1, "Metallica", Genre.PopRock, 1991));
            Albums.Add(new Album(2, 1, "Ride The Lightning", Genre.PopRock, 1984));
            Albums.Add(new Album(3, 2, "Brave New World", Genre.PopRock, 2000));
            Albums.Add(new Album(4, 2, "Seventh Son of a Seventh Son", Genre.PopRock, 1988));
            Albums.Add(new Album(5, 3, "MUTTER", Genre.PopRock, 2001));
            Albums.Add(new Album(6, 3, "RosenRot", Genre.PopRock, 2005));
            Albums.Add(new Album(7, 4, "Mylo Xyloto", Genre.PopRock, 2011));
            Albums.Add(new Album(8, 5, "Lemonade", Genre.RnB, 2016));
        }
        private static void InitSongs()
        {
            Songs = new List<Song>();

            #region Metallica - Metallica
            Songs.Add(new Song(1, 1, "Enter Sandman", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "Sad But True", 5 * 60 + 24));
            Songs.Add(new Song(3, 1, "Holier Than Thou", 3 * 60 + 47));
            Songs.Add(new Song(4, 1, "The Unforgiven", 6 * 60 + 27));
            Songs.Add(new Song(5, 1, "Wherever I May Roam", 6 * 60 + 44));
            Songs.Add(new Song(6, 1, "Don't Tread on Me", 4 * 60 + 0));
            Songs.Add(new Song(7, 1, "Through the Never", 4 * 60 + 4));
            Songs.Add(new Song(8, 1, "Nothing Else Matters", 6 * 60 + 28));
            Songs.Add(new Song(9, 1, "Of Wolf and Man", 4 * 60 + 16));
            Songs.Add(new Song(10, 1, "The God That Failed", 5 * 60 + 8));
            Songs.Add(new Song(11, 1, "My Friend of Misery", 6 * 60 + 49));
            Songs.Add(new Song(12, 1, "The Struggle Within", 3 * 60 + 53));
            #endregion

            #region Metallica - ride-the-lightning
            Songs.Add(new Song(13, 2, "Fight Fire with Fire", 4 * 60 + 44));
            Songs.Add(new Song(14, 2, "Ride the Lightning", 6 * 60 + 36));
            Songs.Add(new Song(15, 2, "For Whom the Bell Tolls", 5 * 60 + 9));
            Songs.Add(new Song(16, 2, "Fade to Black", 6 * 60 + 57));
            Songs.Add(new Song(17, 2, "Trapped Under Ice", 4 * 60 + 4));
            Songs.Add(new Song(18, 2, "Escape", 4 * 60 + 23));
            Songs.Add(new Song(19, 2, "Creeping Death", 6 * 60 + 36));
            Songs.Add(new Song(20, 2, "The Call of Ktulu", 8 * 60 + 53));
            #endregion

            #region Iron Maiden - Brave New World
            Songs.Add(new Song(21, 3, "The Wicker Man", 4 * 60 + 35));
            Songs.Add(new Song(22, 3, "Ghost of the Navigator", 6 * 60 + 50));
            Songs.Add(new Song(23, 3, "Brave New World", 6 * 60 + 18));
            Songs.Add(new Song(24, 3, "Blood Brothers", 7 * 60 + 14));
            Songs.Add(new Song(25, 3, "The Mercenary", 4 * 60 + 42));
            Songs.Add(new Song(26, 3, "Dream of Mirrors", 9 * 60 + 21));
            Songs.Add(new Song(27, 3, "The Fallen Angel", 4 * 60 + 0));
            Songs.Add(new Song(28, 3, "The Nomad", 9 * 60 + 5));
            Songs.Add(new Song(29, 3, "Out of the Silent Planet", 6 * 60 + 25));
            Songs.Add(new Song(30, 3, "The Thin Line Between Love and Hate", 8 * 60 + 27));

            #endregion

            #region Iron Maiden - Seventh Son of a Seventh Son
            Songs.Add(new Song(31, 4, "Moonchild", 5 * 60 + 41));
            Songs.Add(new Song(32, 4, "Infinite Dreams", 6 * 60 + 9));
            Songs.Add(new Song(33, 4, "Can I Play with Madness", 3 * 60 + 31));
            Songs.Add(new Song(34, 4, "The Evil That Men Do", 4 * 60 + 34));
            Songs.Add(new Song(35, 4, "Seventh Son of a Seventh Son", 9 * 60 + 53));
            Songs.Add(new Song(36, 4, "The Prophecy", 5 * 60 + 6));
            Songs.Add(new Song(37, 4, "The Clairvoyant", 4 * 60 + 27));
            Songs.Add(new Song(38, 4, "Only the Good Die Young", 4 * 60 + 42));
            #endregion

            #region Rammstein - MUTTER
            Songs.Add(new Song(39, 5, "Mein Herz Brennt", 4 * 60 + 39));
            Songs.Add(new Song(40, 5, "Mein Herz Brennt", 3 * 60 + 36));
            Songs.Add(new Song(41, 5, "Sonne", 4 * 60 + 32));
            Songs.Add(new Song(42, 5, "Ich Will", 3 * 60 + 37));
            Songs.Add(new Song(43, 5, "Feuer Frei!", 3 * 60 + 11));
            Songs.Add(new Song(44, 5, "Mutter", 4 * 60 + 32));
            Songs.Add(new Song(45, 5, "Spieluhr", 4 * 60 + 46));
            Songs.Add(new Song(46, 5, "Zwitter", 4 * 60 + 17));
            Songs.Add(new Song(47, 5, "Rein Raus", 3 * 60 + 9));
            Songs.Add(new Song(48, 5, "Adios", 3 * 60 + 49));
            Songs.Add(new Song(49, 5, "Nebel", 4 * 60 + 54));
            #endregion

            #region Rammstein - Rosenrot
            Songs.Add(new Song(50, 6, "Benzin", 3 * 60 + 46));
            Songs.Add(new Song(51, 6, "Mann Gegen Mann", 3 * 60 + 50));
            Songs.Add(new Song(52, 6, "Rosenrot", 3 * 60 + 54));
            Songs.Add(new Song(53, 6, "Spring", 5 * 60 + 24));
            Songs.Add(new Song(54, 6, "Wo Bist Du", 3 * 60 + 55));
            Songs.Add(new Song(55, 6, "Stirb Nicht Vor Mir(Don't Die Before I Do)", 4 * 60 + 5));
            Songs.Add(new Song(56, 6, "Zerstören", 5 * 60 + 28));
            Songs.Add(new Song(57, 6, "Hilf Mir", 4 * 60 + 43));
            Songs.Add(new Song(58, 6, "Te Quiero Puta!", 3 * 60 + 55));
            Songs.Add(new Song(59, 6, "Feuer und Wasser", 5 * 60 + 17));
            Songs.Add(new Song(60, 6, "Ein Lied", 3 * 60 + 43));
            #endregion

            #region Coldplay - Mylo Xyloto
            Songs.Add(new Song(61, 7, "Mylo Xyloto", 0 * 60 + 43));
            Songs.Add(new Song(62, 7, "Hurts Like Heaven", 4 * 60 + 2));
            Songs.Add(new Song(63, 7, "Paradise", 4 * 60 + 37));
            Songs.Add(new Song(64, 7, "Charlie Brown", 4 * 60 + 45));
            Songs.Add(new Song(65, 7, "Us Against the World", 3 * 60 + 59));
            Songs.Add(new Song(66, 7, "M.M.I.X.", 0 * 60 + 48));
            Songs.Add(new Song(67, 7, "Every Teardrop Is a Waterfall", 4 * 60 + 0));
            Songs.Add(new Song(68, 7, "Major Minus", 3 * 60 + 30));
            Songs.Add(new Song(69, 7, "U.F.O.", 2 * 60 + 17));
            Songs.Add(new Song(70, 7, "Princess of China", 3 * 60 + 59));
            Songs.Add(new Song(71, 7, "Up in Flames", 3 * 60 + 13));
            Songs.Add(new Song(72, 7, "A Hopeful Transmission", 0 * 60 + 33));
            Songs.Add(new Song(73, 7, "Don't Let It Break Your Heart", 3 * 60 + 53));
            Songs.Add(new Song(74, 7, "Up with the Birds", 3 * 60 + 47));
            #endregion

            #region Beyonce - Lemonade
            Songs.Add(new Song(75, 8, "", 3 * 60 + 15));
            Songs.Add(new Song(76, 8, "", 3 * 60 + 41));
            Songs.Add(new Song(77, 8, "", 3 * 60 + 53));
            Songs.Add(new Song(78, 8, "", 3 * 60 + 52));
            Songs.Add(new Song(79, 8, "", 4 * 60 + 20));
            Songs.Add(new Song(80, 8, "", 4 * 60 + 47));
            Songs.Add(new Song(81, 8, "", 3 * 60 + 57));
            Songs.Add(new Song(82, 8, "", 3 * 60 + 2));
            Songs.Add(new Song(83, 8, "", 1 * 60 + 19));
            Songs.Add(new Song(84, 8, "", 4 * 60 + 49));
            Songs.Add(new Song(85, 8, "", 5 * 60 + 21));
            Songs.Add(new Song(86, 8, "", 3 * 60 + 25));

            #endregion

        }
        #endregion

    }
}
