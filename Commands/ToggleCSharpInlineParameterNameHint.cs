using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Internal.VisualStudio.Shell.Interop;

namespace VsDbg.Commands;

[Command(PackageIds.ToggleCSharpInlineParameterNameHint)]
internal class ToggleCSharpInlineParameterNameHint : BaseCommand<ToggleCSharpInlineParameterNameHint> {
    protected override async Task ExecuteAsync(OleMenuCmdEventArgs e) {
        // 2025-09-10 v18.0.0: this setting hasn't been migrated to UnifiedSettings yet.
        var enabled = await Utils.ToggleRoamingAsync(Package,"TextEditor.CSharp.Specific", "InlineParameterNameHints");
        Utils.ShowSettingStatusThenClear("C#: Inline Parameter Name Hint", enabled);
    }
}
