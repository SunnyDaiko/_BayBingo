using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager Instance { get; private set; }
    [SerializeField]
    public AudioSource background, rightAnswer, wrongAnswer;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
            DontDestroyOnLoad(gameObject);

    }
    
    public void PlaySound(AudioClip clip)
    {
        background.PlayOneShot(clip);
    }

    public void ToggleMusic()
    {
        background.mute = !background.mute;
    }

    public void ChangeBGM(AudioClip change)
    {
        background.Stop();
        background.clip = change;
        background.Play();
    }

}
