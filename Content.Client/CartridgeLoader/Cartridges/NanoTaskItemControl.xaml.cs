using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Maths;
using Content.Shared.CartridgeLoader.Cartridges;

namespace Content.Client.CartridgeLoader.Cartridges;

/// <summary>
///     Represents a single control for a single NanoTask item
/// </summary>
[GenerateTypedNameReferences]
public sealed partial class NanoTaskItemControl : Control
{
    public Action<int>? OnMainPressed;
    public Action<int>? OnDonePressed;

    public NanoTaskItemControl(NanoTaskItemAndId item)
    {
        RobustXamlLoader.Load(this);

        TaskLabel.Text = item.Data.Description;
        TaskLabel.FontColorOverride = Color.White;
        TaskForLabel.Text = item.Data.TaskIsFor;

        MainButton.OnPressed += _ => OnMainPressed?.Invoke(item.Id);
        DoneButton.OnPressed += _ => OnDonePressed?.Invoke(item.Id);

        MainButton.Disabled = item.Data.IsTaskDone;
        DoneButton.Text = item.Data.IsTaskDone ? Loc.GetString("nano-task-ui-revert-done") : Loc.GetString("nano-task-ui-done");
    }
}
