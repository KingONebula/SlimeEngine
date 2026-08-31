using UnityEngine;
using LocalizationAssets;
public class Localization
{
    public static Languages currentLanguage;
    public static LocalizationSettings currentSettings;
    public static TextAsset GetMap(int mapID)
    {
        return currentSettings[mapID];
    }
    public static string GetText(int mapID, int textID)
    {
        string textIDString = $"[{textID.ToString("00")}]";
        TextAsset map = GetMap(mapID);
        string[] texts = map.text.Split("[END]");
        foreach(string text in texts)
        {
            if (text.Contains(textIDString))
            {
                return text.Split(textIDString)[1];
            }
        }
        return textIDString;
    }
}

public enum Languages
{
    English,
    Spanish,
    Japanese
}
