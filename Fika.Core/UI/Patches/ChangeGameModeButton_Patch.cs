using EFT.UI;
using SPT.Reflection.Patching;
using System.Reflection;
using TMPro;
using UnityEngine.UI;
using static Fika.Core.UI.FikaUIGlobals;

namespace Fika.Core.UI.Patches;

public class ChangeGameModeButton_Patch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        return typeof(ChangeGameModeButton).GetMethod(nameof(ChangeGameModeButton.Show));
    }

    [PatchPrefix]
    private static bool PrefixChange(TextMeshProUGUI ____buttonLabel, TextMeshProUGUI ____buttonDescription, Image ____buttonDescriptionIcon,
        GameObject ____availableState)
    {
        ____buttonLabel.text = "PvE";
        ____buttonDescription.text = $"青春服务器 {ColorizeText(EColor.BLUE, "2.1")}";
        ____buttonDescriptionIcon.gameObject.SetActive(false);
        ____availableState.SetActive(true);
        return false;
    }
}
