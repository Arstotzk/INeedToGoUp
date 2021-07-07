using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float speed = -30f;
    public float speed2 = 0f;
    public float PositionX;
    public int PalitraNumber;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("fly", true);
        PalitraNumber = PlayerPrefs.GetInt("PalitraNumber");
        if (PalitraNumber == 0 ^ PalitraNumber == 2)
        {
            anim.SetBool("White", false);
        }
        if (PalitraNumber == 1)
        {
            anim.SetBool("White", true);
        }
        rb = GetComponent<Rigidbody2D>();
        PositionX=PlayerPrefs.GetFloat("PositionX");
        rb.transform.position = new Vector3(PositionX,0);


    }

    // Update is called once per frame
    void Update()
    {
        PalitraNumber = PlayerPrefs.GetInt("PalitraNumber");
        if (PalitraNumber == 0 ^ PalitraNumber == 2)
        {
            anim.SetBool("White", false);
        }
        if (PalitraNumber == 1)
        {
            anim.SetBool("White", true);
        }
    }
    private void FixedUpdate()
    {
        if (transform.position.x > 0.1)
        {
            speed2 = -2f;
        }
        if (transform.position.x < -0.1)
        {
            speed2 = 2f;
        }
        if (transform.position.x<0.1 && transform.position.x > -0.1)
        {
            speed2 = 0f;
        }
        rb.velocity = transform.up * speed + transform.right * speed2;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Earth")
        {

            speed = 0f;
            speed2 = 0f;
            CameraShake.Shake(0.7f, 1);
            Invoke("loadScene",0.7f);
        }
    }
    void loadScene()
    {
        SceneManager.LoadScene("Main");
    }
}
