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

            //UC8
            // Create a new DataTable
            DataTable dataTable = new DataTable("ProductReviews");

            // Add columns to the DataTable
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));

            // Add rows to the DataTable
            dataTable.Rows.Add(1, 101, 4.5, "Great product!", true);
            dataTable.Rows.Add(2, 102, 4.1, "Good value for money.", true);
            dataTable.Rows.Add(1, 103, 2.2, "Not satisfied with the quality.", false);
            dataTable.Rows.Add(3, 104, 3.3, "Average product!", true);
            dataTable.Rows.Add(2, 105, 4.2, "Good value for money.", true);
            dataTable.Rows.Add(1, 106, 3.9, "Good product.", true);
            dataTable.Rows.Add(1, 107, 1.5, "Bad product!", false);
            dataTable.Rows.Add(2, 108, 3.5, "Good Product but not worthy.", true);
            dataTable.Rows.Add(2, 109, 3.0, "Can do better.", false);
            dataTable.Rows.Add(2, 110, 4.5, "Great product!", true);
            dataTable.Rows.Add(2, 111, 4.0, "Good value for money.", true);
            dataTable.Rows.Add(3, 112, 2.3, "Not satisfied with the quality.", false);

            // Display the DataTable contents
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("ProductID: " + row["ProductID"]);
                Console.WriteLine("UserID: " + row["UserID"]);
                Console.WriteLine("Rating: " + row["Rating"]);
                Console.WriteLine("Review: " + row["Review"]);
                Console.WriteLine("IsLike: " + row["IsLike"]);
                Console.WriteLine();
            }
        }
    }
}

