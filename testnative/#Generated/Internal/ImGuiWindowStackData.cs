// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace Mochi.DearImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct ImGuiWindowStackData
    {
        [FieldOffset(0)] public ImGuiWindow* Window;

        [FieldOffset(8)] public ImGuiLastItemData ParentLastItemDataBackup;

        [FieldOffset(68)] public ImGuiStackSizes StackSizesOnBegin;
    }
}
