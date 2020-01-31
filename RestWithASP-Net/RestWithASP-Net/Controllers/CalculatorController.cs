using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_Net.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {

        // GET api/values/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }

        private bool IsNumeric(string number)
        {
            try
            {
                Convert.ToDecimal(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
