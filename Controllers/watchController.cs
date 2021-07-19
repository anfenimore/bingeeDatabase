using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using database;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using watchlist.database;
using watchlist.interfaces;
using watchlist.models;

namespace watchlist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class watchController : ControllerBase
    {


        // [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<MyList> Get()
        {
            //Gets all items from cart
            ReadWatched readObject = new ReadWatched();
            return readObject.GetAllWatched();
        }

        // //GET: api/cart/5
        // [EnableCors("AnotherPolicy")]
        // [HttpGet("{id}")]
        // public Cart Get(int id)
        // {
        //     ReadShow readObject = new ReadShow();
        //     return readObject.GetCart(id);
        // }

        // POST: api/cart
        // [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] int useId)
        {
            // //Adds an employee id to the cart to track who is renting the item
            // AddUserToCart insertObject = new AddUserToCart();
            // insertObject.AddEmployeeToCart(userId);
        }

        // PUT: api/cart/5
        // [EnableCors("AnotherPolicy")]
        [HttpPut]
        public void Put([FromBody] Show myShow)
        {
            //Adds item to the cart
            SaveShow insertObject = new SaveShow();
            insertObject.CreateShow(myShow);
        }

        // DELETE: api/cart
        // [EnableCors("AnotherPolicy")]
        [HttpDelete]
        public void Delete([FromBody] int showId)
        {
            //Removes item from cart
            System.Console.WriteLine("Made it to delete " + showId);
            IDeleteShow insertObject = new DeleteShow();
            insertObject.RemoveShow(showId);
        }
    }
}