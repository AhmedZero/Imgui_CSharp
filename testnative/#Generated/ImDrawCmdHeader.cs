// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Numerics;
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct ImDrawCmdHeader
    {
        [FieldOffset(0)] public Vector4 ClipRect;

        [FieldOffset(16)] public void* TextureId;

        [FieldOffset(24)] public uint VtxOffset;
    }
}
