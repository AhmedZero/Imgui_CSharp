// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct ImGuiDockContext
    {
        [FieldOffset(0)] public ImGuiStorage Nodes;

        [FieldOffset(48)] [MarshalAs(UnmanagedType.I1)] public bool WantFullRebuild;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper46", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiDockContext* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiDockContext()
        {
            fixed (ImGuiDockContext* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}
