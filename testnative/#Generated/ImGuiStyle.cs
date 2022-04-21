// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.DearImGui.Infrastructure;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 1080)]
    public unsafe partial struct ImGuiStyle
    {
        [FieldOffset(0)] public float Alpha;

        [FieldOffset(4)] public float DisabledAlpha;

        [FieldOffset(8)] public Vector2 WindowPadding;

        [FieldOffset(16)] public float WindowRounding;

        [FieldOffset(20)] public float WindowBorderSize;

        [FieldOffset(24)] public Vector2 WindowMinSize;

        [FieldOffset(32)] public Vector2 WindowTitleAlign;

        [FieldOffset(40)] public ImGuiDir WindowMenuButtonPosition;

        [FieldOffset(44)] public float ChildRounding;

        [FieldOffset(48)] public float ChildBorderSize;

        [FieldOffset(52)] public float PopupRounding;

        [FieldOffset(56)] public float PopupBorderSize;

        [FieldOffset(60)] public Vector2 FramePadding;

        [FieldOffset(68)] public float FrameRounding;

        [FieldOffset(72)] public float FrameBorderSize;

        [FieldOffset(76)] public Vector2 ItemSpacing;

        [FieldOffset(84)] public Vector2 ItemInnerSpacing;

        [FieldOffset(92)] public Vector2 CellPadding;

        [FieldOffset(100)] public Vector2 TouchExtraPadding;

        [FieldOffset(108)] public float IndentSpacing;

        [FieldOffset(112)] public float ColumnsMinSpacing;

        [FieldOffset(116)] public float ScrollbarSize;

        [FieldOffset(120)] public float ScrollbarRounding;

        [FieldOffset(124)] public float GrabMinSize;

        [FieldOffset(128)] public float GrabRounding;

        [FieldOffset(132)] public float LogSliderDeadzone;

        [FieldOffset(136)] public float TabRounding;

        [FieldOffset(140)] public float TabBorderSize;

        [FieldOffset(144)] public float TabMinWidthForCloseButton;

        [FieldOffset(148)] public ImGuiDir ColorButtonPosition;

        [FieldOffset(152)] public Vector2 ButtonTextAlign;

        [FieldOffset(160)] public Vector2 SelectableTextAlign;

        [FieldOffset(168)] public Vector2 DisplayWindowPadding;

        [FieldOffset(176)] public Vector2 DisplaySafeAreaPadding;

        [FieldOffset(184)] public float MouseCursorScale;

        [FieldOffset(188)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedLines;

        [FieldOffset(189)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedLinesUseTex;

        [FieldOffset(190)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedFill;

        [FieldOffset(192)] public float CurveTessellationTol;

        [FieldOffset(196)] public float CircleTessellationMaxError;

        [FieldOffset(200)] public ConstantArray_ImVec4_55 Colors;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiStyle@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiStyle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiStyle()
        {
            fixed (ImGuiStyle* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ScaleAllSizes@ImGuiStyle@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void ScaleAllSizes_PInvoke(ImGuiStyle* @this, float scale_factor);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ScaleAllSizes(float scale_factor)
        {
            fixed (ImGuiStyle* @this = &this)
            { ScaleAllSizes_PInvoke(@this, scale_factor); }
        }
    }
}