using ChocolArm64.Instructions;

namespace ChocolArm64.Decoders
{
    class OpCodeMemReg64 : OpCodeMem64
    {
        public bool Shift { get; private set; }
        public int  Rm    { get; private set; }

        public IntType IntType { get; private set; }

        public OpCodeMemReg64(Inst inst, long position, int opCode) : base(inst, position, opCode)
        {
            Shift    =          ((opCode >> 12) & 0x1) != 0;
            IntType  = (IntType)((opCode >> 13) & 0x7);
            Rm       =           (opCode >> 16) & 0x1f;
            Extend64 =          ((opCode >> 22) & 0x3) == 2;
        }
    }
}