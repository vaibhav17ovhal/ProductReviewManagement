using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewManagement
{
    public class ProductManagement
    {
        //UC2
        public void TopRecords(List<ProductReview> listReview)
        {
            var Top3Records = (from re in listReview
                               orderby re.Rating descending
                               select re).Take(3);

            foreach (var data in Top3Records)
            {
                Console.WriteLine($"ProductId ---> {data.ProductId}  , UserId ---> {data.UserID}  , Rating ---> {data.Rating}  , Review ---> {data.Review}  , IsLike ---> {data.IsLike}");
            }
        }

        //UC3
        public void SelectedRecords(List<ProductReview> listReview)
        {
            var result = (from re in listReview
                          where (re.ProductId == 1 || re.ProductId == 4 || re.ProductId == 9)
                          && re.Rating > 3
                          select re);

            foreach (var data in result)
            {
                Console.WriteLine($"ProductId ---> {data.ProductId}  , UserId ---> {data.UserID}  , Rating ---> {data.Rating}  , Review ---> {data.Review}  , IsLike ---> {data.IsLike}");
            }
        }

        //UC4
        public void CountProductIDReview(List<ProductReview> re)
        {
            var result = re.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var data in result)
            {
                Console.WriteLine($"ProductId ---> {data.ProductId}  , Count ---> {data.Count}");
            }
        }

        //UC5
        public void RetrieveProductIDAndReview(List<ProductReview> data)
        {
            var result2 = data.Select(data => new { data.ProductId, data.Review });

            foreach (var item in result2)
            {
                Console.WriteLine($"ProductID ---> {item.ProductId}, Review ---> {item.Review}");
            }
        }

        //UC6
        public void SkipTop5(List<ProductReview> data)
        {
            var result3 = data.Skip(5);

            foreach (var num in result3)
            {
                Console.WriteLine($"ProductId ---> {num.ProductId}  , UserId ---> {num.UserID}  , Rating ---> {num.Rating}  , " +
                    $"Review ---> {num.Review}  , IsLike ---> {num.IsLike}");
            }
        }

        //UC7
        public void RetrieveProductIDAndReview2(List<ProductReview> data)
        {
            var result2 = data.Select(data => new { data.ProductId, data.Review });

            foreach (var item in result2)
            {
                Console.WriteLine($"ProductID ---> {item.ProductId}, Review ---> {item.Review}");
            }
        }
    }
}
