using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour
{
    public float speed;
    public int allObjects;//Objectの数
    public GameObject center;
    public int index;
    float moveAngle;
    float moveSeconds;
    void Start()
    {
        index = 1;
        moveAngle = 360/allObjects;
        moveSeconds = moveAngle/speed;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Move(-speed));
            if(index == allObjects){index = 1;}
            else{index ++;}
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(Move(speed));
            if(index == 1){index = allObjects;}
            else{index --;}
        }
    }
    public IEnumerator Move(float speed)
    {
        float timer = 0f;
        while (timer < moveSeconds)
        {
            transform.RotateAround(center.transform.position,new Vector3(0,1,0), speed);
            timer ++;
            yield return null;
        }
    }
}