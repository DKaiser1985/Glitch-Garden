using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

    public float secsToWait;
    public float timeToFade;

	// Use this for initialization
	void Start () {
        StartCoroutine(PauseBeforeDisable());
        Image img = GameObject.Find("FadePanel").GetComponent<Image>();
        img.CrossFadeAlpha(0F, timeToFade, false);
        //gameObject.SetActive(false);
    }

    IEnumerator PauseBeforeDisable()
    {
        yield return new WaitForSeconds(timeToFade);
        gameObject.SetActive(false);
    }
}
