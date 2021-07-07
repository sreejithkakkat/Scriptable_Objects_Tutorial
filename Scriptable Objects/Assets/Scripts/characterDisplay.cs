using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class characterDisplay : MonoBehaviour {
    public Characters characters;

    public Image bodyImage;
    public Image eyesImage;
    public Image mouthImage;
    public TextMeshProUGUI charName;

    // Start is called before the first frame update
    void Start () {

        bodyImage.sprite = characters.body;
        eyesImage.sprite = characters.eyes;
        mouthImage.sprite = characters.mouth;
        charName.text = characters.characterName;

    }

}