// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace Mochi.DearImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct ImFontGlyph
    {
        [FieldOffset(0)] private uint __Colored__backingField;
        public uint Colored
        {
            get => (__Colored__backingField >> 0) & 0x1U;
            set
            {
                uint shiftedValue = (value & 0x1U) << 0;
                uint otherBits = __Colored__backingField & 0xFFFFFFFEU;
                __Colored__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(0)] private uint __Visible__backingField;
        public uint Visible
        {
            get => (__Visible__backingField >> 1) & 0x1U;
            set
            {
                uint shiftedValue = (value & 0x1U) << 1;
                uint otherBits = __Visible__backingField & 0xFFFFFFFDU;
                __Visible__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(0)] private uint __Codepoint__backingField;
        public uint Codepoint
        {
            get => (__Codepoint__backingField >> 2) & 0x3FFFFFFFU;
            set
            {
                uint shiftedValue = (value & 0x3FFFFFFFU) << 2;
                uint otherBits = __Codepoint__backingField & 0x3U;
                __Codepoint__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(4)] public float AdvanceX;

        [FieldOffset(8)] public float X0;

        [FieldOffset(12)] public float Y0;

        [FieldOffset(16)] public float X1;

        [FieldOffset(20)] public float Y1;

        [FieldOffset(24)] public float U0;

        [FieldOffset(28)] public float V0;

        [FieldOffset(32)] public float U1;

        [FieldOffset(36)] public float V1;
    }
}
