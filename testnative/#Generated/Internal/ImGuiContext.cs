// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.DearImGui.Infrastructure;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 25536)]
    public unsafe partial struct ImGuiContext
    {
        [FieldOffset(0)] [MarshalAs(UnmanagedType.I1)] public bool Initialized;

        [FieldOffset(1)] [MarshalAs(UnmanagedType.I1)] public bool FontAtlasOwnedByContext;

        [FieldOffset(8)] public ImGuiIO IO;

        [FieldOffset(14216)] public ImGuiPlatformIO PlatformIO;

        [FieldOffset(14432)] public ImVector<ImGuiInputEvent> InputEventsQueue;

        [FieldOffset(14448)] public ImVector<ImGuiInputEvent> InputEventsTrail;

        [FieldOffset(14464)] public ImGuiStyle Style;

        [FieldOffset(15544)] public ImGuiConfigFlags ConfigFlagsCurrFrame;

        [FieldOffset(15548)] public ImGuiConfigFlags ConfigFlagsLastFrame;

        [FieldOffset(15552)] public ImFont* Font;

        [FieldOffset(15560)] public float FontSize;

        [FieldOffset(15564)] public float FontBaseSize;

        [FieldOffset(15568)] public ImDrawListSharedData DrawListSharedData;

        [FieldOffset(16080)] public double Time;

        [FieldOffset(16088)] public int FrameCount;

        [FieldOffset(16092)] public int FrameCountEnded;

        [FieldOffset(16096)] public int FrameCountPlatformEnded;

        [FieldOffset(16100)] public int FrameCountRendered;

        [FieldOffset(16104)] [MarshalAs(UnmanagedType.I1)] public bool WithinFrameScope;

        [FieldOffset(16105)] [MarshalAs(UnmanagedType.I1)] public bool WithinFrameScopeWithImplicitWindow;

        [FieldOffset(16106)] [MarshalAs(UnmanagedType.I1)] public bool WithinEndChild;

        [FieldOffset(16107)] [MarshalAs(UnmanagedType.I1)] public bool GcCompactAll;

        [FieldOffset(16108)] [MarshalAs(UnmanagedType.I1)] public bool TestEngineHookItems;

        [FieldOffset(16112)] public void* TestEngine;

        [FieldOffset(16120)] public ImVector<Pointer<ImGuiWindow>> Windows;

        [FieldOffset(16136)] public ImVector<Pointer<ImGuiWindow>> WindowsFocusOrder;

        [FieldOffset(16152)] public ImVector<Pointer<ImGuiWindow>> WindowsTempSortBuffer;

        [FieldOffset(16168)] public ImVector<ImGuiWindowStackData> CurrentWindowStack;

        [FieldOffset(16184)] public ImGuiStorage WindowsById;

        [FieldOffset(16200)] public int WindowsActiveCount;

        [FieldOffset(16204)] public Vector2 WindowsHoverPadding;

        [FieldOffset(16216)] public ImGuiWindow* CurrentWindow;

        [FieldOffset(16224)] public ImGuiWindow* HoveredWindow;

        [FieldOffset(16232)] public ImGuiWindow* HoveredWindowUnderMovingWindow;

        [FieldOffset(16240)] public ImGuiDockNode* HoveredDockNode;

        [FieldOffset(16248)] public ImGuiWindow* MovingWindow;

        [FieldOffset(16256)] public ImGuiWindow* WheelingWindow;

        [FieldOffset(16264)] public Vector2 WheelingWindowRefMousePos;

        [FieldOffset(16272)] public float WheelingWindowTimer;

        [FieldOffset(16276)] public uint DebugHookIdInfo;

        [FieldOffset(16280)] public uint HoveredId;

        [FieldOffset(16284)] public uint HoveredIdPreviousFrame;

        [FieldOffset(16288)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdAllowOverlap;

        [FieldOffset(16289)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdUsingMouseWheel;

        [FieldOffset(16290)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdPreviousFrameUsingMouseWheel;

        [FieldOffset(16291)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdDisabled;

        [FieldOffset(16292)] public float HoveredIdTimer;

        [FieldOffset(16296)] public float HoveredIdNotActiveTimer;

        [FieldOffset(16300)] public uint ActiveId;

        [FieldOffset(16304)] public uint ActiveIdIsAlive;

        [FieldOffset(16308)] public float ActiveIdTimer;

        [FieldOffset(16312)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdIsJustActivated;

        [FieldOffset(16313)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdAllowOverlap;

        [FieldOffset(16314)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdNoClearOnFocusLoss;

        [FieldOffset(16315)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenPressedBefore;

        [FieldOffset(16316)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenEditedBefore;

        [FieldOffset(16317)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenEditedThisFrame;

        [FieldOffset(16318)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdUsingMouseWheel;

        [FieldOffset(16320)] public uint ActiveIdUsingNavDirMask;

        [FieldOffset(16324)] public uint ActiveIdUsingNavInputMask;

        [FieldOffset(16348)] public Vector2 ActiveIdClickOffset;

        [FieldOffset(16360)] public ImGuiWindow* ActiveIdWindow;

        [FieldOffset(16368)] public ImGuiInputSource ActiveIdSource;

        [FieldOffset(16372)] public int ActiveIdMouseButton;

        [FieldOffset(16376)] public uint ActiveIdPreviousFrame;

        [FieldOffset(16380)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdPreviousFrameIsAlive;

        [FieldOffset(16381)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdPreviousFrameHasBeenEditedBefore;

        [FieldOffset(16384)] public ImGuiWindow* ActiveIdPreviousFrameWindow;

        [FieldOffset(16392)] public uint LastActiveId;

        [FieldOffset(16396)] public float LastActiveIdTimer;

        [FieldOffset(16400)] public ImGuiItemFlags CurrentItemFlags;

        [FieldOffset(16404)] public ImGuiNextItemData NextItemData;

        [FieldOffset(16424)] public ImGuiLastItemData LastItemData;

        [FieldOffset(16488)] public ImGuiNextWindowData NextWindowData;

        [FieldOffset(16632)] public ImVector<ImGuiColorMod> ColorStack;

        [FieldOffset(16648)] public ImVector<ImGuiStyleMod> StyleVarStack;

        [FieldOffset(16664)] public ImVector<Pointer<ImFont>> FontStack;

        [FieldOffset(16680)] public ImVector<uint> FocusScopeStack;

        [FieldOffset(16696)] public ImVector<int> ItemFlagsStack;

        [FieldOffset(16712)] public ImVector<ImGuiGroupData> GroupStack;

        [FieldOffset(16728)] public ImVector<ImGuiPopupData> OpenPopupStack;

        [FieldOffset(16744)] public ImVector<ImGuiPopupData> BeginPopupStack;

        [FieldOffset(16760)] public int BeginMenuCount;

        [FieldOffset(16768)] public ImVector<Pointer<ImGuiViewportP>> Viewports;

        [FieldOffset(16784)] public float CurrentDpiScale;

        [FieldOffset(16792)] public ImGuiViewportP* CurrentViewport;

        [FieldOffset(16800)] public ImGuiViewportP* MouseViewport;

        [FieldOffset(16808)] public ImGuiViewportP* MouseLastHoveredViewport;

        [FieldOffset(16816)] public uint PlatformLastFocusedViewportId;

        [FieldOffset(16820)] public ImGuiPlatformMonitor FallbackMonitor;

        [FieldOffset(16856)] public int ViewportFrontMostStampCount;

        [FieldOffset(16864)] public ImGuiWindow* NavWindow;

        [FieldOffset(16872)] public uint NavId;

        [FieldOffset(16876)] public uint NavFocusScopeId;

        [FieldOffset(16880)] public uint NavActivateId;

        [FieldOffset(16884)] public uint NavActivateDownId;

        [FieldOffset(16888)] public uint NavActivatePressedId;

        [FieldOffset(16892)] public uint NavActivateInputId;

        [FieldOffset(16896)] public ImGuiActivateFlags NavActivateFlags;

        [FieldOffset(16900)] public uint NavJustMovedToId;

        [FieldOffset(16904)] public uint NavJustMovedToFocusScopeId;

        [FieldOffset(16908)] public ImGuiKeyModFlags NavJustMovedToKeyMods;

        [FieldOffset(16912)] public uint NavNextActivateId;

        [FieldOffset(16916)] public ImGuiActivateFlags NavNextActivateFlags;

        [FieldOffset(16920)] public ImGuiInputSource NavInputSource;

        [FieldOffset(16924)] public ImGuiNavLayer NavLayer;

        [FieldOffset(16928)] [MarshalAs(UnmanagedType.I1)] public bool NavIdIsAlive;

        [FieldOffset(16929)] [MarshalAs(UnmanagedType.I1)] public bool NavMousePosDirty;

        [FieldOffset(16930)] [MarshalAs(UnmanagedType.I1)] public bool NavDisableHighlight;

        [FieldOffset(16931)] [MarshalAs(UnmanagedType.I1)] public bool NavDisableMouseHover;

        [FieldOffset(16932)] [MarshalAs(UnmanagedType.I1)] public bool NavAnyRequest;

        [FieldOffset(16933)] [MarshalAs(UnmanagedType.I1)] public bool NavInitRequest;

        [FieldOffset(16934)] [MarshalAs(UnmanagedType.I1)] public bool NavInitRequestFromMove;

        [FieldOffset(16936)] public uint NavInitResultId;

        [FieldOffset(16940)] public ImRect NavInitResultRectRel;

        [FieldOffset(16956)] [MarshalAs(UnmanagedType.I1)] public bool NavMoveSubmitted;

        [FieldOffset(16957)] [MarshalAs(UnmanagedType.I1)] public bool NavMoveScoringItems;

        [FieldOffset(16958)] [MarshalAs(UnmanagedType.I1)] public bool NavMoveForwardToNextFrame;

        [FieldOffset(16960)] public ImGuiNavMoveFlags NavMoveFlags;

        [FieldOffset(16964)] public ImGuiScrollFlags NavMoveScrollFlags;

        [FieldOffset(16968)] public ImGuiKeyModFlags NavMoveKeyMods;

        [FieldOffset(16972)] public ImGuiDir NavMoveDir;

        [FieldOffset(16976)] public ImGuiDir NavMoveDirForDebug;

        [FieldOffset(16980)] public ImGuiDir NavMoveClipDir;

        [FieldOffset(16984)] public ImRect NavScoringRect;

        [FieldOffset(17000)] public ImRect NavScoringNoClipRect;

        [FieldOffset(17016)] public int NavScoringDebugCount;

        [FieldOffset(17020)] public int NavTabbingDir;

        [FieldOffset(17024)] public int NavTabbingCounter;

        [FieldOffset(17032)] public ImGuiNavItemData NavMoveResultLocal;

        [FieldOffset(17080)] public ImGuiNavItemData NavMoveResultLocalVisible;

        [FieldOffset(17128)] public ImGuiNavItemData NavMoveResultOther;

        [FieldOffset(17176)] public ImGuiNavItemData NavTabbingResultFirst;

        [FieldOffset(17224)] public ImGuiWindow* NavWindowingTarget;

        [FieldOffset(17232)] public ImGuiWindow* NavWindowingTargetAnim;

        [FieldOffset(17240)] public ImGuiWindow* NavWindowingListWindow;

        [FieldOffset(17248)] public float NavWindowingTimer;

        [FieldOffset(17252)] public float NavWindowingHighlightAlpha;

        [FieldOffset(17256)] [MarshalAs(UnmanagedType.I1)] public bool NavWindowingToggleLayer;

        [FieldOffset(17260)] public float DimBgRatio;

        [FieldOffset(17264)] public ImGuiMouseCursor MouseCursor;

        [FieldOffset(17268)] [MarshalAs(UnmanagedType.I1)] public bool DragDropActive;

        [FieldOffset(17269)] [MarshalAs(UnmanagedType.I1)] public bool DragDropWithinSource;

        [FieldOffset(17270)] [MarshalAs(UnmanagedType.I1)] public bool DragDropWithinTarget;

        [FieldOffset(17272)] public ImGuiDragDropFlags DragDropSourceFlags;

        [FieldOffset(17276)] public int DragDropSourceFrameCount;

        [FieldOffset(17280)] public int DragDropMouseButton;

        [FieldOffset(17288)] public ImGuiPayload DragDropPayload;

        [FieldOffset(17352)] public ImRect DragDropTargetRect;

        [FieldOffset(17368)] public uint DragDropTargetId;

        [FieldOffset(17372)] public ImGuiDragDropFlags DragDropAcceptFlags;

        [FieldOffset(17376)] public float DragDropAcceptIdCurrRectSurface;

        [FieldOffset(17380)] public uint DragDropAcceptIdCurr;

        [FieldOffset(17384)] public uint DragDropAcceptIdPrev;

        [FieldOffset(17388)] public int DragDropAcceptFrameCount;

        [FieldOffset(17392)] public uint DragDropHoldJustPressedId;

        [FieldOffset(17400)] public ImVector<byte> DragDropPayloadBufHeap;

        [FieldOffset(17416)] public ConstantArray_unsigned__UNICODE_0020__char_16 DragDropPayloadBufLocal;

        [FieldOffset(17432)] public int ClipperTempDataStacked;

        [FieldOffset(17440)] public ImVector<ImGuiListClipperData> ClipperTempData;

        [FieldOffset(17456)] public ImGuiTable* CurrentTable;

        [FieldOffset(17464)] public int TablesTempDataStacked;

        [FieldOffset(17472)] public ImVector<ImGuiTableTempData> TablesTempData;

        [FieldOffset(17528)] public ImVector<float> TablesLastTimeActive;

        [FieldOffset(17544)] public ImVector<ImDrawChannel> DrawChannelsTempMergeBuffer;

        [FieldOffset(17560)] public ImGuiTabBar* CurrentTabBar;

        [FieldOffset(17608)] public ImVector<ImGuiPtrOrIndex> CurrentTabBarStack;

        [FieldOffset(17624)] public ImVector<ImGuiShrinkWidthItem> ShrinkWidthBuffer;

        [FieldOffset(17640)] public Vector2 MouseLastValidPos;

        [FieldOffset(17648)] public ImGuiInputTextState InputTextState;

        [FieldOffset(21368)] public ImFont InputTextPasswordFont;

        [FieldOffset(21480)] public uint TempInputId;

        [FieldOffset(21484)] public ImGuiColorEditFlags ColorEditOptions;

        [FieldOffset(21488)] public float ColorEditLastHue;

        [FieldOffset(21492)] public float ColorEditLastSat;

        [FieldOffset(21496)] public uint ColorEditLastColor;

        [FieldOffset(21500)] public Vector4 ColorPickerRef;

        [FieldOffset(21516)] public ImGuiComboPreviewData ComboPreviewData;

        [FieldOffset(21564)] public float SliderCurrentAccum;

        [FieldOffset(21568)] [MarshalAs(UnmanagedType.I1)] public bool SliderCurrentAccumDirty;

        [FieldOffset(21569)] [MarshalAs(UnmanagedType.I1)] public bool DragCurrentAccumDirty;

        [FieldOffset(21572)] public float DragCurrentAccum;

        [FieldOffset(21576)] public float DragSpeedDefaultRatio;

        [FieldOffset(21580)] public float ScrollbarClickDeltaToGrabCenter;

        [FieldOffset(21584)] public float DisabledAlphaBackup;

        [FieldOffset(21588)] public short DisabledStackSize;

        [FieldOffset(21590)] public short TooltipOverrideCount;

        [FieldOffset(21592)] public float TooltipSlowDelay;

        [FieldOffset(21600)] public ImVector<byte> ClipboardHandlerData;

        [FieldOffset(21616)] public ImVector<uint> MenusIdSubmittedThisFrame;

        [FieldOffset(21632)] public ImGuiPlatformImeData PlatformImeData;

        [FieldOffset(21648)] public ImGuiPlatformImeData PlatformImeDataPrev;

        [FieldOffset(21664)] public uint PlatformImeViewport;

        [FieldOffset(21668)] public byte PlatformLocaleDecimalPoint;

        [FieldOffset(21672)] public ImGuiDockContext DockContext;

        [FieldOffset(21728)] [MarshalAs(UnmanagedType.I1)] public bool SettingsLoaded;

        [FieldOffset(21732)] public float SettingsDirtyTimer;

        [FieldOffset(21736)] public ImGuiTextBuffer SettingsIniData;

        [FieldOffset(21752)] public ImVector<ImGuiSettingsHandler> SettingsHandlers;

        [FieldOffset(21800)] public ImVector<ImGuiContextHook> Hooks;

        [FieldOffset(21816)] public uint HookIdNext;

        [FieldOffset(21820)] [MarshalAs(UnmanagedType.I1)] public bool LogEnabled;

        [FieldOffset(21824)] public ImGuiLogType LogType;

        [FieldOffset(21832)] public void* LogFile;

        [FieldOffset(21840)] public ImGuiTextBuffer LogBuffer;

        [FieldOffset(21856)] public byte* LogNextPrefix;

        [FieldOffset(21864)] public byte* LogNextSuffix;

        [FieldOffset(21872)] public float LogLinePosY;

        [FieldOffset(21876)] [MarshalAs(UnmanagedType.I1)] public bool LogLineFirstItem;

        [FieldOffset(21880)] public int LogDepthRef;

        [FieldOffset(21884)] public int LogDepthToExpand;

        [FieldOffset(21888)] public int LogDepthToExpandDefault;

        [FieldOffset(21892)] [MarshalAs(UnmanagedType.I1)] public bool DebugItemPickerActive;

        [FieldOffset(21896)] public uint DebugItemPickerBreakId;

        [FieldOffset(21900)] public ImGuiMetricsConfig DebugMetricsConfig;

        [FieldOffset(21920)] public ImGuiStackTool DebugStackTool;

        [FieldOffset(21952)] public ConstantArray_float_120 FramerateSecPerFrame;

        [FieldOffset(22432)] public int FramerateSecPerFrameIdx;

        [FieldOffset(22436)] public int FramerateSecPerFrameCount;

        [FieldOffset(22440)] public float FramerateSecPerFrameAccum;

        [FieldOffset(22444)] public int WantCaptureMouseNextFrame;

        [FieldOffset(22448)] public int WantCaptureKeyboardNextFrame;

        [FieldOffset(22452)] public int WantTextInputNextFrame;

        [FieldOffset(22456)] public ConstantArray_char_3073 TempBuffer;

        [DllImport("Mochi.DearImGui.Native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper55", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiContext* @this, ImFontAtlas* shared_font_atlas);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImGuiContext(ImFontAtlas* shared_font_atlas)
        {
            fixed (ImGuiContext* @this = &this)
            { Constructor_PInvoke(@this, shared_font_atlas); }
        }
    }
}