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
    [StructLayout(LayoutKind.Explicit, Size = 14208, CharSet = CharSet.Unicode)]
    public unsafe partial struct ImGuiIO
    {
        [FieldOffset(0)] public ImGuiConfigFlags ConfigFlags;

        [FieldOffset(4)] public ImGuiBackendFlags BackendFlags;

        [FieldOffset(8)] public Vector2 DisplaySize;

        [FieldOffset(16)] public float DeltaTime;

        [FieldOffset(20)] public float IniSavingRate;

        [FieldOffset(24)] public byte* IniFilename;

        [FieldOffset(32)] public byte* LogFilename;

        [FieldOffset(40)] public float MouseDoubleClickTime;

        [FieldOffset(44)] public float MouseDoubleClickMaxDist;

        [FieldOffset(48)] public float MouseDragThreshold;

        [FieldOffset(52)] public float KeyRepeatDelay;

        [FieldOffset(56)] public float KeyRepeatRate;

        [FieldOffset(64)] public void* UserData;

        [FieldOffset(72)] public ImFontAtlas* Fonts;

        [FieldOffset(80)] public float FontGlobalScale;

        [FieldOffset(84)] [MarshalAs(UnmanagedType.I1)] public bool FontAllowUserScaling;

        [FieldOffset(88)] public ImFont* FontDefault;

        [FieldOffset(96)] public Vector2 DisplayFramebufferScale;

        [FieldOffset(104)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingNoSplit;

        [FieldOffset(105)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingWithShift;

        [FieldOffset(106)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingAlwaysTabBar;

        [FieldOffset(107)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingTransparentPayload;

        [FieldOffset(108)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoAutoMerge;

        [FieldOffset(109)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoTaskBarIcon;

        [FieldOffset(110)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoDecoration;

        [FieldOffset(111)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoDefaultParent;

        [FieldOffset(112)] [MarshalAs(UnmanagedType.I1)] public bool MouseDrawCursor;

        [FieldOffset(113)] [MarshalAs(UnmanagedType.I1)] public bool ConfigMacOSXBehaviors;

        [FieldOffset(114)] [MarshalAs(UnmanagedType.I1)] public bool ConfigInputTrickleEventQueue;

        [FieldOffset(115)] [MarshalAs(UnmanagedType.I1)] public bool ConfigInputTextCursorBlink;

        [FieldOffset(116)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDragClickToInputText;

        [FieldOffset(117)] [MarshalAs(UnmanagedType.I1)] public bool ConfigWindowsResizeFromEdges;

        [FieldOffset(118)] [MarshalAs(UnmanagedType.I1)] public bool ConfigWindowsMoveFromTitleBarOnly;

        [FieldOffset(120)] public float ConfigMemoryCompactTimer;

        [FieldOffset(128)] public byte* BackendPlatformName;

        [FieldOffset(136)] public byte* BackendRendererName;

        [FieldOffset(144)] public void* BackendPlatformUserData;

        [FieldOffset(152)] public void* BackendRendererUserData;

        [FieldOffset(160)] public void* BackendLanguageUserData;

        [FieldOffset(168)] public delegate* unmanaged[Cdecl]<void*, byte*> GetClipboardTextFn;

        [FieldOffset(176)] public delegate* unmanaged[Cdecl]<void*, byte*, void> SetClipboardTextFn;

        [FieldOffset(184)] public void* ClipboardUserData;

        [FieldOffset(192)] public delegate* unmanaged[Cdecl]<ImGuiViewport*, ImGuiPlatformImeData*, void> SetPlatformImeDataFn;

        [FieldOffset(200)] public void* _UnusedPadding;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddKeyEvent@ImGuiIO@@QEAAXH_N@Z", ExactSpelling = true)]
        private static extern void AddKeyEvent_PInvoke(ImGuiIO* @this, ImGuiKey key, byte down);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddKeyEvent(ImGuiKey key, bool down)
        {
            fixed (ImGuiIO* @this = &this)
            { AddKeyEvent_PInvoke(@this, key, Unsafe.As<bool, byte>(ref down)); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddKeyAnalogEvent@ImGuiIO@@QEAAXH_NM@Z", ExactSpelling = true)]
        private static extern void AddKeyAnalogEvent_PInvoke(ImGuiIO* @this, ImGuiKey key, byte down, float v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddKeyAnalogEvent(ImGuiKey key, bool down, float v)
        {
            fixed (ImGuiIO* @this = &this)
            { AddKeyAnalogEvent_PInvoke(@this, key, Unsafe.As<bool, byte>(ref down), v); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddMousePosEvent@ImGuiIO@@QEAAXMM@Z", ExactSpelling = true)]
        private static extern void AddMousePosEvent_PInvoke(ImGuiIO* @this, float x, float y);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddMousePosEvent(float x, float y)
        {
            fixed (ImGuiIO* @this = &this)
            { AddMousePosEvent_PInvoke(@this, x, y); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddMouseButtonEvent@ImGuiIO@@QEAAXH_N@Z", ExactSpelling = true)]
        private static extern void AddMouseButtonEvent_PInvoke(ImGuiIO* @this, int button, byte down);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddMouseButtonEvent(int button, bool down)
        {
            fixed (ImGuiIO* @this = &this)
            { AddMouseButtonEvent_PInvoke(@this, button, Unsafe.As<bool, byte>(ref down)); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddMouseWheelEvent@ImGuiIO@@QEAAXMM@Z", ExactSpelling = true)]
        private static extern void AddMouseWheelEvent_PInvoke(ImGuiIO* @this, float wh_x, float wh_y);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddMouseWheelEvent(float wh_x, float wh_y)
        {
            fixed (ImGuiIO* @this = &this)
            { AddMouseWheelEvent_PInvoke(@this, wh_x, wh_y); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddMouseViewportEvent@ImGuiIO@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void AddMouseViewportEvent_PInvoke(ImGuiIO* @this, uint id);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddMouseViewportEvent(uint id)
        {
            fixed (ImGuiIO* @this = &this)
            { AddMouseViewportEvent_PInvoke(@this, id); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddFocusEvent@ImGuiIO@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void AddFocusEvent_PInvoke(ImGuiIO* @this, byte focused);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddFocusEvent(bool focused)
        {
            fixed (ImGuiIO* @this = &this)
            { AddFocusEvent_PInvoke(@this, Unsafe.As<bool, byte>(ref focused)); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharacter@ImGuiIO@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void AddInputCharacter_PInvoke(ImGuiIO* @this, uint c);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddInputCharacter(uint c)
        {
            fixed (ImGuiIO* @this = &this)
            { AddInputCharacter_PInvoke(@this, c); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharacterUTF16@ImGuiIO@@QEAAXG@Z", ExactSpelling = true)]
        private static extern void AddInputCharacterUTF16_PInvoke(ImGuiIO* @this, char c);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddInputCharacterUTF16(char c)
        {
            fixed (ImGuiIO* @this = &this)
            { AddInputCharacterUTF16_PInvoke(@this, c); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharactersUTF8@ImGuiIO@@QEAAXPEBD@Z", ExactSpelling = true)]
        private static extern void AddInputCharactersUTF8_PInvoke(ImGuiIO* @this, byte* str);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddInputCharactersUTF8(byte* str)
        {
            fixed (ImGuiIO* @this = &this)
            { AddInputCharactersUTF8_PInvoke(@this, str); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearInputCharacters@ImGuiIO@@QEAAXXZ", ExactSpelling = true)]
        private static extern void ClearInputCharacters_PInvoke(ImGuiIO* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearInputCharacters()
        {
            fixed (ImGuiIO* @this = &this)
            { ClearInputCharacters_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearInputKeys@ImGuiIO@@QEAAXXZ", ExactSpelling = true)]
        private static extern void ClearInputKeys_PInvoke(ImGuiIO* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearInputKeys()
        {
            fixed (ImGuiIO* @this = &this)
            { ClearInputKeys_PInvoke(@this); }
        }

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetKeyEventNativeData@ImGuiIO@@QEAAXHHHH@Z", ExactSpelling = true)]
        private static extern void SetKeyEventNativeData_PInvoke(ImGuiIO* @this, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index = -1)
        {
            fixed (ImGuiIO* @this = &this)
            { SetKeyEventNativeData_PInvoke(@this, key, native_keycode, native_scancode, native_legacy_index); }
        }

        [FieldOffset(208)] [MarshalAs(UnmanagedType.I1)] public bool WantCaptureMouse;

        [FieldOffset(209)] [MarshalAs(UnmanagedType.I1)] public bool WantCaptureKeyboard;

        [FieldOffset(210)] [MarshalAs(UnmanagedType.I1)] public bool WantTextInput;

        [FieldOffset(211)] [MarshalAs(UnmanagedType.I1)] public bool WantSetMousePos;

        [FieldOffset(212)] [MarshalAs(UnmanagedType.I1)] public bool WantSaveIniSettings;

        [FieldOffset(213)] [MarshalAs(UnmanagedType.I1)] public bool NavActive;

        [FieldOffset(214)] [MarshalAs(UnmanagedType.I1)] public bool NavVisible;

        [FieldOffset(216)] public float Framerate;

        [FieldOffset(220)] public int MetricsRenderVertices;

        [FieldOffset(224)] public int MetricsRenderIndices;

        [FieldOffset(228)] public int MetricsRenderWindows;

        [FieldOffset(232)] public int MetricsActiveWindows;

        [FieldOffset(236)] public int MetricsActiveAllocations;

        [FieldOffset(240)] public Vector2 MouseDelta;

        [FieldOffset(248)] public ConstantArray_int_645 KeyMap;

        [FieldOffset(2828)] public ConstantArray_bool_512 KeysDown;

        [FieldOffset(3340)] public Vector2 MousePos;

        [FieldOffset(3348)] public ConstantArray_bool_5 MouseDown;

        [FieldOffset(3356)] public float MouseWheel;

        [FieldOffset(3360)] public float MouseWheelH;

        [FieldOffset(3364)] public uint MouseHoveredViewport;

        [FieldOffset(3368)] [MarshalAs(UnmanagedType.I1)] public bool KeyCtrl;

        [FieldOffset(3369)] [MarshalAs(UnmanagedType.I1)] public bool KeyShift;

        [FieldOffset(3370)] [MarshalAs(UnmanagedType.I1)] public bool KeyAlt;

        [FieldOffset(3371)] [MarshalAs(UnmanagedType.I1)] public bool KeySuper;

        [FieldOffset(3372)] public ConstantArray_float_20 NavInputs;

        [FieldOffset(3452)] public ImGuiKeyModFlags KeyMods;

        [FieldOffset(3456)] public ImGuiKeyModFlags KeyModsPrev;

        [FieldOffset(3460)] public ConstantArray_ImGuiKeyData_645 KeysData;

        [FieldOffset(13780)] [MarshalAs(UnmanagedType.I1)] public bool WantCaptureMouseUnlessPopupClose;

        [FieldOffset(13784)] public Vector2 MousePosPrev;

        [FieldOffset(13792)] public ConstantArray_ImVec2_5 MouseClickedPos;

        [FieldOffset(13832)] public ConstantArray_double_5 MouseClickedTime;

        [FieldOffset(13872)] public ConstantArray_bool_5 MouseClicked;

        [FieldOffset(13877)] public ConstantArray_bool_5 MouseDoubleClicked;

        [FieldOffset(13882)] public ConstantArray_ImU16_5 MouseClickedCount;

        [FieldOffset(13892)] public ConstantArray_ImU16_5 MouseClickedLastCount;

        [FieldOffset(13902)] public ConstantArray_bool_5 MouseReleased;

        [FieldOffset(13907)] public ConstantArray_bool_5 MouseDownOwned;

        [FieldOffset(13912)] public ConstantArray_bool_5 MouseDownOwnedUnlessPopupClose;

        [FieldOffset(13920)] public ConstantArray_float_5 MouseDownDuration;

        [FieldOffset(13940)] public ConstantArray_float_5 MouseDownDurationPrev;

        [FieldOffset(13960)] public ConstantArray_ImVec2_5 MouseDragMaxDistanceAbs;

        [FieldOffset(14000)] public ConstantArray_float_5 MouseDragMaxDistanceSqr;

        [FieldOffset(14020)] public ConstantArray_float_20 NavInputsDownDuration;

        [FieldOffset(14100)] public ConstantArray_float_20 NavInputsDownDurationPrev;

        [FieldOffset(14180)] public float PenPressure;

        [FieldOffset(14184)] [MarshalAs(UnmanagedType.I1)] public bool AppFocusLost;

        [FieldOffset(14185)] public sbyte BackendUsingLegacyKeyArrays;

        [FieldOffset(14186)] [MarshalAs(UnmanagedType.I1)] public bool BackendUsingLegacyNavInputArray;

        [FieldOffset(14188)] public char InputQueueSurrogate;

        [FieldOffset(14192)] public ImVector<ushort> InputQueueCharacters;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiIO@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiIO* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiIO()
        {
            fixed (ImGuiIO* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}
