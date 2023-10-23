using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace InterviewMvc.Controllers
{
    public class Home3Controller : Controller
    {
        ArrayList objectList = new ArrayList();

        private Array SaveObject(int objectId)
        {
            int numbers = objectId / 8;
            int[] arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                arr[i] = i;
            }

            return arr;
        }

        [HttpGet]
        public string Get()
        {
            var id = 400000 * 1024;
            var objectId = SaveObject(id);
            objectList.AddRange(objectId);
            return "Command Executed";
        }
    }
}
