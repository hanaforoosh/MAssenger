using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MAssenger
{
    public enum MessageStatus
    {
        Sent,
        Delivered,
        Seen
    }
}