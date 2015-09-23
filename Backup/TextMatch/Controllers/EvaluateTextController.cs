using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using TextMatch.Models;
using TextMatch.Helpers;


namespace TextMatch.Controllers
{
    public class EvaluateTextController : ApiController
    {


        // POST api/evaluatetext
        public CompareResult Post([FromBody]CompareRequest request)
        {
            if (!ModelState.IsValid)
            {
                //logg results
                return null;
            }
            StringCompare sc = new StringCompare(request.subtext, request.text);
            CompareResult result = new CompareResult(){
                Text = request.text,
                Subtext = request.subtext,
                result = sc.Indexes
            };
            return result;
        }

    }
}
