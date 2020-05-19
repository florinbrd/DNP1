using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
       

        private readonly ILogger<CalculateController> _logger;
        private readonly Calculator _calculator;
        private readonly VolumeContext _context;

        public CalculateController(ILogger<CalculateController> logger, Calculator calculator,VolumeContext context)
        {
            _logger = logger;
            _calculator = calculator;
            _context = context;
        }

        [HttpGet("cylinder")]
        [Produces("application/json")]
        public VolumeResult GetCylinderVolume(double radius, double height)
        {
            VolumeResult volumeResult = new VolumeResult();

//            volumeResult.id = 3;
            volumeResult.type = "Cylinder";
            volumeResult.Height = height;
            volumeResult.Radius = radius;
            volumeResult.Volume = _calculator.CalculateVolumeCylinder(radius, height);
            _context.results.Add(volumeResult);
            _context.SaveChanges();
            return volumeResult;
        }
        [HttpGet]
        [Produces("application/json")]
        public List<VolumeResult> GetCylinderVolume()
        {
            List<VolumeResult> volumeResult = new List<VolumeResult>();



            volumeResult=_context.results.ToList();
            return volumeResult;
        }


        [HttpGet("cone")]
        [Produces("application/json")]
        public VolumeResult GetConeVolume(double radius, double height)
        {
            VolumeResult volumeResult = new VolumeResult();

//            volumeResult.id = 4;
            volumeResult.type = "Cone";
            volumeResult.Height = height;
            volumeResult.Radius = radius;
            volumeResult.Volume = _calculator.CalculateVolumeCone(radius, height);

                    _context.results.Add(volumeResult);
                        _context.SaveChanges();
            return volumeResult;
        }
    }
}