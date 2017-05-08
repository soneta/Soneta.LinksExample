using System;
using Soneta.Business;
using Soneta.Core;

namespace LinkSampleAddIn
{

    internal class LinkHandler : HTTPLinkInfo.IHTTPLinkAction
    {

        object HTTPLinkInfo.IHTTPLinkAction.Invoke(IGuidedRow document, string pars)
        {
            throw new NotImplementedException();
        }

    }

}
