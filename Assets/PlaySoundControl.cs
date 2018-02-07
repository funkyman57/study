
using UnityEngine;

public class PlaySoundControl : MonoBehaviour {

    public AudioSource audioSource;
    public void PlaySound()
    {
        audioSource.Play();
    }
}
