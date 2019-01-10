using System;

namespace TeduShop.Data.Infrastructure
{
    //Khởi tạo các đối tượng entities
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}