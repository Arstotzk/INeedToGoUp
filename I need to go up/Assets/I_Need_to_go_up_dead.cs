using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Need_to_go_up_dead : MonoBehaviour
{
    public float speed;
    Vector3 position, NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        position.z = 1f;
        position.y = 3f;
        position.x = 0f;
        NewPosition = new Vector3(position.x, position.y, position.z);


        transform.position = Vector3.Lerp(transform.position, NewPosition, speed * Time.deltaTime);

    }
}
