// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct ImDrawData
    {
        [FieldOffset(0)] [MarshalAs(UnmanagedType.I1)] public bool Valid;

        [FieldOffset(4)] public int CmdListsCount;

        [FieldOffset(8)] public int TotalIdxCount;

        [FieldOffset(12)] public int TotalVtxCount;

        [FieldOffset(16)] public ImDrawList** CmdLists;

        [FieldOffset(24)] public Vector2 DisplayPos;

        [FieldOffset(32)] public Vector2 DisplaySize;

        [FieldOffset(40)] public Vector2 FramebufferScale;

        [FieldOffset(48)] public ImGuiViewport* OwnerViewport;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper16", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImDrawData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImDrawData()
        {
            fixed (ImDrawData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Clear@ImDrawData@@QEAAXXZ", ExactSpelling = true)]
        private static extern void Clear_PInvoke(ImDrawData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            fixed (ImDrawData* @this = &this)
            { Clear_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?DeIndexAllBuffers@ImDrawData@@QEAAXXZ", ExactSpelling = true)]
        private static extern void DeIndexAllBuffers_PInvoke(ImDrawData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DeIndexAllBuffers()
        {
            fixed (ImDrawData* @this = &this)
            { DeIndexAllBuffers_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ScaleClipRects@ImDrawData@@QEAAXAEBUImVec2@@@Z", ExactSpelling = true)]
        private static extern void ScaleClipRects_PInvoke(ImDrawData* @this, Vector2* fb_scale);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ScaleClipRects(in Vector2 fb_scale)
        {
            fixed (ImDrawData* @this = &this)
            fixed (Vector2* __fb_scaleP = &fb_scale)
            { ScaleClipRects_PInvoke(@this, __fb_scaleP); }
        }
    }
}
