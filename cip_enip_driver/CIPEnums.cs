// -----------------------------------------------------------------------------------------------------------------
// Project: CIP driver over Ethernet/IP - Copyright (C) 2019, Bruno Ataíde (Techsteel), All rights reserved
// License: GNU General Public License 3.0
// Public Repo: https://github.com/Bataide/cip_enip_driver
// Description: Enums
// -----------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Techsteel.Drivers.CIP
{    
    public enum EncapsulationCommands : ushort
    {
        NOP = 0x0000,
        ListServices = 0x0004,
        ListIdentity = 0x0063,
        ListInterfaces = 0x0064,
        RegisterSession = 0x0065,
        UnRegisterSession = 0x0066,
        SendRRData = 0x006F,
        SendUnitData = 0x0070,
        IndicateStatus = 0x0072,
        Cancel = 0x0073
    }

    public enum CommonPacketItemID : ushort
    {
        Null = 0x0000,
        ListIdentity = 0x000C,
        ConnectionBased = 0x00A1,
        ConnectedTransportPacket = 0x00B1,
        UnconnectedMessage = 0x00B2,
        ListServicesResponse = 0x0100,
        SockaddrInfoOtoT = 0x8000,
        SockaddrInfoTtoO = 0x8001,
        SequencedAddressItem = 0x8002
    }

    public enum SegmentType
    {
        PortSegment = 0,
        LogicalSegment = 1,
        NetworkSegment = 2,
        SymbolicSegment = 3,
        DataSegment = 4,
        DataTypeConstructed = 5,
        DataTypeElementary = 6,
        ReservedFuture = 7
    }

    public enum SegmentLogicalType
    {
        ClassID = 0,
        InstanceID = 1,
        MemberID = 2,
        ConnectionPoint = 3,
        AttributeID = 4,
        Special = 5,
        ServiceID = 6,
        ReservedFuture = 7
    }

    public enum SegmentLogicalFormat
    {
        slf_8_bits = 0,
        slf_16_bits = 1,
        slf_32_bits = 2,
        slf_Reserved = 3
    }

    public enum SegmentDataSubType
    {
        SimpleDataSegment = 0,
        ANSIExtendedSymbolSegment = 17
    }

    public enum ConnMngrObjectInstSpecificServicesCode
    {
        Forward_Close = 0x4E,
        Unconnected_Send = 0x52,
        Forward_Open = 0x54,
        Get_Connection_Data = 0x56,
        Search_Connection_Data = 0x57,
        Ex_Forward_Open = 0x59,
        Get_Connection_Owner = 0x5A
    }

    public enum ElementaryDataType : ushort
    {
        BOOL = 0xC1,
        SINT = 0xC2,
        INT = 0xC3,
        DINT = 0xC4,
        LINT = 0xC5,
        USINT = 0xC6,
        UINT = 0xC7,
        UDINT = 0xC8,
        ULINT = 0xC9,
        REAL = 0xCA,
        LREAL = 0xCB,
        STIME = 0xCC,
        DATE = 0xCD,
        TIME_OF_DAY = 0xCE,
        DATE_AND_TIME = 0xCF,
        STRING = 0xD0,
        BYTE = 0xD1,
        WORD = 0xD2,
        DWORD = 0xD3,
        LWORD = 0xD4,
        STRING2 = 0xD5,
        FTIME = 0xD6,
        LTIME = 0xD7,
        ITIME = 0xD8,
        STRINGN = 0xD9,
        SHORT_STRING = 0xDA,
        TIME = 0xDB,
        EPATH = 0xDC,
        ENGUNIT = 0xDD
    }

    public enum CipStatusCode
    {
        Success = 0x00,
        ConnectionFailure = 0x01,
        ResourceUnavailable = 0x02,
        InvalidParameterValue = 0x03,
        PathSegmentError = 0x04,
        PathDestinationUnknown = 0x05,
        PartialTransfer = 0x06,
        ConnectionLost = 0x07,
        ServiceNotSupported = 0x08,
        InvalidAttributeValue = 0x09,
        AttributeListError = 0x0A,
        AlreadyInRequestedModeState = 0x0B,
        ObjectStateConflict = 0x0C,
        ObjectAlreadyExists = 0x0D,
        AttributeNotSettable = 0x0E,
        PrivilegeViolation = 0x0F,
        DeviceStateConflict = 0x10,
        ReplyDataTooLarge = 0x11,
        FragmentationOfAPrimitiveValue = 0x12,
        NotEnoughData = 0x13,
        AttributeNotSupported = 0x14,
        TooMuchData = 0x15,
        ObjectDoesNotExist = 0x16,
        ServiceFragmentationSequenceNotInProgress = 0x17,
        NoStoredAttributeData = 0x18,
        StoreOperationFailure = 0x19,
        RoutingFailureRequestPacketTooLarge = 0x1A,
        RoutingFailureResponsePacketTooLarge = 0x1B,
        MissingAttributeListEntryData = 0x1C,
        InvalidAttributeValueList = 0x1D,
        EmbeddedServiceError = 0x1E,
        VendorSpecificError = 0x1F,
        InvalidParameter = 0x20,
        WriteOnceValueOrMediumAlreadyWritten = 0x21,
        InvalidReplyReceived = 0x22,
        DescriptionOfStatusReservedByCIPForFutureExtensions1 = 0x23,
        DescriptionOfStatusReservedByCIPForFutureExtensions2 = 0x24,
        KeyFailureInPath = 0x25,
        PathSizeInvalid = 0x26,
        UnexpectedAttributeInList = 0x27,
        InvalidMemberID = 0x28,
        MemberNotSettable = 0x29,
        Group2OnlyServerGeneral = 0x2A
    }
}