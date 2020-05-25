using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackGroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private static readonly string MusicWhilePlayingPref = "MusicWhilePlayingPref"; // here is the music which you  have while playing

    private int firstPlayInt;
    public Slider backGroundSlider, soundsEffectSlider, musicWhilePlayingSlider;
    private float backGroundFloat, soundEffectsFloat, musicWhilePlayingFloat;

    public AudioSource backGroundMusic;
    public AudioSource soundEffects;


    // Start is called before the first frame update
    void Start()
    {
        //default music settings on the first time
        if(PlayerPrefs.GetInt(FirstPlay) == 0)
        {
            backGroundFloat = 0.5f;
            soundEffectsFloat = 0.9f;
            musicWhilePlayingFloat = 0.8f;

            backGroundSlider.value = backGroundFloat;
            PlayerPrefs.SetFloat(BackGroundPref, backGroundFloat);
            
            soundsEffectSlider.value = backGroundFloat;
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);

            musicWhilePlayingSlider.value = musicWhilePlayingFloat;
            PlayerPrefs.SetFloat(MusicWhilePlayingPref, musicWhilePlayingFloat);


            //this is that it wouldn't reset music settings everytime
            PlayerPrefs.SetInt(FirstPlay, -1);
            PlayerPrefs.Save();
        }
        else
        {
            backGroundFloat = PlayerPrefs.GetFloat(BackGroundPref);
            backGroundSlider.value = backGroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundsEffectSlider.value = soundEffectsFloat;
            musicWhilePlayingFloat = PlayerPrefs.GetFloat(MusicWhilePlayingPref);
            musicWhilePlayingSlider.value = musicWhilePlayingFloat;
            
            PlayerPrefs.Save();
        }
        
    }

    void update()
    {
        SaveSoundSettings();
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackGroundPref, backGroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundsEffectSlider.value);
        PlayerPrefs.SetFloat(MusicWhilePlayingPref, musicWhilePlayingSlider.value);

        //backGroundSlider.value = PlayerPrefs.GetFloat(BackGroundPref);
        PlayerPrefs.Save();
    }

    //Reikia perdaryti kad ant click pasikeistu
    private void OnApplicationFocus(bool focus)
    {
        //we have left application (game)
        if (!focus)
        {
            SaveSoundSettings();
        }
    }

    public void updateSound()
    {
        backGroundMusic.volume = backGroundSlider.value;
        soundEffects.volume = soundsEffectSlider.value;
    }

}
