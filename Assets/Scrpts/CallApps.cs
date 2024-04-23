using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;

public class CallApps : MonoBehaviour
{
    //public string appFileName;
    public MoveNext moveNext;
    public int index;
    string exepath;
    string readmePath;
    string type;
    public int[] htmlGames;
    public void Start()
    {
        index = moveNext.index;
        exepath = Path.Combine(Application.dataPath,"../Apps/Games/Game"+index+"/main."+type);
        readmePath = Path.Combine(Application.dataPath,"../Apps/Games/Game"+index+"/readme.txt");
    }
    void Update()
    {
        if(index == htmlGames[0]){type = "html";}
        else{type = "exe";}
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Process.Start(exepath);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            Process.Start(readmePath);
        }
    }
}
