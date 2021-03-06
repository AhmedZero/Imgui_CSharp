// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public unsafe partial struct ImGuiOldColumns
    {
        [FieldOffset(0)] public uint ID;

        [FieldOffset(4)] public ImGuiOldColumnFlags Flags;

        [FieldOffset(8)] [MarshalAs(UnmanagedType.I1)] public bool IsFirstFrame;

        [FieldOffset(9)] [MarshalAs(UnmanagedType.I1)] public bool IsBeingResized;

        [FieldOffset(12)] public int Current;

        [FieldOffset(16)] public int Count;

        [FieldOffset(20)] public float OffMinX;

        [FieldOffset(24)] public float OffMaxX;

        [FieldOffset(28)] public float LineMinY;

        [FieldOffset(32)] public float LineMaxY;

        [FieldOffset(36)] public float HostCursorPosY;

        [FieldOffset(40)] public float HostCursorMaxPosX;

        [FieldOffset(44)] public ImRect HostInitialClipRect;

        [FieldOffset(60)] public ImRect HostBackupClipRect;

        [FieldOffset(76)] public ImRect HostBackupParentWorkRect;

        [FieldOffset(96)] public ImVector<ImGuiOldColumnData> Columns;

        [FieldOffset(112)] public ImDrawListSplitter Splitter;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper45", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiOldColumns* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiOldColumns()
        {
            fixed (ImGuiOldColumns* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}
