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
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ImFontGlyphRangesBuilder
    {
        [FieldOffset(0)] public ImVector<uint> UsedChars;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper17", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImFontGlyphRangesBuilder* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImFontGlyphRangesBuilder()
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Clear@ImFontGlyphRangesBuilder@@QEAAXXZ", ExactSpelling = true)]
        private static extern void Clear_PInvoke(ImFontGlyphRangesBuilder* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { Clear_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetBit@ImFontGlyphRangesBuilder@@QEBA_N_K@Z", ExactSpelling = true)]
        private static extern byte GetBit_PInvoke(ImFontGlyphRangesBuilder* @this, nuint n);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool GetBit(nuint n)
        {
            byte __result;

            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { __result = GetBit_PInvoke(@this, n); }

            return Unsafe.As<byte, bool>(ref __result);
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetBit@ImFontGlyphRangesBuilder@@QEAAX_K@Z", ExactSpelling = true)]
        private static extern void SetBit_PInvoke(ImFontGlyphRangesBuilder* @this, nuint n);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBit(nuint n)
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { SetBit_PInvoke(@this, n); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddChar@ImFontGlyphRangesBuilder@@QEAAXG@Z", ExactSpelling = true)]
        private static extern void AddChar_PInvoke(ImFontGlyphRangesBuilder* @this, char c);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddChar(char c)
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { AddChar_PInvoke(@this, c); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddText@ImFontGlyphRangesBuilder@@QEAAXPEBD0@Z", ExactSpelling = true)]
        private static extern void AddText_PInvoke(ImFontGlyphRangesBuilder* @this, byte* text, byte* text_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddText(byte* text, byte* text_end = null)
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { AddText_PInvoke(@this, text, text_end); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddText(DearImGuiInterpolatedStringHandler text)
        {
            ReadOnlySpan<byte> __text = text.NullTerminateAndGetString();

            fixed (ImFontGlyphRangesBuilder* @this = &this)
            fixed (byte* __textP = __text)
            { AddText_PInvoke(@this, __textP, __textP + __text.Length); }

            text.Dispose();
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRanges@ImFontGlyphRangesBuilder@@QEAAXPEBG@Z", ExactSpelling = true)]
        private static extern void AddRanges_PInvoke(ImFontGlyphRangesBuilder* @this, char* ranges);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRanges(char* ranges)
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { AddRanges_PInvoke(@this, ranges); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?BuildRanges@ImFontGlyphRangesBuilder@@QEAAXPEAU?$ImVector@G@@@Z", ExactSpelling = true)]
        private static extern void BuildRanges_PInvoke(ImFontGlyphRangesBuilder* @this, ImVector<ushort>* out_ranges);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BuildRanges(ImVector<ushort>* out_ranges)
        {
            fixed (ImFontGlyphRangesBuilder* @this = &this)
            { BuildRanges_PInvoke(@this, out_ranges); }
        }
    }
}
