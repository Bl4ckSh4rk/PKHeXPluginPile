using PKHeX.Core;
using System.Reflection;

namespace PluginPile.SVivillonPlugin {
  public class SVivillonPlugin : Common.PluginBase {

    public override string Name => nameof(SVivillonPlugin);
    protected override Assembly PluginAssembly => typeof(SVivillonPlugin).Assembly;
    ToolStripMenuItem OpenFormButton = null!;

    private bool IsCompatibleSave {
      get { return SaveFileEditor.SAV is SAV9SV; }
    }

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      OpenFormButton = new ToolStripMenuItem(Language.MenuItemName) {
        Image = Properties.Images.F18_Fancy
      };
      OpenFormButton.Click += (s, e) => new VivillonForm((SAV9SV)SaveFileEditor.SAV).ShowDialog();
      OpenFormButton.Available = IsCompatibleSave;
      tools.DropDownItems.Add(OpenFormButton);
    }

    protected override void HandleSaveLoaded() => OpenFormButton.Available = IsCompatibleSave;

  }
}
