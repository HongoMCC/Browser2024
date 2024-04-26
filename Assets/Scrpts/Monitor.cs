using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public GameObject[] monitors;//monitors[0]には何も淹れない
    public MoveNext moveNext;
    public int canSee;//どこからモニターを描画するか（実際に描画される値は
    public int next;
    public int back;
    void Start()
    {
        monitors[(moveNext.index%moveNext.allObjects)].SetActive(true);
    }
    void Update()
    {
        next = moveNext.index+1;
        back = moveNext.index-1;
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            foreach(GameObject monitor in monitors)
            {
                monitor.SetActive(false);
            }
            //for(int j = 1; j == 2; j++)
            //{
            //    monitors[1].SetActive(false);
            //}
            monitors[(moveNext.index%moveNext.allObjects)].SetActive(true);
            monitors[next%moveNext.allObjects].SetActive(true);
            monitors[back%moveNext.allObjects].SetActive(true);
            /*for(int i = 0; i == canSee; i++)
            {
                monitors[moveNext.index - canSee + i].SetActive(true);
            }*/
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            /*for(int j = 1; j == moveNext.allObjects; j++)
            {
                monitors[j].SetActive(false);
            }
            for(int i = 0; i == canSee; i++)
            {
                monitors[moveNext.index - canSee + i].SetActive(true);
            }*/
            foreach(GameObject monitor in monitors)
            {
                monitor.SetActive(false);
            }
            monitors[(moveNext.index%moveNext.allObjects)].SetActive(true);
            monitors[next%moveNext.allObjects].SetActive(true);
            monitors[back%moveNext.allObjects].SetActive(true);
            //monitors[(moveNext.index%moveNext.allObjects)].SetActive(true);
        }
        //monitors[1].SetActive(true);
    }
}
