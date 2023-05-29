namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Salons.Any())
            {
                return;
            }

            var salons = new Salon[]
                {
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Angel Hair Salon",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Rosehill Crescent 93",
                        ImageUrl = GlobalConstants.Images.Hair3,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                };

            await dbContext.AddRangeAsync(salons);
        }
    }
}
