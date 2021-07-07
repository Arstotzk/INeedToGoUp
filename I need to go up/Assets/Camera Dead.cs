using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDead : MonoBehaviour {
    public Transform who;
    Vector3 position, NewPosition;
    // Use this for initialization
    void Start()
    {
       // transform.position = who.position;
        Invoke("shake", 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = who.position;
        //position.z = -10f;
        position.z = -10f;
        position.x = 0f;
        NewPosition = new Vector3(0f, position.y + 4f, -10f);

        transform.position = Vector3.Lerp(transform.position, NewPosition, 10f * Time.deltaTime);
    }
    void shake()
    {
        CameraShake.Shake(0.4f, 0.5f);
    }
}