using elFinder.Net.Core.Models.Response;

namespace ElFinderWeb31.Models.Responses
{
    public class ApplicationOpenResponse : OpenResponse
    {
        public ApplicationOpenResponse(OpenResponse openResp)
        {
            cwd = openResp.cwd;
            files = openResp.files;
            options = openResp.options;
            uplMaxFile = openResp.uplMaxFile;
        }

        public long usage { get; set; }
        public long quota { get; set; }
    }
}
