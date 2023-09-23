using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class MovieDbRepository
    {
        public static List<Movie> GetMovieList()
        {
            List<Movie> list = new List<Movie>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectMoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select*from Movie";

                selectMoviecmd.CommandText = selectAllMovie;
                SqlDataReader moviedr = selectMoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie();


                    movie.ID = moviedr.GetInt32(0);
                    movie.Title = moviedr.GetString(1);
                    movie.Language = moviedr.GetString(2);
                    movie.Hero = moviedr.GetString(3);
                    movie.Director = moviedr.GetString(4);
                    movie.MusicDirector = moviedr.GetString(5);
                    movie.ReleaseDate = moviedr.GetDateTime(6);
                    movie.Cost =moviedr.GetInt32(7);
                    movie.Collection =moviedr.GetInt32(8);
                    movie.Review = moviedr.GetString(9);

                    
                    list.Add(movie);
                }
            }
            return list;
        }

        public static Movie GetMovieById(int id)
        {
            Movie moviefound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectionmovie = "Select*from Movie where ID=@id";   //Parameter
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectionmovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    moviefound = new Movie
                    {

                        ID = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt32(7),
                        Collection = moviedr.GetInt32(8),
                        Review = moviedr.GetString(9)
                    };
                }
                return moviefound;
            }
        }
        public static int AddNewMovie(Movie newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movie values( @id,@title,@language,@hero,@director,@musicdirector,@releasedate,@cost,@collection,@review )";
                insertMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = newMovie.ID;
                insertMoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@musicdirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = newMovie.Collection;
                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery();
            }
            return query_result;

        }
        public static int UpdateMovie(Movie modifiedmovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String updateMovieQuery = "Update Movie set title=@title, language=@language, hero=@hero,director=@director,musicdirector=@musicdirector,cost=@cost,collection=@collection where id=@id";
                updateMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedmovie.ID;
                updateMoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = modifiedmovie.Title;
                updateMoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = modifiedmovie.Language;
                updateMoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = modifiedmovie.Hero;
                updateMoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = modifiedmovie.Director;
                updateMoviecmd.Parameters.Add("@musicdirector", SqlDbType.NVarChar).Value = modifiedmovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = modifiedmovie.Cost;
                updateMoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = modifiedmovie.Collection;
                updateMoviecmd.CommandText = updateMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;


        }
        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from Movie where id=@id";
                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteMoviecmd.CommandText = deleteMovieQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;

        }

    }
}
