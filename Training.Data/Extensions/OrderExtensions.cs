using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderExtensions
    {
        public static DTO.Order ToDTO(this Models.Order o)
        {
            return new DTO.Order
            {
                Id = o.Id.ToString(),
                UserId= o.UserId.ToString(),
                Status=o.ToString(),


                Id = u.Id.ToString(),
                Email = u.Email,
                FullName = u.FullName
            };
        }


    }
}
