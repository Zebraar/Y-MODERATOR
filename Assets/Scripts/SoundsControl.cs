using UnityEngine;

public class SoundsControl : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip ClickSound;
    public AudioClip ScarySounds;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(ClickSound); 
    }

    public void PlayScarySounds()
    {
        audioSource.PlayOneShot(ScarySounds);
    }

}
