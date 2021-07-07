using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GG : MonoBehaviour {
    Rigidbody2D rb;
    Animator anim;
    public float speed=0f;
    public float speed2 = 0f;
    public float score, hiscore;
    public int PalitraNumber;
    int firstTap = 0;
    public Text ScoreLink, HiScoreLink;
    public GameObject StartBottom;
    public bool deadHero=false;
    public AsyncOperation asyncLoad;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("idle", true);
        PalitraNumber = PlayerPrefs.GetInt("PalitraNumber");
        if (PalitraNumber == 0 ^ PalitraNumber == 2)
        {
            anim.SetBool("White", false);
        }
        if (PalitraNumber == 1)
        {
            anim.SetBool("White", true);
        }
        hiscore = PlayerPrefs.GetFloat("hiscore");
        ScoreLink.text = ("Score: " + score + "\nHigh Score: " + hiscore);

        StartCoroutine(LoadYourAsyncScene()); // Код чтобы загрузить асинхронно вторую сцену без лагов
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
        if (Input.touchCount > 0 && StartBottom==null)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                speed = 10f;
            }
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                anim.SetBool("Fly", true);
                speed = 5f;
                if (firstTap == 0)
                {
                    speed2 = 4f;
                    Invoke("First", 0.7f);
                    firstTap = 1;
                }
            }
        }
    
        if (Input.GetKeyDown(KeyCode.Space) && StartBottom == null)
        {
            anim.SetBool("Fly", true);
            speed = 10f;
            if (firstTap == 0)
            {
                
                speed2 = 4f;
                Invoke("First", 0.7f);
              
                firstTap = 1;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space) && StartBottom == null)
        {
            
            speed = 5f;
        } 

    }
    
    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed + transform.right * speed2;
    }
    void First()
    {
        speed2 = -4f;
        Invoke("Second", 1.4f);
    }
    void Second()
    {
        speed2 = 4f;
        Invoke("First", 1.4f);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Enemy")
        {

            speed = 0f;
            speed2 = 0f;
            PlayerPrefs.SetFloat("PositionX", transform.position.x);
            CancelInvoke("First");
            CancelInvoke("Second");
            deadHero = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScorePlus")
        {
            score++;
            if (hiscore < score)
            {
                PlayerPrefs.SetFloat("hiscore", (score));
            }
            hiscore = PlayerPrefs.GetFloat("hiscore");
            ScoreLink.text = ("Score: " + score + "\nHigh Score: " + hiscore);
        }
        if (collision.gameObject.tag == "Enemy")
        {

            speed = 0f;
            speed2 = 0f;
            PlayerPrefs.SetFloat("PositionX", transform.position.x);
            CancelInvoke("First");
            CancelInvoke("Second");
            deadHero = true;

        }
        if (collision.gameObject.tag == "BonusScore")
        {
            Destroy(collision.gameObject);
            score = score + 5;
            if (hiscore < score)
            {
                PlayerPrefs.SetFloat("hiscore", (score));
            }
            hiscore = PlayerPrefs.GetFloat("hiscore");
            ScoreLink.text = ("Score: " + score + "\nHigh Score: " + hiscore);
        }
    }
    IEnumerator LoadYourAsyncScene() // Код чтобы загрузить асинхронно вторую сцену без зависаний
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Dead");
        asyncLoad.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncLoad.progress);
        while (!asyncLoad.isDone)
        {

            if (deadHero == true)
            {
                asyncLoad.allowSceneActivation = true;
                
            }
            yield return null;
        }

    }
}

