using Microsoft.AspNetCore.Mvc;

namespace youAreCorrectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YouAreCorrectController : Controller
    {
        [HttpGet]
        public string Get([FromQuery] string val0, [FromQuery] string val1, [FromQuery] string val2, [FromQuery] string val3, [FromQuery] string val4, [FromQuery] string val5,
            [FromQuery] string val6, [FromQuery] string val7, [FromQuery] string val8, [FromQuery] string val9, [FromQuery] string val10, [FromQuery] string val11, [FromQuery] string val12)
        {
            string res = string.Format("你说的对，但是{0}是由{1}自主研发的一款全新{2}游戏。游戏发生在一个被称作{3}的幻想世界，在这里，被{4}选中的人将被授予{5}，导引{6}之力。你将扮演一位名为{7}的神秘角色，在{8}的旅行中{9}，和他们一起{10}，找回失散的{11}——同时，逐步发掘{12}的真相。",
                val0, val1, val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12);
            return res;
        }
    }
}
