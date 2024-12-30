﻿namespace PresentationLayerApi.Features;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    #region Content
    protected IActionResult Content(object obj)
    {
        return Ok(JsonConvert.SerializeObject(obj));
    }
    #endregion

    #region InternalServerError
    protected IActionResult InternalServerError(Exception ex)
    {
        return StatusCode(500, ex.Message);
    }
    #endregion
}
