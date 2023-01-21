using Eventful.Domain;
using Eventful.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventful.Application.Events
{
	public class List
	{
		public class Query : IRequest<List<EventEntity>> { }

		public class Handler : IRequestHandler<Query, List<EventEntity>>
		{
			private readonly DataContext _context;
			public Handler(DataContext dataContext)
			{
				_dataContext = dataContext;
			}
			
			public async Task<List<EventEntity>> Handle(Query request, CancellationToken cancellationToken)
			{
				return new List<EventEntity>
				{
					new EventEntity
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
					new EventEntity
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
					new EventEntity
					{
						Id = "3",
						Name = "Event 3",
						Description = "Event 3 Description",
						Location = "Event 3 Location",
						StartDate = DateTime.Now,
						EndDate = DateTime.Now,
						ImageUrl = "Event 3 ImageUrl",
						Url = "Event 3 Url"
					}
				};
			}
		}
	}
}
