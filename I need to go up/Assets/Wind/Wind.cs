using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                anim.speed = 2f;
                
            }
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                anim.speed = 1f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.speed = 2f;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.speed = 1f;

        }

    }
}
