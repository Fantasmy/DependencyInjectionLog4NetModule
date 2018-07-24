using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using log4net;

namespace InyeccionLog4Net
{
    public class Calculation : ICalculation
    {
        private readonly log4net.ILog _logger;

        public Calculation(ILog logger)
        {
            _logger = logger;
        }


        public int Division(int num1, int num2)
        {
            int res = 0;

            try
            {
                res = num1 / num2;
                
            }
            catch (Exception)
            {
                _logger.Error("Can't divide by 0. -> num1= "+ num1 + ", num2 = "+ num2);
            }

            return res;
        }

    }
}
