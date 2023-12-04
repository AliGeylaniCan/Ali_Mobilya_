using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder) 
        {
            builder.Entity<Product>().HasData(
                new Product(){ProductId=1,Name="Ürün 1",Url="urun-1",Price=8000,ImageUrl="calisma1.jpg",Description="Harika", IsApproved=true},
                new Product(){ProductId=2,Name="Ürün 2",Url="urun-2",Price=11000,ImageUrl="calisma2.jpg",Description="Harika", IsApproved=true},
                new Product(){ProductId=3,Name="Ürün 3",Url="urun-3",Price=14000,ImageUrl="calisma3.jpg",Description="Harika", IsApproved=true},
                new Product(){ProductId=4,Name="Ürün 4",Url="urun-4",Price=15000,ImageUrl="calisma4.jpg",Description="Harika", IsApproved=true},
                new Product(){ProductId=5,Name="Ürün 5",Url="urun-5",Price=16000,ImageUrl="calisma5.jpg",Description="Harika", IsApproved=true}
            );

            builder.Entity<Category>().HasData(
                new Category(){CategoryId=1,Name="Çalışma Odası",Url="calisma-odasi "},
                new Category(){CategoryId=2,Name="Yatak Odası",Url="yatak-odasi"},
                new Category(){CategoryId=3,Name="Yemek Odası",Url="yemek-odasi"},
                new Category(){CategoryId=4,Name="Çocuk Odası",Url="cocuk-odasi"},
                new Category(){CategoryId=5,Name="Oturma Odası",Url="oturma-odasi"},
                new Category(){CategoryId=6,Name="Tv Ünitesi",Url="tv-unitesi"},
                new Category(){CategoryId=7,Name="Mutfak",Url="mutfak"},
                new Category(){CategoryId=8,Name="Antre",Url="antre"}
            );

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory(){ProductId=1,CategoryId=1},          
                new ProductCategory(){ProductId=2,CategoryId=1},          
                new ProductCategory(){ProductId=3,CategoryId=1},          
                new ProductCategory(){ProductId=4,CategoryId=1},          
                new ProductCategory(){ProductId=5,CategoryId=1}                          
           );
        }
    }
}