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
    }
}
