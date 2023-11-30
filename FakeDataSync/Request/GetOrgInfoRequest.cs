namespace FakeDataSync.Request;

using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;

public class GetOrgInfoRequest
{
    public string SignMsg { get; private set; }
    public string SubmitTimestamp { get; private set; }
    public string SystemId { get; private set; }
    public string OrgId { get; private set; }
    public string BeginRow { get; private set; }
    public string EndRow { get; private set; }

    public GetOrgInfoRequest(IDictionary<string, string> args)
    {
        SignMsg = Validate(args, "signMsg");
        SubmitTimestamp = Validate(args, "submitTimestamp");
        SystemId = Validate(args, "systemId");
        OrgId = Validate(args, "orgId");
        BeginRow = Validate(args, "beginRow");
        EndRow = Validate(args, "endRow");

        // TODO: Validate SignMsg
        // Construct the expected sign message
        var expectedSignMsg = WebUtility.UrlEncode(SubmitTimestamp + SystemId + OrgId + BeginRow + EndRow);
    }

    private static string Validate(IDictionary<string, string> args, string key)
    {
        if (!args.ContainsKey(key) || string.IsNullOrWhiteSpace(args[key]))
        {
            throw new ArgumentException($"Parameter {key} is missing or empty");
        }
        return args[key];
    }
}
