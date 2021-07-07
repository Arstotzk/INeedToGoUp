using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAutoSize : MonoBehaviour
{
    // Start is called before the first frame update
    public int WidthSc, HeightSc;
    public Text ScoreLink, HiScoreLink;
    public Vector3 V;
    public float yTransform, yKoef;
    
    void Start()
    {
        
        //Resolution[] resolutions = Screen.resolutions;
        WidthSc=Screen.width;
        ScoreLink.fontSize = (WidthSc/100)*10;
        
        HiScoreLink.fontSize = (WidthSc / 100) * 10;

    }

    // Update is called once per frame
    void Update()
    {
        WidthSc = Screen.width;
        HeightSc = Screen.height;
        ScoreLink.fontSize = (WidthSc / 100) * 5;
        HiScoreLink.fontSize = (WidthSc / 100) * 5;
        //V = new Vector3(513, yTransform + (HeightSc/yKoef), 0);
        //HiScoreLink.transform.position = V;
    }
}
