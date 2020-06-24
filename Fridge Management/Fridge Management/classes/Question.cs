using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_Management
{
    public class Question
    {
        public int id { get; set; }
        public string text { get; set; }
        public List<Answer> answers { get; set; }
    }

    public class Answer
    {
        public string atext { get; set; }
        public bool isCorrect { get; set; }
    }
}
