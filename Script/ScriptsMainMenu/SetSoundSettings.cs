using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSoundSettings : MonoBehaviour
{
    private static readonly string BackGroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";

    public AudioSource BGM; // backgroundmusic
    public AudioSource ButtonClick;

    // Start is called before the first frame update
    void Start()
    {
        BGM.volume = PlayerPrefs.GetFloat(BackGroundPref);
        ButtonClick.volume = PlayerPrefs.GetFloat(SoundEffectsPref);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
