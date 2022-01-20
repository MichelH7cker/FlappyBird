using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour {
    private static GameAssets instance;
    // Instantiate(GameAssets.GetInstance().pfPipeHead);
    public static GameAssets GetInstance() {
        return instance;
    }

    private void Awake(){
        instance = this;
    }

    public Sprite PipeHeadSprite;
    public Transform pfPipeHead;
    public Transform pfPipeBody;

}