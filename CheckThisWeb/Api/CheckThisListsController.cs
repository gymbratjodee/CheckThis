using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckThisWeb.Api
{
    public class CheckThisListsController
    {
        public class CheckThisListsController : ApiController
        {
            private readonly ICheckThisListsManager _checkThisListsManager;

            public CheckThisListsController(ICheckThisListsManager checkThisListsManager)
            {
                _checkThisListsManager = checkThisListsManager;
            }

            [HttpGet]
            public async Task<OkNegotiatedContentResult<List<CheckThisList>>> GetLists()
            {
                var result = await _checkThisListsManager.GetListsByPerson(1);
                return Ok(result);
            }
        }
    }
}
