using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't Destroy on Load " + name);
    }

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing Clip " + thisLevelMusic);
        if (thisLevelMusic)  //If there is some Music attached
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();

                
        }
    }
    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
