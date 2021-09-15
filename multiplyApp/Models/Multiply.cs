using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multiplyApp.Models
{
    public class Multiply
    {
        public int number { get; set; }
        public List<MultiplyModel> multiplyBy { get; set; }
    }
}