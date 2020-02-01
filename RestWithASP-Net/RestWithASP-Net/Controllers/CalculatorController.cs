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
        Verification verf = new Verification();

        // Sum
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }


        // Substraction
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }


        // Multiplication
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }


        // Division
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }


        // Exponentiation
        [HttpGet("exponentiation/{firstNumber}/{secondNumber}")]
        public IActionResult Exponentiation(string firstNumber, string secondNumber)
        {
            if (verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Math.Pow(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }

        // Exponentiation
        [HttpGet("squareroot/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber, string secondNumber)
        {
            if (verf.IsNumeric(firstNumber) && verf.IsNumeric(secondNumber))
            {
                var sum = Math.Sqrt(Convert.ToDouble(firstNumber));
                return Ok(sum.ToString());
            }
            return BadRequest("Fail");
        }
    }
}
