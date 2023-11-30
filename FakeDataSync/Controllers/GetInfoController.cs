using Microsoft.AspNetCore.Mvc;

namespace FakeDataSync.Controllers;

[ApiController]
[Route("/api/sso/interf"), ]
public class GetInfoController
{
    [HttpPost("GetOrgInfoList")]
    public void GetOrgInfoList()
    {
    }
    
    
}