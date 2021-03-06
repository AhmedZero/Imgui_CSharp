// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Numerics;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct ImGuiGroupData
    {
        [FieldOffset(0)] public uint WindowID;

        [FieldOffset(4)] public Vector2 BackupCursorPos;

        [FieldOffset(12)] public Vector2 BackupCursorMaxPos;

        [FieldOffset(20)] public float BackupIndent;

        [FieldOffset(24)] public float BackupGroupOffset;

        [FieldOffset(28)] public Vector2 BackupCurrLineSize;

        [FieldOffset(36)] public float BackupCurrLineTextBaseOffset;

        [FieldOffset(40)] public uint BackupActiveIdIsAlive;

        [FieldOffset(44)] [MarshalAs(UnmanagedType.I1)] public bool BackupActiveIdPreviousFrameIsAlive;

        [FieldOffset(45)] [MarshalAs(UnmanagedType.I1)] public bool BackupHoveredIdIsAlive;

        [FieldOffset(46)] [MarshalAs(UnmanagedType.I1)] public bool EmitItem;
    }
}
