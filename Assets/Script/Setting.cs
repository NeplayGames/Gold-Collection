using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameSetting Settings;

    public Slider MusicSlider;
    public Slider SoundFxSlider;

    public AudioMixer audioMixer;

    private void Start()
    {
        SetOptionsUI();
        Time.timeScale = 1.0f;

       
    }

    //Set the music slider value according to the setting scriptable object
    //Todo: for build games the scriptable object is unable to hold persistence data and thus goes back to default value
    void SetOptionsUI()
    {
        MusicSlider.value = Settings.GetMusicLevel();
        SoundFxSlider.value = Settings.GetSoundFxLevel();
    }

  //Set the sfx level
    public void SetSfxLvl(float sfxLvl)
    {       
        audioMixer.SetFloat("SoundFx", sfxLvl);
        SaveAudioSetting();
    }

    ///Set the music level
    public void SetMusicLvl(float musicLvl)
    {    
        audioMixer.SetFloat("Music", musicLvl);
        SaveAudioSetting();
    }
    
    ///Save the audio settings
    public void SaveAudioSetting()
    {
        Settings.SetMusicLevel(MusicSlider.value);
        Settings.SetSoundFxLevel(SoundFxSlider.value);
    }


}
