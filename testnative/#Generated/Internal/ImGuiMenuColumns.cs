// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.DearImGui.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public unsafe partial struct ImGuiMenuColumns
    {
        [FieldOffset(0)] public uint TotalWidth;

        [FieldOffset(4)] public uint NextTotalWidth;

        [FieldOffset(8)] public ushort Spacing;

        [FieldOffset(10)] public ushort OffsetIcon;

        [FieldOffset(12)] public ushort OffsetLabel;

        [FieldOffset(14)] public ushort OffsetShortcut;

        [FieldOffset(16)] public ushort OffsetMark;

        [FieldOffset(18)] public ConstantArray_ImU16_4 Widths;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper32", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiMenuColumns* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiMenuColumns()
        {
            fixed (ImGuiMenuColumns* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Update@ImGuiMenuColumns@@QEAAXM_N@Z", ExactSpelling = true)]
        private static extern void Update_PInvoke(ImGuiMenuColumns* @this, float spacing, byte window_reappearing);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Update(float spacing, bool window_reappearing)
        {
            fixed (ImGuiMenuColumns* @this = &this)
            { Update_PInvoke(@this, spacing, Unsafe.As<bool, byte>(ref window_reappearing)); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?DeclColumns@ImGuiMenuColumns@@QEAAMMMMM@Z", ExactSpelling = true)]
        private static extern float DeclColumns_PInvoke(ImGuiMenuColumns* @this, float w_icon, float w_label, float w_shortcut, float w_mark);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float DeclColumns(float w_icon, float w_label, float w_shortcut, float w_mark)
        {
            fixed (ImGuiMenuColumns* @this = &this)
            { return DeclColumns_PInvoke(@this, w_icon, w_label, w_shortcut, w_mark); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CalcNextTotalWidth@ImGuiMenuColumns@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void CalcNextTotalWidth_PInvoke(ImGuiMenuColumns* @this, byte update_offsets);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CalcNextTotalWidth(bool update_offsets)
        {
            fixed (ImGuiMenuColumns* @this = &this)
            { CalcNextTotalWidth_PInvoke(@this, Unsafe.As<bool, byte>(ref update_offsets)); }
        }
    }
}
