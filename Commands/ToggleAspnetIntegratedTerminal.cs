using System.Threading;
using EnvDTE;
using Microsoft.Internal.VisualStudio.Shell.Interop;

namespace VsDbg.Commands;

[Command(PackageIds.ToggleAspnetIntegratedTerminal)]
internal sealed class ToggleAspnetIntegratedTerminal : BaseCommand<ToggleAspnetIntegratedTerminal> {
    protected override async Task ExecuteAsync(OleMenuCmdEventArgs e) {
        await Utils.ToggleUnifiedSettingWithStatusAsync(
            Package,
            "projectsAndSolutions.aspNetCore.outputOptions.useIntegratedTerminal",
            "Just My Code"
        );
    }
}