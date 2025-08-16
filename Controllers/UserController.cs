using AutoMapper;
using automapper_example.DTOs;
using automapper_example.Models;
using automapper_example.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace automapper_example.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;

            // Eğer repository boşsa, varsayılan örnek kullanıcıları yükle
            if (!UserRepository.Users.Any())
            {
                UserRepository.Users.AddRange(new List<User>
                {
                    new User { Id = 1, FullName = "Elvan Tektaş", Email = "elvantektass@gmail.com", Password = "12345" },
                    new User { Id = 2, FullName = "Zeynep Tektaş", Email = "zeyneptektass@gmail.com", Password = "54321" }
                });
            }
        }

        public IActionResult Index()
        {
            var dtoList = _mapper.Map<List<UserDto>>(UserRepository.Users);
            return View(dtoList);
        }


        // GET: /User/Create
        public IActionResult Create()
        {
            return View(new UserDto());
        }

        // POST: /User/Create
        [HttpPost]
        public IActionResult Create(UserDto dto)
        {
            // DTO -> Entity
            var entity = _mapper.Map<User>(dto);

            // Id otomatik atama (örnek)
            entity.Id = UserRepository.Users.Any()
                        ? UserRepository.Users.Max(u => u.Id) + 1
                        : 1;

            UserRepository.Users.Add(entity);
            return RedirectToAction("Index");
        }
    }
}
