using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkExperience.Models;
using WorkExperience.Services;

namespace WorkExperience.Models
{
    public class ResumeMongoRepository : EntityService<Resume>, IResumeRepository
    {
        public IEnumerable<Resume> Retrieve()
        {
            var resumeList = MongoConnectionHandler.MongoCollection.FindAllAs<Resume>();

            return resumeList;
        }
    }
}