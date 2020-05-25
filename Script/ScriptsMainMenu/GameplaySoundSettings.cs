using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySoundSettings : MonoBehaviour
{
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private static readonly string MusicWhilePlayingPref = "MusicWhilePlayingPref";

    public AudioSource Explode;
    public AudioSource healing;
    public AudioSource BGM_Race;

    // Start is called before the first frame update
    void Start()
    {
        Explode.volume = PlayerPrefs.GetFloat(SoundEffectsPref);
        healing.volume = PlayerPrefs.GetFloat(SoundEffectsPref);
        BGM_Race.volume = PlayerPrefs.GetFloat(MusicWhilePlayingPref);
        Explode.playOnAwake = false;
        healing.playOnAwake = false;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
