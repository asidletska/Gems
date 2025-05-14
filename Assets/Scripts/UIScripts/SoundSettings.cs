using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider fxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetFXVolume();
        }
    }
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        fxSlider.value = PlayerPrefs.GetFloat("FX");
        SetMusicVolume();
        SetFXVolume();
    }
    public void SetFXVolume()
    {
        float volume = fxSlider.value;
        audioMixer.SetFloat("FX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("FX", volume);
    }
}
