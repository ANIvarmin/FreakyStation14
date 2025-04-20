using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;

namespace Content.Shared.Actions
{
    [RegisterComponent]
    public partial class ActionSpawnOnUseComponent : Component
    {
        [DataField("spawnPrototype")]
        public string SpawnPrototype { get; set; } = string.Empty;

        [DataField("spawnSlot")]
        public string SpawnSlot { get; set; } = string.Empty;

        [DataField("removeOnSecondUse")]
        public bool RemoveOnSecondUse { get; set; } = false;

        [DataField("dropPreviousItem")]
        public bool DropPreviousItem { get; set; } = false;

        // Хранит идентификатор спавненного предмета
        [DataField("spawnedItem")]
        public EntityUid? SpawnedItem { get; set; }
    }
}
