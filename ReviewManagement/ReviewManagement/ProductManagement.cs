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
    }
}
