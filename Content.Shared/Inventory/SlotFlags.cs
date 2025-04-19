using Robust.Shared.Serialization;

namespace Content.Shared.Inventory;

/// <summary>
///     Defines what slot types an item can fit into.
/// </summary>
[Serializable, NetSerializable]
[Flags]
public enum SlotFlags
{
    NONE = 0,
    PREVENTEQUIP = 1 << 0,
	ANAL = 1 << 1,
	PANTS = 1 << 2,
	BRA = 1 << 3,
    HEAD = 1 << 4,
    EYES = 1 << 5,
    EARS = 1 << 6,
    MASK = 1 << 7,
    OUTERCLOTHING = 1 << 8,
    INNERCLOTHING = 1 << 9,
    NECK = 1 << 10,
    BACK = 1 << 11,
    BELT = 1 << 12,
    GLOVES = 1 << 13,
    IDCARD = 1 << 14,
    POCKET = 1 << 15,
    LEGS = 1 << 16,
    FEET = 1 << 17,
    SUITSTORAGE = 1 << 18,
    All = ~NONE,

    WITHOUT_POCKET = All & ~POCKET
}
