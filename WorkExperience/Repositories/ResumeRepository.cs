using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using WorkExperience.Models;

namespace WorkExperience.Models
{
    public class ResumeRepository : IResumeRepository
    {
        public IEnumerable<Resume> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/resume.json");
            var json = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Resume>>(json);
        }
    }
}