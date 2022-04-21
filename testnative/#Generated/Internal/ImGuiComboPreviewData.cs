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
    public unsafe partial struct ImGuiComboPreviewData
    {
        [FieldOffset(0)] public ImRect PreviewRect;

        [FieldOffset(16)] public Vector2 BackupCursorPos;

        [FieldOffset(24)] public Vector2 BackupCursorMaxPos;

        [FieldOffset(32)] public Vector2 BackupCursorPosPrevLine;

        [FieldOffset(40)] public float BackupPrevLineTextBaseOffset;

        [FieldOffset(44)] public ImGuiLayoutType BackupLayout;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper31", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiComboPreviewData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiComboPreviewData()
        {
            fixed (ImGuiComboPreviewData* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}