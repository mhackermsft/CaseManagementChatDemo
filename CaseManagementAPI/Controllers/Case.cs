using CaseManagementModels;
using Microsoft.AspNetCore.Mvc;

namespace CaseManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaseController : ControllerBase
    {
        [HttpGet("{caseId}")]
        public CaseModel GetCase(string caseId)
        {
            //Returning sample data. Replace this with your own logic to pull from 
            //a database or other data source.
            return new CaseModel
            {
                CaseId = caseId,
                CaseName = "Sample Case",
                CaseDescription = "This is a sample case.",
                Plaintiff = "Jane Doe",
                Defendant = "John Doe",
                Documents = new List<CaseDocument>
                {
                    new CaseDocument
                    {
                        Id = Guid.NewGuid(),
                        CaseId = caseId,
                        URI = @"..\CaseManagementAPI\DemoDocuments\sample1.pdf"
                    },
                    new CaseDocument
                    {
                        Id = Guid.NewGuid(),
                        CaseId = caseId,
                        URI = @"..\CaseManagementAPI\DemoDocuments\sample2.pdf"
                    }
                }
            };
        }
    }
}
