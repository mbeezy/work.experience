using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkExperience.Models;

namespace WorkExperience.Models
{
    public interface IResumeRepository
    {
        IEnumerable<Resume> Retrieve();
    }
}
