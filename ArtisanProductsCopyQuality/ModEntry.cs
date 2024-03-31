using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley.GameData.Machines;

namespace ArtisanProductsCopyQuality
{
    public class ModEntry : Mod
    {
        internal static ModEntry instance;
        internal Config config;

        public override void Entry(IModHelper helper)
        {
            instance = this;
            config = helper.ReadConfig<Config>();
            Helper.Events.Content.AssetRequested += AssetRequested;
        }

        private void AssetRequested(object? sender, AssetRequestedEventArgs ev)
        {
            if (ev.NameWithoutLocale.IsEquivalentTo("Data/Machines"))
                ev.Edit(EditMachines, AssetEditPriority.Default);
        }

        private void EditMachines(IAssetData asset)
        {
            if (asset.Data is Dictionary<string, MachineData> data)
            {
                foreach (KeyValuePair<string, MachineData> machine in data)
                {
                    if (!config.machinesToTarget.Contains(machine.Key)) continue;
                    machine.Value?.OutputRules.ForEach(rule => {
                        rule?.OutputItem.ForEach(item => {
                            if (item is not null) item.CopyQuality = true;
                        });
                    });
                }
            }
        }
    }
}
