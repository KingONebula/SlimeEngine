using UnityEngine;
using TMPro;
using System;
namespace SlimeEngine.EZInput{
public class Remap : MonoBehaviour
{
    public bool remapping;
    public string input;
    [SerializeField] KeyCode[] blacklist;
    [SerializeField] TextMeshProUGUI RemapButton;
    //Use with OnClick() Event
    public void Map(string input)
    {
        this.input = input;
        remapping = true;
        // Uncomment if using Localization
        //Button.text = Localization.GetText(0, 1);
        RemapButton.text = "Select Input";
    }
    private void Update()
    {
        if (remapping)
        {
            foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(key) && Array.IndexOf(blacklist, key) == -1)
                {
                    KeyBinds.preset[input] = key;
                    RemapButton.text= key.ToString();
                    remapping=false;
                }
            }
        }
    }
}
}