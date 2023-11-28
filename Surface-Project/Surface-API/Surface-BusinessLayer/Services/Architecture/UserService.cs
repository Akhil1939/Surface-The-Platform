

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StudentJobs.Entities.DTOs;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface.Entities.DataModels;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(uow.UserRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }


        public async Task<List<EmailDTO>> GetEmailList(string query)
        {
            PageListRequestEntity<User> pageListRequest = new()
            {
                Predicate = x => x.Email.Contains(query) ,
                Selects = x =>  new User { Email = x.Email, Avatar = x.Avatar },
                PageIndex = 1,
                PageSize = 10,
                SortColumn = "Email"

            };
            var Users = await GetAllAsync(pageListRequest);
            return _mapper.Map<List<EmailDTO>>(Users.Records);

        }
    }
}
