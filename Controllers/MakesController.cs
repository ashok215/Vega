using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Persistence;
using Vega.Models;

namespace Vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbcontext context;
        private readonly IMapper mapper;

        public MakesController(VegaDbcontext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeResource> GetMakes()
        {

            var makes = context.Makes.Include(m => m.Models).ToList();
             return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

    }
}