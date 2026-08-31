using UnityEngine;

namespace LocalizationAssets
{
    [CreateAssetMenu(fileName = "LocalizationSettings")]
    public class LocalizationSettings : ScriptableObject
    {
        public Language[] languages;
        public TextAsset this[int mapID]
        {
            get
            {
                Languages language = Localization.currentLanguage;
                return languages[(int)language].maps[mapID];
            }
        }
    }
}