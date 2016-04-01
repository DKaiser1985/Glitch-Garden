using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

       private MusicManager musicManager;
	// Use this for initialization
	void Start () {
        //Find MusicManager
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        //Set Volume form PlayerPrefs
        musicManager.ChangeVolume(PlayerPrefsManager.GetMasterVolume());
	}
	
}
