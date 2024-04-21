using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDraw : MonoBehaviour
{
    public MoveNext moveNext;
    public int index;
    bool isDisplay;
    public GameObject imageObject;
    public Image imageComponent;
    //public bool isTest;//テストか本番か判定する
    public Sprite[] spriteImage;
    void Start ()
    {
        imageComponent = imageObject.GetComponent<Image>();
    }
    void Update ()
    {
        index = moveNext.index;
        //if(isTest == true){texture = Resources.Load(@"TEST\"+index) as Texture2D;}
        //else{texture = Resources.Load(index.ToString()) as Texture2D;}
        //imageComponent.sprite = Sprite.Create(texture, new Rect(0, 0, 600, 200), new Vector2(0,0));
        switch (index)
        {
            case 1:
            imageComponent.sprite = spriteImage[0];
            break;
            case 2:
            imageComponent.sprite = spriteImage[1];
            break;
            case 3:
            imageComponent.sprite = spriteImage[2];
            break;
            case 4:
            imageComponent.sprite = spriteImage[3];
            break;
        }
    }
}
