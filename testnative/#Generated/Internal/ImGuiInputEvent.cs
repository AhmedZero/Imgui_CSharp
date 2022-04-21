// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct ImGuiInputEvent
    {
        [FieldOffset(0)] public ImGuiInputEventType Type;

        [FieldOffset(4)] public ImGuiInputSource Source;

        [FieldOffset(8)] public ImGuiInputEventMousePos MousePos;

        [FieldOffset(8)] public ImGuiInputEventMouseWheel MouseWheel;

        [FieldOffset(8)] public ImGuiInputEventMouseButton MouseButton;

        [FieldOffset(8)] public ImGuiInputEventMouseViewport MouseViewport;

        [FieldOffset(8)] public ImGuiInputEventKey Key;

        [FieldOffset(8)] public ImGuiInputEventText Text;

        [FieldOffset(8)] public ImGuiInputEventAppFocused AppFocused;

        [FieldOffset(20)] [MarshalAs(UnmanagedType.I1)] public bool AddedByTestEngine;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper41", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiInputEvent* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiInputEvent()
        {
            fixed (ImGuiInputEvent* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}