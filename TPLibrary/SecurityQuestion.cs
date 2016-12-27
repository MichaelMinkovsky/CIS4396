using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class SecurityQuestion
    {
        string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public SecurityQuestion() { }

        public SecurityQuestion(string Question) { question = Question; }
    }
}
