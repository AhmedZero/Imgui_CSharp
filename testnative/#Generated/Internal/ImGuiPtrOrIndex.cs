// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ImGuiPtrOrIndex
    {
        [FieldOffset(0)] public void* Ptr;

        [FieldOffset(8)] public int Index;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper39", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiPtrOrIndex* @this, void* ptr);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiPtrOrIndex(void* ptr)
        {
            fixed (ImGuiPtrOrIndex* @this = &this)
            { Constructor_PInvoke(@this, ptr); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper40", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiPtrOrIndex* @this, int index);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiPtrOrIndex(int index)
        {
            fixed (ImGuiPtrOrIndex* @this = &this)
            { Constructor_PInvoke(@this, index); }
        }
    }
}
