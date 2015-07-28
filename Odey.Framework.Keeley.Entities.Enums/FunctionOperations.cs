using System;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [Flags]
    public enum FunctionOperations
    {
        None =        0,
        Create = 1 << 0,
        Read =   1 << 1,
        Update = 1 << 2,
        Delete = 1 << 3,
    }
}