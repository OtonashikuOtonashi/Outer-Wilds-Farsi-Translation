using OWML.ModHelper;
using System;

namespace FarsiTranslation
{
    public interface ILocalizationAPI
    {
        void RegisterLanguage(ModBehaviour mod, string name, string translationPath, string assetBundlePath, string fontPath, Func<string, string> fixer);
        void RegisterLanguage(ModBehaviour mod, string name, string translationPath, string assetBundlePath, string fontPath);
        void RegisterLanguage(ModBehaviour mod, string name, string translationPath);
    }
}
