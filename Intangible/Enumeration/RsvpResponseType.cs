﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// The response (yes, no, maybe) to the RSVP.
    /// </summary>
    public enum RsvpResponseType
    {
        /// <summary>
        /// The RSVP response maybe
        /// </summary>
        [EnumMember(Value = "RsvpResponseMaybe")]
        RsvpResponseMaybe,
        /// <summary>
        /// The RSVP response no
        /// </summary>
        [EnumMember(Value = "RsvpResponseNo")]
        RsvpResponseNo,
        /// <summary>
        /// The RSVP response yes
        /// </summary>
        [EnumMember(Value = "RsvpResponseYes")]
        RsvpResponseYes,
    }
}
