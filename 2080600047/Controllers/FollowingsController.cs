using _2080600047.DTOs;
using _2080600047.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2080600047.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {

            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(a => a.FollowerId == userId && a.FolloweeId == followingDto.FolloweeId))
            {
                return BadRequest("Following already exists");
            }
            var folowing = new Following
            {
                FolloweeId = userId,
                FollowerId = followingDto.FolloweeId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
