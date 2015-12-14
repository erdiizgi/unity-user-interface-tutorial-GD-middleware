using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterSelecter : MonoBehaviour {

    int currentCharacter;
    Image[] imageKeeper;
    Sprite[] images;
	// Use this for initialization
	void Start () {
        this.currentCharacter = 0;
        imageKeeper = GameObject.FindGameObjectWithTag("image_keeper").GetComponentsInChildren<Image>();

        images = new Sprite[imageKeeper.Length];

        for (int i = 0; i < imageKeeper.Length; i++)
        {
            images[i] = imageKeeper[i].sprite;
        }

	}

    public void nextRightCharacter()
    {
        currentCharacter = (currentCharacter + 1) % imageKeeper.Length;
        transform.GetComponent<Image>().sprite = this.images[this.currentCharacter];
    }

    public void nextLeftCharacter()
    {
        currentCharacter = (currentCharacter + imageKeeper.Length - 1) % imageKeeper.Length;
        transform.GetComponent<Image>().sprite = this.images[this.currentCharacter];
    }
}
