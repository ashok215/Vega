using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vega.Controllers.Resources;
using vega.Persistence;
using Vega.Models;

namespace Vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbcontext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbcontext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }


        [HttpGet("/api/features")]
        public IEnumerable<FeatureResource> GetFeatures()
        {
           var features =  context.Features.ToList();
        
          return mapper.Map<List<Feature>, List<FeatureResource>>(features); 

        }
    }
}