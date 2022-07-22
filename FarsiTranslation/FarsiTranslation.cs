﻿using OWML.Common;
using OWML.ModHelper;

namespace FarsiTranslation
{
    public class FarsiTranslation : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"{nameof(FarsiTranslation)} is loaded!", MessageType.Success);

            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Arabic", "assets/Translations.xml");
            api.AddLanguageFont(this, "Arabic", "assets/b_mitra_0", "Assets/B_MITRA_0.TTF");
            api.AddLanguageFixer("Arabic", ArabicSupport.ArabicFixer.Fix);
        }
    }
}
