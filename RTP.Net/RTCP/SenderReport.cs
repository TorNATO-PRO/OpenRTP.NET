﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RTP.Net.RTCP
{
    /// <summary>
    /// sender report (SR)
    /// </summary>
    class SenderReport : RTCP_Body
    {
        public SenderReport(uint sSRC, uint nTP_Timestamp, uint nTP_Fraction, uint rTP_Timestamp, uint packets_Sent, uint octets_Sent, RTCP_RR_Block[] rR_Block)
        {
            SSRC = sSRC;
            NTP_Timestamp = nTP_Timestamp;
            NTP_Fraction = nTP_Fraction;
            RTP_Timestamp = rTP_Timestamp;
            Packets_Sent = packets_Sent;
            Octets_Sent = octets_Sent;
            RR_Block = rR_Block;
        }

        /// <summary>
        /// sender generating this report
        /// </summary>
        public uint SSRC { get; private set; }

        /// <summary>
        /// NTP timestamp
        /// </summary>
        public uint NTP_Timestamp { get; private set; }

        /// <summary>
        /// Note: Fill in later...
        /// </summary>
        public uint NTP_Fraction { get; private set; }

        /// <summary>
        /// RTP timestamp
        /// </summary>
        public uint RTP_Timestamp { get; private set; }

        /// <summary>
        /// packets sent
        /// </summary>
        public uint Packets_Sent { get; private set; }

        /// <summary>
        /// octets sent
        /// </summary>
        public uint Octets_Sent { get; private set; }

        /// <summary>
        /// RR Block list.
        /// </summary>
        public RTCP_RR_Block[] RR_Block { get; private set; }


    }
}
