using Microsoft.AspNetCore.Authorization.Policy;
using MyFirstMCPApp.Models;
using System.Linq;
using System.Text;

namespace MyFirstMCPApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"F:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFilExists = System.IO.File.Exists(fName);
            if (isFilExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }




                }
            }
            return list;





        }
        private static Author StringToAuthor(String[] data, Author author)



        {



            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.RoyaltyCompany = data[2];
            author.NumberofBooks = float.Parse(data[3]);
            author.AuthorDob = DateOnly.Parse(data[4]);
            return author;
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fName = @"F:\temp\Author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.AuthorID!= pAuthor.AuthorID)
                        strAuthor = $"{author.AuthorID},{author.AuthorName},{author.RoyaltyCompany},{author.NumberofBooks},{author.AuthorDob}";
                    else
                        strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.RoyaltyCompany},{pAuthor.NumberofBooks}{pAuthor.AuthorDob}";
                    sw.WriteLine(strAuthor);
                }
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"F:\temp\Author.csv";
            Dictionary<int,Author>list = AuthorRepository.GetAuthorDictionary();
            StringBuilder strAuthor = new StringBuilder(list.Count+100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != id)
                {
                    strAuthor.Append($"{author.AuthorID},{author.AuthorName},{author.RoyaltyCompany},{author.NumberofBooks}," + $"{author.AuthorDob}{Environment.NewLine}");
                   
                }
            }
            
        }
        public static Author FindAuthorById(int id)
        {

            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if(list!=null)
            {
                author=list.FirstOrDefault(x=>(x.Key==id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"F:\temp\Author.csv";
            string strAuthor=$"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.RoyaltyCompany},{pAuthor.NumberofBooks}{pAuthor.AuthorDob}";
            using(StreamWriter sw=new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
    }
 }

        
    
