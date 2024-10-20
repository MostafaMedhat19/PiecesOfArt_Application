using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;
using System.Collections.Generic;

namespace PiecesOfArt_Application.Interface_Layer.PRL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService<Category> _categoryService;
        private readonly IUserService<LoyaltyCard> _loyaltyCardService;
        private readonly IUserService<PieceOfArt> _pieceOfArtService;
        private readonly IUserService<User> _userService2;
        private readonly IUserServices2 _userService;

        private readonly IMapper _mapper;

        public UserController(IUserService<Category> categoryService, 
            IUserService<LoyaltyCard> loyaltyCardService, IUserService<PieceOfArt> pieceOfArtService, 
            IMapper mapper, IUserServices2 userService, IUserService<User> userService2)
        {
            _categoryService = categoryService;
            _loyaltyCardService = loyaltyCardService;
            _pieceOfArtService = pieceOfArtService;
            _userService2 = userService2;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet("categories")]
        public ActionResult<List<Category>> GetAllCategories()
        {
            var categories = _categoryService.GetAllEntities();
            return Ok(categories);
        }

        [HttpGet("loyaltyCard")]
        public ActionResult<List<LoyaltyCard>> GetAllLoyaltyCards()
        {
            var loyaltyCards = _loyaltyCardService.GetAllEntities();
            return Ok(loyaltyCards);
        }

        [HttpGet("pieceofArt")]
        public ActionResult<List<PieceOfArt>> GetAllPieceOfArt()
        {
            var pieceOfArts = _pieceOfArtService.GetAllEntities();
            return Ok(pieceOfArts);
        }

        [HttpDelete("{id}/category")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            var result = _categoryService.DeleteEntity(id);
            if (result)
            {
                return Ok("Category deleted successfully.");
            }
            return NotFound("Category not found.");
        }

        [HttpDelete("{id}/loyaltyCard")]
        public IActionResult DeleteLoyaltyCard([FromRoute] int id)
        {
            var result = _loyaltyCardService.DeleteEntity(id);
            if (result)
            {
                return Ok("Loyalty card deleted successfully.");
            }
            return NotFound("Loyalty card not found.");
        }

        [HttpDelete("{id}/pieceofArt")]
        public IActionResult DeletePieceOfArt([FromRoute] int id)
        {
            var result = _pieceOfArtService.DeleteEntity(id);
            if (result)
            {
                return Ok("Piece of art deleted successfully.");
            }
            return NotFound("Piece of art not found.");
        }

        [HttpPost("category")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest("Invalid category data.");
            }

            var result = _categoryService.AddEntity(category);
            if (result)
            {
                return Ok("Category added successfully.");
            }
            return BadRequest("Category could not be added.");
        }

        [HttpPost("loyaltyCard")]
        public IActionResult AddLoyaltyCard([FromBody] LoyaltyCard loyaltyCard)
        {
            if (loyaltyCard == null)
            {
                return BadRequest("Invalid loyalty card data.");
            }

            var result = _loyaltyCardService.AddEntity(loyaltyCard);
            if (result)
            {
                return Ok("Loyalty card added successfully.");
            }
            return BadRequest("Loyalty card could not be added.");
        }

        [HttpPost("pieceofArt")]
        public IActionResult AddPieceOfArt([FromBody] PieceOfArt pieceOfArt)
        {
            if (pieceOfArt == null)
            {
                return BadRequest("Invalid piece of art data.");
            }

            var result = _pieceOfArtService.AddEntity(pieceOfArt);
            if (result)
            {
                return Ok("Piece of art added successfully.");
            }
            return BadRequest("Piece of art could not be added.");
        }

        [HttpGet("{id}/category")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            var entity = _categoryService.GetEntityById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpGet("{id}/loyaltyCard")]
        public ActionResult<LoyaltyCard> GetLoyaltyCardById(int id)
        {
            var entity = _loyaltyCardService.GetEntityById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpGet("{id}/pieceofArt")]
        public ActionResult<PieceOfArt> GetPieceOfArtById(int id)
        {
            var entity = _pieceOfArtService.GetEntityById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut("{id}/category")]
        public IActionResult UpdateCategory([FromRoute] int id, [FromBody] Category entity)
        {
            var existingEntity = _categoryService.GetEntityById(id);
            if (entity == null || existingEntity == null)
            {
                return BadRequest("Invalid category data.");
            }

            var result = _categoryService.UpdateEntity(id, entity);
            if (result)
            {
                return Ok("Category updated successfully.");
            }
            return BadRequest("Category could not be updated.");
        }

        [HttpPut("{id}/loyaltyCard")]
        public IActionResult UpdateLoyaltyCard([FromRoute] int id, [FromBody] LoyaltyCard entity)
        {
            var existingEntity = _loyaltyCardService.GetEntityById(id);
            if (entity == null || existingEntity == null)
            {
                return BadRequest("Invalid loyalty card data.");
            }

            var result = _loyaltyCardService.UpdateEntity(id, entity);
            if (result)
            {
                return Ok("Loyalty card updated successfully.");
            }
            return BadRequest("Loyalty card could not be updated.");
        }

        [HttpPut("{id}/pieceofArt")]
        public IActionResult UpdatePieceOfArt([FromRoute] int id, [FromBody] PieceOfArt entity)
        {
            var existingEntity = _pieceOfArtService.GetEntityById(id);
            if (entity == null || existingEntity == null)
            {
                return BadRequest("Invalid piece of art data.");
            }

            var result = _pieceOfArtService.UpdateEntity(id, entity);
            if (result)
            {
                return Ok("Piece of art updated successfully.");
            }
            return BadRequest("Piece of art could not be updated.");
        }

        [HttpGet]
        public ActionResult<List<UserDTO>> GetAllUsers()
        {
            var users = _userService.DisplayInfo();
            if (users == null)
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<UserDTO> GetUserById(int id)
        {
            var user = _userService2.GetEntityById(id);
            if (user == null)
            {
                return NotFound("User not found.");
            }
            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data.");
            }

            var result = _userService2.AddEntity(user);
            if (result)
            {
                return Ok("User added successfully.");
            }
            return BadRequest("User could not be added.");
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data.");
            }

            var result = _userService.UpdateData(user);
            if (result)
            {
                return Ok("User updated successfully.");
            }
            return NotFound("User not found.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] int id)
        {
            var result = _userService.DeleteData(id);
            if (result)
            {
                return Ok("User deleted successfully.");
            }
            return NotFound("User not found.");
        }
    }
}
