using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace countDownApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountDownController : ControllerBase
    {
        // GET: api/<CountDownController>
        [HttpGet]
        public string Get()
        {
            var targetTime = new DateTime(2022, 7, 28, 23, 0, 0);
            targetTime = targetTime.AddHours(-8);
            var currentTime = DateTime.UtcNow;
            var timeDifference = targetTime - currentTime;
            if (timeDifference.CompareTo(TimeSpan.Zero) > 0)
            {
                return "距离异度神剑3数字版解锁还有" + timeDifference.Days + "天" + timeDifference.Hours + "小时" + timeDifference.Minutes + "分钟" + timeDifference.Seconds + "秒";
            }
            else
            {
                return "异度神剑3数字版已经解锁啦！";
            }
            
        }

        // GET api/<CountDownController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountDownController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountDownController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountDownController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
