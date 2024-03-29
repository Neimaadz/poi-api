﻿using Microsoft.AspNetCore.Http;

namespace EvaluationApi.Models
{
    public class PointOfInterestItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public string Comment { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}
