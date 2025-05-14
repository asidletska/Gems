using UnityEngine;

public class AudioController : MonoBehaviour
{
    [Header("AudioSource")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("AudioClip")]
    public AudioClip BackGround;
    public AudioClip Bomb;
    public AudioClip Blade;
    public AudioClip Fruit;

    private void Start()
    {
        musicSource.clip = BackGround;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
