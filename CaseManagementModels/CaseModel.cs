namespace CaseManagementModels
{
    public class CaseModel
    {
        public string CaseId { get; set; } = string.Empty;
        public string CaseName { get; set; } = string.Empty;
        public string CaseDescription { get; set; } = string.Empty;

        public List<CaseDocument> Documents { get; set; } = new List<CaseDocument>();
    }
}
