namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
                {
                    new Category // Id = 1
                    {
                        Name = "Hair Salons",
                        Description = "Hair salons come in a variety of shapes and sizes. Whether you prefer to splurge on regular hair appointments or like to chop and change to suit your location and your budget, one thing is for certain - we all need a good trim every so often and a hair salon is the place to do it.",
                        ImageUrl = GlobalConstants.Images.Hair,
                    },           
                };

            // Need them in particular order
            foreach (var category in categories)
            {
                await dbContext.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
