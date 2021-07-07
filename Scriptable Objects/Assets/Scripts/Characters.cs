using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Character", menuName = "Characters")]
public class Characters : ScriptableObject {
    public string characterName;

    public Sprite body;
    public Sprite eyes;
    public Sprite mouth;
}