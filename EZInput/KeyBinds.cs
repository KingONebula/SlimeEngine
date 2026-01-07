using System.Collections.Generic;
using UnityEngine;

namespace SlimeEngine.EZInput
{
    public class KeyBinds
    {
        public static KeyBinds preset;
        Dictionary<string, KeyCode> _keybinds;
        public KeyCode this[string input]
        {
            get
            {
                KeyCode ret = KeyCode.None;
                _keybinds.TryGetValue(input, out ret);
                return ret;
            }
            set
            {
                if (_keybinds.ContainsKey(input)) 
                {
                    _keybinds[input] = value;
                }
                else
                {
                    Debug.Log("EZInput Name Not Found");
                }
            }
        }
        public KeyBinds(Dictionary<string, KeyCode> keybinds, bool isPreset = true)
        {
            //Use if you want global keybinds. Does not save across sessions
            if(isPreset)
            preset = this;
            this._keybinds = keybinds;
        }
    }
}