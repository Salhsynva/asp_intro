using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_intro.Models
{
    public class Exam
    {
        public Exam(int id, string subject)
        {
            this.Id = id;
            this.Subject = subject;
        }
        public int Id { get; set; }
        public string Subject { get; set; }
    }
}
