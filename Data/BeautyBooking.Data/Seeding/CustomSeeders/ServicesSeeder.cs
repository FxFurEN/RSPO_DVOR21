namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;

    public class ServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Services.Any())
            {
                return;
            }

            var services = new Service[]
                {
                    // 1. Hairdressers and hair salons
                    new Service
                    {
                        Name = "Стрижка",
                        Description = "Профессиональная стрижка в стиле DVOR21, которая подчеркнет вашу индивидуальность " +
                        "и отличный вкус в выборе прически.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Борода",
                        Description = "Идеальный уход за бородой, который включает в себя стрижку, подравнивание, " +
                        "придание формы и уход за кожей лица.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Борода + Стрижка",
                        Description = "Комплексная услуга, которая включает в себя стрижку в стиле барбершопа и профессиональный " +
                        "уход за бородой.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Детская стрижка",
                        Description = "Профессиональная стрижка для мальчиков до 14 лет, которая подчеркнет их индивидуальность " +
                        "и подходит для любого повода.",
                        CategoryId = 1,
                    },
                };

            // Need them in particular order
            foreach (var service in services)
            {
                await dbContext.AddAsync(service);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
