﻿using RTP.Net.RTCP;

namespace RTP.Net
{

    /// <summary>
    ///     This class contains constants that will be used throughout
    ///     the project.
    /// </summary>
    public class RTPConstants
    {
        /// <summary>
        ///     An RTPVersion enumerator representing the versions.
        /// </summary>
        public const byte VERSION = 2;

        /// <summary>
        ///     A readonly unsigned integer representing the
        ///     RTP_SEQ_MOD. A modulus function for the RTP sequence
        ///     to check it wraps around the max value to 0
        /// </summary>
        public const uint RTP_SEQ_MOD = (1 << 16);

        /// <summary>
        ///     A readonly unsigned integer representing
        ///     the RTP_MAX_SDS.
        /// </summary>
        public const uint RTP_MAX_SDS = 255;

        /// <summary>
        ///     A readonly unsigned short representing the
        ///     RTCP_VALID_MASK.
        /// </summary>
        public const ushort RTCP_VALID_MASK = (0xc000 | 0x2000 | 0xfe);

        /// <summary>
        ///     A readonly unsigned integer representing the
        ///     RTCP_VALID_VALUE.
        /// </summary>
        public const uint RTCP_VALID_VALUE = (((uint)VERSION << 14) | (uint)RTCPType.SR);
    }
}
