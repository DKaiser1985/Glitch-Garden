using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public bool autoLoad;
    public float autoLoadNextLevelAfter;
    public string scene;

    void Start() {
        if (autoLoad && (autoLoadNextLevelAfter > 0))
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
        else
        {
            Debug.LogWarning("Autoload disabled; Level Autoload timer bust be positive.");
        }
    }
    
	public void QuitRequest (){
		Debug.Log("Quit Requested");
		Application.Quit();
	}
    public void LoadNextLevel(){
		//load next level index
		SceneManager.LoadScene(scene);
	}
    /*public void LoadLevel (string name){
		Debug.Log("New Level loaded: " + name);
		Application.LoadLevel(name);
	}*/

    public void LoadScene(string scene) {
        SceneManager.LoadScene(scene);
    }	
	
}
