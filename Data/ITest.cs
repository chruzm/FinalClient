using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface ITest
    {
        Task<MenuObject> GetMenuAsync(int z);

        Task<OrderObject> SendOrderAsync(OrderObject o);
        
        Task<ReviewObject> SendReviewAsync(ReviewObject z);

    }
}