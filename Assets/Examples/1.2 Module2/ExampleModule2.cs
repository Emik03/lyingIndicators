using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;

public class ExampleModule2 : MonoBehaviour
{
    public KMAudio Audio;
    public KMBombInfo Bomb;
    public KMSelectable[] Buttons;

    int _moduleId;
    static int _moduleIdCounter;

    private void Awake()
    {
        _moduleId = _moduleIdCounter++;
        for (byte i = 0; i < Buttons.Length; i++)
        {
            var btn = Buttons[i];
            btn.OnInteract += delegate 
            {
                HandlePress(i);
                return false;
            };
        }
    }

    void Start()
    {
        Debug.Log(_moduleId);
    }

    void HandlePress(byte btn)
    {
    }
}
