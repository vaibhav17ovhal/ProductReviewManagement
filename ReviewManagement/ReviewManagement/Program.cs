using System;
using System.Data;
using System.Xml.Linq;

namespace ReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linq query");

            //UC1
            List<ProductReview> review = new List<ProductReview>()
            {
                new ProductReview() {ProductId = 1 , UserID = 1 , Rating = 3.5 , Review = "Fine" , IsLike = true},
                new ProductReview() {ProductId = 2 , UserID = 2 , Rating = 4.5 , Review = "Good" , IsLike = true},
                new ProductReview() {ProductId = 7 , UserID = 3 , Rating = 2.5 , Review = "Bad" , IsLike = false},
                new ProductReview() {ProductId = 4 , UserID = 4 , Rating = 2.1 , Review = "Bad" , IsLike = true},
                new ProductReview() {ProductId = 5 , UserID = 5 , Rating = 4.8 , Review = "Excellent" , IsLike = true},
                new ProductReview() {ProductId = 6 , UserID = 6 , Rating = 4.2 , Review = "Good" , IsLike = true},
                new ProductReview() {ProductId = 7 , UserID = 7 , Rating = 3.8 , Review = "Good" , IsLike = true},
                new ProductReview() {ProductId = 7 , UserID = 8 , Rating = 1.5 , Review = "Bad" , IsLike = false},
                new ProductReview() {ProductId = 9 , UserID = 9 , Rating = 4.2 , Review = "Good" , IsLike = true},
                new ProductReview() {ProductId = 10 , UserID = 10 , Rating = 4.7 , Review = "Excellent" , IsLike = true}
            };
            foreach (var data in review)
            {
                Console.WriteLine($"ProductId ---> {data.ProductId}  , UserId ---> {data.UserID}  , Rating ---> {data.Rating}  , Review ---> {data.Review}  , IsLike ---> {data.IsLike}");
            }
            
            ProductManagement manage = new ProductManagement();
            manage.TopRecords(review);

            Console.WriteLine("\n==========XXX===========\n");

            manage.SelectedRecords(review);

            Console.WriteLine("\n==========XXX===========\n");

            manage.CountProductIDReview(review);

            Console.WriteLine("\n==========XXX===========\n");

            manage.RetrieveProductIDAndReview(review);

            Console.WriteLine("\n==========XXX===========\n");

            manage.SkipTop5(review);

            Console.WriteLine("\n==========XXX===========\n");

            manage.RetrieveProductIDAndReview2(review);
        }
    }
}

