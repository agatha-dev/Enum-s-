using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities
{
    public class Comment
    {
        public Comment(string text)
        {
            Text = text;
        }
        public Comment()
        {

        }

        public string Text { get; set; }


    }
}
