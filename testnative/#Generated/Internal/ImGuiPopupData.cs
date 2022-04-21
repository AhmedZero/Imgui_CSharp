// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct ImGuiPopupData
    {
        [FieldOffset(0)] public uint PopupId;

        [FieldOffset(8)] public ImGuiWindow* Window;

        [FieldOffset(16)] public ImGuiWindow* SourceWindow;

        [FieldOffset(24)] public int OpenFrameCount;

        [FieldOffset(28)] public uint OpenParentId;

        [FieldOffset(32)] public Vector2 OpenPopupPos;

        [FieldOffset(40)] public Vector2 OpenMousePos;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper34", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiPopupData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiPopupData()
        {
            fixed (ImGuiPopupData* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}
