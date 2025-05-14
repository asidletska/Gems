using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void ToggleMusic(bool isOn)
    {
        audioMixer.SetFloat("MusicVolume", isOn ? 0f : -80f);
        PlayerPrefs.SetInt("MusicToggle", isOn ? 1 : 0);
    }

    public void ToggleSFX(bool isOn)
    {
        audioMixer.SetFloat("SFXVolume", isOn ? 0f : -80f);
        PlayerPrefs.SetInt("SFxToggle", isOn ? 1 : 0);
    }

    private void Start()
    {
        bool musicOn = PlayerPrefs.GetInt("MusicToggle", 1) == 1;
        bool sfxOn = PlayerPrefs.GetInt("SFxToggle", 1) == 1;

        ToggleMusic(musicOn);
        ToggleSFX(sfxOn);
    }

}
