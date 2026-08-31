using UnityEngine;
using TMPro;


namespace LocalizationAssets
{
    [CreateAssetMenu(fileName = "Language")]
    public class Language : ScriptableObject
    {
        public TMP_FontAsset[] fonts;
        public TextAsset[] maps;
    }
}
