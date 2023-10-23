using Microsoft.AspNetCore.Mvc;

namespace InterviewMvc.Controllers
{
    public class Home2Controller : Controller
    {
        [HttpGet]
        public string Get()
        {
            ProcessFunction();

            return "Command Executed";
        }

        private void ProcessFunction()
        {
            try
            {
                ProcessFunction();
            }
            finally
            {
                ProcessFunction();
            }
        }
    }
}
