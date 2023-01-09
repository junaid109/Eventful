using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventful.Persistence
{
    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            if (!context.Events.Any())
            {
                context.Events.AddRange(
                    new Domain.EventEntity
                    {
                        Id = "1",
                        Name = "Event 1",
                        Description = "Event 1 Description",
                        Location = "Event 1 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 1 ImageUrl",
                        Url = "Event 1 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "2",
                        Name = "Event 2",
                        Description = "Event 2 Description",
                        Location = "Event 2 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 2 ImageUrl",
                        Url = "Event 2 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "3",
                        Name = "Event 3",
                        Description = "Event 3 Description",
                        Location = "Event 3 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 3 ImageUrl",
                        Url = "Event 3 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "4",
                        Name = "Event 4",
                        Description = "Event 4 Description",
                        Location = "Event 4 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 4 ImageUrl",
                        Url = "Event 4 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "5",
                        Name = "Event 5",
                        Description = "Event 5 Description",
                        Location = "Event 5 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 5 ImageUrl",
                        Url = "Event 5 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "6",
                        Name = "Event 6",
                        Description = "Event 6 Description",
                        Location = "Event 6 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 6 ImageUrl",
                        Url = "Event 6 Url"
                    },
                    new Domain.EventEntity
                    {
                        Id = "7",
                        Name = "Event 7",
                        Description = "Event 7 Description",
                        Location = "Event 7 Location",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ImageUrl = "Event 7 ImageUrl",
                        Url = "Event 7 Url"
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
