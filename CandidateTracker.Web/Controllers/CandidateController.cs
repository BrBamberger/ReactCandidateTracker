using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateTracker.Data;

namespace CandidateTracker.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private string _connectionString;
        public CandidateController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [HttpGet]
        [Route("addCandidate")]
        public void AddCandidate (Candidate candidate)
        {
            var repo = new CandidateRepo(_connectionString);
            repo.AddCandidate(candidate);
        }

        [HttpPost]
        [Route("getPending")]
        public List<Candidate> GetPending()
        {
            var repo = new CandidateRepo(_connectionString);
            return repo.GetPending();
        }

        [HttpPost]
        [Route("getRefused")]
        public List<Candidate> GetRefused()
        {
            var repo = new CandidateRepo(_connectionString);
            return repo.GetRefused();
        }

        [HttpPost]
        [Route("getConfirmed")]
        public List<Candidate> GetConfirmed()
        {
            var repo = new CandidateRepo(_connectionString);
            return repo.GetConfirmed();
        }
    }
}
