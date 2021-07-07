using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCloud : MonoBehaviour
{
    public Transform who;
    public float speed;
    Vector3 position, NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = who.position;
        //position.z = -10f;
        position.z = 0f;
        position.x = 0f;
        NewPosition = new Vector3(0f, position.y - 14f, 0f);


        transform.position = Vector3.Lerp(transform.position, NewPosition, speed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeleteCloud")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BonusScore")
        {
            Destroy(collision.gameObject);
        }
    }
}
