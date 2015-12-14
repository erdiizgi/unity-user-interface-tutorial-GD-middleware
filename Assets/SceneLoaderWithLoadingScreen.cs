using UnityEngine;
using System.Collections;

public class SceneLoaderWithLoadingScreen : MonoBehaviour
{
    public GameObject loadingImage;

    public void LoadScene(int n)
    {
        loadingImage.SetActive(true);
        Application.LoadLevel(n);
    }
}
