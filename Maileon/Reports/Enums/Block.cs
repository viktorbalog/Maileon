﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Maileon.Reports
{
    /// <summary>
    /// The valid block reasons
    /// </summary>
    public enum BlockReason
    {
        [XmlEnum("blacklist")]
        Blacklist,
        [XmlEnum("bounce_policy")]
        BouncePolicy,
    }

    /// <summary>
    /// The status of this block
    /// </summary>
    public enum BlockStatus
    {
        [XmlEnum("allowed")]
        Allowed,
        [XmlEnum("blocked")]
        Blocked
    }
}
