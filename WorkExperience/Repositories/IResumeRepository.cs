using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkExperience.Models;

namespace WorkExperience.Repositories
{
    public interface IResumeRepository
    {
        List<Resume> Retrieve();
    }
}
