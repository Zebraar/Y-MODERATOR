using UnityEngine;

public class SoundsControl : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip ClickSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(ClickSound); 
    }

}
