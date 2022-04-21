// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 56, CharSet = CharSet.Unicode)]
    public unsafe partial struct ImGuiInputTextCallbackData
    {
        [FieldOffset(0)] public ImGuiInputTextFlags EventFlag;

        [FieldOffset(4)] public ImGuiInputTextFlags Flags;

        [FieldOffset(8)] public void* UserData;

        [FieldOffset(16)] public char EventChar;

        [FieldOffset(20)] public ImGuiKey EventKey;

        [FieldOffset(24)] public byte* Buf;

        [FieldOffset(32)] public int BufTextLen;

        [FieldOffset(36)] public int BufSize;

        [FieldOffset(40)] [MarshalAs(UnmanagedType.I1)] public bool BufDirty;

        [FieldOffset(44)] public int CursorPos;

        [FieldOffset(48)] public int SelectionStart;

        [FieldOffset(52)] public int SelectionEnd;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiInputTextCallbackData@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiInputTextCallbackData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiInputTextCallbackData()
        {
            fixed (ImGuiInputTextCallbackData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?DeleteChars@ImGuiInputTextCallbackData@@QEAAXHH@Z", ExactSpelling = true)]
        private static extern void DeleteChars_PInvoke(ImGuiInputTextCallbackData* @this, int pos, int bytes_count);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DeleteChars(int pos, int bytes_count)
        {
            fixed (ImGuiInputTextCallbackData* @this = &this)
            { DeleteChars_PInvoke(@this, pos, bytes_count); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?InsertChars@ImGuiInputTextCallbackData@@QEAAXHPEBD0@Z", ExactSpelling = true)]
        private static extern void InsertChars_PInvoke(ImGuiInputTextCallbackData* @this, int pos, byte* text, byte* text_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertChars(int pos, byte* text, byte* text_end = null)
        {
            fixed (ImGuiInputTextCallbackData* @this = &this)
            { InsertChars_PInvoke(@this, pos, text, text_end); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertChars(int pos, DearImGuiInterpolatedStringHandler text)
        {
            ReadOnlySpan<byte> __text = text.NullTerminateAndGetString();

            fixed (ImGuiInputTextCallbackData* @this = &this)
            fixed (byte* __textP = __text)
            { InsertChars_PInvoke(@this, pos, __textP, __textP + __text.Length); }

            text.Dispose();
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SelectAll@ImGuiInputTextCallbackData@@QEAAXXZ", ExactSpelling = true)]
        private static extern void SelectAll_PInvoke(ImGuiInputTextCallbackData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SelectAll()
        {
            fixed (ImGuiInputTextCallbackData* @this = &this)
            { SelectAll_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearSelection@ImGuiInputTextCallbackData@@QEAAXXZ", ExactSpelling = true)]
        private static extern void ClearSelection_PInvoke(ImGuiInputTextCallbackData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearSelection()
        {
            fixed (ImGuiInputTextCallbackData* @this = &this)
            { ClearSelection_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?HasSelection@ImGuiInputTextCallbackData@@QEBA_NXZ", ExactSpelling = true)]
        private static extern byte HasSelection_PInvoke(ImGuiInputTextCallbackData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool HasSelection()
        {
            byte __result;

            fixed (ImGuiInputTextCallbackData* @this = &this)
            { __result = HasSelection_PInvoke(@this); }

            return Unsafe.As<byte, bool>(ref __result);
        }
    }
}
