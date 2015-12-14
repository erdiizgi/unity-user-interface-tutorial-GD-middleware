using UnityEngine;
using System.Collections;

public class SplashSceneLoader : MonoBehaviour {

    public float seconds;

	// Use this for initialization
	void Start () {
        StartCoroutine("CountDown");
	}

    private IEnumerator CountDown()
    {
        yield return new WaitForSeconds(seconds);
        Application.LoadLevel(1);

    }
}
