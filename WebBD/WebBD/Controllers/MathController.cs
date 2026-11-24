using Microsoft.AspNetCore.Mvc;
using System;

namespace Class207
{
    public class Math
    {
        public double sum(double a, int b) => a + b;
        public double subtract(double a, int b) => a - b;
        public double multiply(double a, int b) => a * b;
        public double divide(double a, int b) => a / b;
        public double min(double[] arr) => arr.Min();
        public double max(double[] arr) => arr.Max();
        public double percentage(double a, double b) => (a * b) / 100;
        public double invpercentage(double a, double b) => 100 - ((a * b) / 100);
        public double sqrt(double a) => System.Math.Sqrt(a);
        public double modulo(double a, int b) => a % b;
        public double log(double a) => System.Math.Log(a);
        public long factorial(int a)
        {
            long result = 1;
            for (int i = 2; i <= a; i++) result *= i;
            return result;
        }
    }
}

namespace WebBD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        Class207.Math clsMathService = new Class207.Math();

        [HttpGet("Sum")]
        public double Sum(double num1, int num2) => clsMathService.sum(num1, num2);

        [HttpGet("Subtract")]
        public double Subtract(double num1, int num2) => clsMathService.subtract(num1, num2);

        [HttpGet("Multiply")]
        public double Multiply(double num1, int num2) => clsMathService.multiply(num1, num2);

        [HttpGet("Divide")]
        public double Divide(double num1, int num2) => clsMathService.divide(num1, num2);
        [HttpGet("Min")]
        public double Min([FromQuery] double[] numbers) => clsMathService.min(numbers);

        [HttpGet("Max")]
        public double Max([FromQuery] double[] numbers) => clsMathService.max(numbers);

        [HttpGet("Percentage")]
        public double Percentage(double num1, double percent) => clsMathService.percentage(num1, percent);
        [HttpGet("InvPercentage")]
        public double InvPercentage(double num1, double percent) => clsMathService.invpercentage(num1, percent);

        [HttpGet("Sqrt")]
        public double Sqrt(double num) => clsMathService.sqrt(num);

        [HttpGet("Modulo")]
        public double Modulo(double num1, int num2) => clsMathService.modulo(num1, num2);

        [HttpGet("Log")]
        public double Log(double num) => clsMathService.log(num);

        [HttpGet("Factorial")]
        public long Factorial(int num) => clsMathService.factorial(num);
    }
}
