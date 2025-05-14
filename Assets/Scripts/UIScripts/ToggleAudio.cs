using UnityEngine;
using UnityEngine.UI;

public class ToggleAudio : MonoBehaviour
{
    public Toggle musicToggle;
    public Toggle sfxToggle;
    public AudioController audioManager;

    private void Start()
    {
        musicToggle.isOn = PlayerPrefs.GetInt("MusicToggle", 1) == 1;
        sfxToggle.isOn = PlayerPrefs.GetInt("SFXToggle", 1) == 1;

        musicToggle.onValueChanged.AddListener(audioManager.ToggleMusic);
        sfxToggle.onValueChanged.AddListener(audioManager.ToggleSFX);
    }

}
