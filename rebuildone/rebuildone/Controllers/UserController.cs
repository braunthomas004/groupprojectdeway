using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rebuildone.Data;
using rebuildone.Models;

namespace rebuildone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
        }
        //questionable code...?
        /**public GetUsers(int id)
        {
            return ( User: userRepository);
        }
        **/
    }
}