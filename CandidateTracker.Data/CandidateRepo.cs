using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CandidateTracker.Data
{
    public class CandidateRepo
    {
        private string _connectionString;
        public CandidateRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCandidate(Candidate candidate)
        {
            var context = new CandidateDataContext(_connectionString);
            context.Add(candidate);
        }
        public List <Candidate> GetPending()
        {
            var context = new CandidateDataContext(_connectionString);
            return context.Candidates.Where(c => c.Status == Status.Pending).ToList();
        }

        public List<Candidate> GetRefused()
        {
            var context = new CandidateDataContext(_connectionString);
            return context.Candidates.Where(c => c.Status == Status.Refused).ToList();
        }

        public List<Candidate> GetConfirmed()
        {
            var context = new CandidateDataContext(_connectionString);
            return context.Candidates.Where(c => c.Status == Status.Confirmed).ToList();
        }
    }
}
