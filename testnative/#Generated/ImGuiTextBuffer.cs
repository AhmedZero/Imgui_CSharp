// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.DearImGui.Infrastructure;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ImGuiTextBuffer
    {
        [FieldOffset(0)] public ImVector<byte> Buf;

        public static readonly ConstantArray_char_1* EmptyString = (ConstantArray_char_1*)NativeLibrary.GetExport(NativeLibrary.Load("Mochi.DearImGui.Native"), "?EmptyString@ImGuiTextBuffer@@2PADA");

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper7", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiTextBuffer()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??AImGuiTextBuffer@@QEBADH@Z", ExactSpelling = true)]
        private static extern byte operator_Subscript_PInvoke(ImGuiTextBuffer* @this, int i);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte operator_Subscript(int i)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { return operator_Subscript_PInvoke(@this, i); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?begin@ImGuiTextBuffer@@QEBAPEBDXZ", ExactSpelling = true)]
        private static extern byte* begin_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* begin()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { return begin_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?end@ImGuiTextBuffer@@QEBAPEBDXZ", ExactSpelling = true)]
        private static extern byte* end_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* end()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { return end_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?size@ImGuiTextBuffer@@QEBAHXZ", ExactSpelling = true)]
        private static extern int size_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int size()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { return size_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?empty@ImGuiTextBuffer@@QEBA_NXZ", ExactSpelling = true)]
        private static extern byte empty_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool empty()
        {
            byte __result;

            fixed (ImGuiTextBuffer* @this = &this)
            { __result = empty_PInvoke(@this); }

            return Unsafe.As<byte, bool>(ref __result);
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?clear@ImGuiTextBuffer@@QEAAXXZ", ExactSpelling = true)]
        private static extern void clear_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void clear()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { clear_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?reserve@ImGuiTextBuffer@@QEAAXH@Z", ExactSpelling = true)]
        private static extern void reserve_PInvoke(ImGuiTextBuffer* @this, int capacity);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void reserve(int capacity)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { reserve_PInvoke(@this, capacity); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?c_str@ImGuiTextBuffer@@QEBAPEBDXZ", ExactSpelling = true)]
        private static extern byte* c_str_PInvoke(ImGuiTextBuffer* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* c_str()
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { return c_str_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?append@ImGuiTextBuffer@@QEAAXPEBD0@Z", ExactSpelling = true)]
        private static extern void append_PInvoke(ImGuiTextBuffer* @this, byte* str, byte* str_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void append(byte* str, byte* str_end = null)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { append_PInvoke(@this, str, str_end); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void append(DearImGuiInterpolatedStringHandler str)
        {
            ReadOnlySpan<byte> __str = str.NullTerminateAndGetString();

            fixed (ImGuiTextBuffer* @this = &this)
            fixed (byte* __strP = __str)
            { append_PInvoke(@this, __strP, __strP + __str.Length); }

            str.Dispose();
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?appendf@ImGuiTextBuffer@@QEAAXPEBDZZ", ExactSpelling = true)]
        private static extern void appendf_PInvoke(ImGuiTextBuffer* @this, byte* fmt);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void appendf(byte* fmt)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { appendf_PInvoke(@this, fmt); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void appendf(DearImGuiInterpolatedStringHandler fmt)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            fixed (byte* __fmtP = fmt.NullTerminateAndGetString())
            { appendf_PInvoke(@this, __fmtP); }

            fmt.Dispose();
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?appendfv@ImGuiTextBuffer@@QEAAXPEBDPEAD@Z", ExactSpelling = true)]
        private static extern void appendfv_PInvoke(ImGuiTextBuffer* @this, byte* fmt, byte* args);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void appendfv(byte* fmt, byte* args)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            { appendfv_PInvoke(@this, fmt, args); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void appendfv(DearImGuiInterpolatedStringHandler fmt, byte* args)
        {
            fixed (ImGuiTextBuffer* @this = &this)
            fixed (byte* __fmtP = fmt.NullTerminateAndGetString())
            { appendfv_PInvoke(@this, __fmtP, args); }

            fmt.Dispose();
        }
    }
}