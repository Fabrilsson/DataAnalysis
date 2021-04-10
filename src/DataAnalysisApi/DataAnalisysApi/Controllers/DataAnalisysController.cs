using DataAnalisysApi.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using RDotNet;
using System;
using System.Threading.Tasks;

namespace DataAnalisysApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAnalisysController : ControllerBase
    {
        readonly REngine _rEngine;

        public DataAnalisysController()
        {
            REngine.SetEnvironmentVariables();

            _rEngine = REngine.GetInstance();
        }

        public async Task<IActionResult> Get()
        {
            //_rEngine.Evaluate("install.packages('forecast', dependencies = TRUE)");
            //_rEngine.Evaluate("install.packages('lmtest', dependencies = TRUE)");
            _rEngine.Evaluate("library(forecast)");
            _rEngine.Evaluate("library(lmtest)");

            string fileName = "myplot.png";

            CharacterVector fileNameVector = _rEngine.CreateCharacterVector(new[] { fileName });
            _rEngine.SetSymbol("fileName", fileNameVector);

            _rEngine.Evaluate("png(filename=fileName, width=6, height=6, units='in', res=100)");

            _rEngine.Evaluate("vector <- as.numeric(AirPassengers)");
            _rEngine.Evaluate("z <- ts(vector, frequency = 12, start = c(1949, 1))");
            
            _rEngine.Evaluate("z_train <- ts(z[1:100], frequency = 12)");
            _rEngine.Evaluate("z_validate <- ts(z[101:144], frequency = 12)");
            _rEngine.Evaluate("fit <- Arima(y = z_train, order = c(1,1,0), seasonal = c(1,1,0), lambda = TRUE)");
            _rEngine.Evaluate("predition <- forecast(fit, h = 44)");

            //_rEngine.Evaluate("z_train <- ts(z[1:100], frequency = 12");
            _rEngine.Evaluate("plot(predition)"); //plot and save file
            //_rEngine.Evaluate("lines(fit$fitted, col = 'blue')");
            _rEngine.Evaluate("dev.off()");

            Byte[] b = System.IO.File.ReadAllBytes(@"C:\Users\admin\source\repos\DataAnalisysApi\DataAnalisysApi\myplot.png");   // You can use your own method over here.         
            return File(b, "image/jpeg");
        }
    }
}