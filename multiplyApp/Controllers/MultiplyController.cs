using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using multiplyApp.Models;

namespace multiplyApp.Controllers
{
    public class MultiplyController : ApiController
    {
        public List<Multiply> Get(int id)
        {
            var multiply = new List<Multiply>();

            for (int x = 1; x <= id; x++)
            {
                var mult = new List<MultiplyModel>();

                for (int i = 1; i <= 10; i++)
                {
                    var multModel = new MultiplyModel();

                    multModel.multiplicand = x;
                    multModel.multiplier = i;
                    multModel.product = x * i;

                    mult.Add(multModel);
                }

                var tempList = new List<Multiply>()
                {
                    new Multiply()
                    {
                        number = x,
                        multiplyBy = mult
                    }
                };
                multiply.AddRange(tempList);
            }

            return multiply;
        }

        [HttpPost]
        public List<Multiply> Post(int id)
        {
            var obj = Get(id);
            return obj;
        }
    }
}
