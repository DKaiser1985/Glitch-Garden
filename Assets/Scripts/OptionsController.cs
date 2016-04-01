using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider sldrVolume;
    public Slider sldrDifficulty;
    public LevelManager lvlManager;
    
    private MusicManager musicManager;

    // Use this for initialization
	void Start () {
        //Find and setup MusicManager for use in this script
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        Debug.Log ("Music Manager Found");

        //Set Sliders from PlayerPrefsManager on Load
        sldrVolume.value = PlayerPrefsManager.GetMasterVolume();
        sldrDifficulty.value = PlayerPrefsManager.GetDifficulty();

	}
	
	// Update is called once per frame
	void Update () {
        //set/update The volume live for each frame
        musicManager.ChangeVolume(sldrVolume.value);
	}
    public void SaveAndExit()
    {
        //Save to PlayerPrefs via Manager and exit to Start Screen
        PlayerPrefsManager.SetMasterVolume(sldrVolume.value);
        PlayerPrefsManager.SetDifficulty(sldrDifficulty.value);
        lvlManager.LoadScene("01a Start");
    }
    public void setDefaults() {
        
        //Set PlayerPrefs via Manager to defaults and exit to Start Screen
        PlayerPrefsManager.SetMasterVolume(0.8f);
        PlayerPrefsManager.SetDifficulty(2f);
        lvlManager.LoadScene("01a Start");
    }
}
