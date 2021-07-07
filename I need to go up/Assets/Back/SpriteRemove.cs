using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRemove : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public Sprite Sprite1;
    public Sprite Sprite2;
    public int PalitraNumber;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PalitraNumber = PlayerPrefs.GetInt("PalitraNumber");
        if(PalitraNumber == 0 ^ PalitraNumber == 2)
        {
            m_SpriteRenderer.GetComponent<SpriteRenderer>().sprite = Sprite1;
        }
        if (PalitraNumber == 1 )
        {
            m_SpriteRenderer.GetComponent<SpriteRenderer>().sprite = Sprite2;
        }
    }
}
