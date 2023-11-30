namespace FakeDataSync.Response;


public class GetOrgInfoResp
{
    public string RetResult { get; set; }
    public string RetMsg { get; set; }
    public List<object> List { get; set; } // 使用 List<object> 或更具体的类型
    public int TotalRow { get; set; }
    public int RowNum { get; set; }

    public GetOrgInfoResp(string retResult, string retMsg, List<object> list, int totalRow, int rowNum)
    {
        RetResult = retResult;
        RetMsg = retMsg;
        List = list;
        TotalRow = totalRow;
        RowNum = rowNum;
    }
}