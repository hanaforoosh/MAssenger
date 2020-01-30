using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MAssenger
{
    public enum SeenStatus
    {
        Online,
        LastSeenRecently,
        LastSeenInAmonth,
        LastSeenAlongTimeAgo,
        NotDefined,
        bot
    }
}