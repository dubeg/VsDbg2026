using System.Threading;
using EnvDTE;
using Microsoft.Internal.VisualStudio.Shell.Interop;

namespace VsDbg.Commands;

[Command(PackageIds.ToggleJustMyCode)]
internal sealed class ToggleJustMyCode : BaseCommand<ToggleJustMyCode> {
    protected override async Task ExecuteAsync(OleMenuCmdEventArgs e) {
        await Utils.ToggleUnifiedSettingWithStatusAsync(
            Package,
            "debugging.general.justMyCode",
            "Just My Code"
        );
    }
}