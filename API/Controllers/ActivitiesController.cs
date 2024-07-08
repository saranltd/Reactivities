using Persistence;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
        public DataContext _context { get; set; }
        public ActivitiesController(DataContext context) 
        {
            _context = context;
            
        }
        [HttpGet]  //api/activities
        public async Task <ActionResult<List<Activity>>> GetActivities()
        {
           return await _context.Activities.ToListAsync ();  
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<Activity>> GetActivity (Guid id)
        {
            return await _context.Activities.FindAsync (id);
    
        }
       
    }
}