using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject Bg;
    public GameObject SpawnPoint;
    public GameObject Enemy, BonusScore, Cloud1, Cloud2, Cloud3, Cloud4, Cloud5, Cloud6, Cloud7, Cloud8, Cloud9, Cloud10, Cloud11, Cloud12, Cloud13;
    public float ChanceNum;

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Vector3 BgPosition = SpawnPoint.transform.position + new Vector3(0f,3.5f, 0.000001f);
            Vector3 EnPosition = SpawnPoint.transform.position + new Vector3(Random.Range(-0.6f, 0.6f), Random.Range(-1.0f, 1.0f), -1.14f);

            Vector3 Cloud1Position = SpawnPoint.transform.position + new Vector3(Random.Range(-4f, 0.6f), Random.Range(-3.0f, 10.0f), -1.01f);
            Vector3 Cloud2Position = SpawnPoint.transform.position + new Vector3(Random.Range(-0.8f, 0.4f), Random.Range(-2.0f, 11.0f), -1.02f);
            Vector3 Cloud3Position = SpawnPoint.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1.0f, 14.0f), -1.03f);
            Vector3 Cloud4Position = SpawnPoint.transform.position + new Vector3(Random.Range(-1.2f, 1f), Random.Range(-2.0f, 9.0f), -1.04f);
            Vector3 Cloud5Position = SpawnPoint.transform.position + new Vector3(Random.Range(-4f, 4f), Random.Range(-3.0f, 14.0f), -1.05f);
            Vector3 Cloud6Position = SpawnPoint.transform.position + new Vector3(Random.Range(-1.9f, 1.2f), Random.Range(-1.0f, 16.0f), -1.06f);
            Vector3 Cloud7Position = SpawnPoint.transform.position + new Vector3(Random.Range(-4f, 4f), Random.Range(-2.0f, 17.0f), -1.07f);
            Vector3 Cloud8Position = SpawnPoint.transform.position + new Vector3(Random.Range(-1.3f, 2f), Random.Range(-3.0f, 18.0f), -1.08f);
            Vector3 Cloud9Position = SpawnPoint.transform.position + new Vector3(Random.Range(-5f, 5f), Random.Range(-2.0f, 19.0f), -1.09f);
            Vector3 Cloud10Position = SpawnPoint.transform.position + new Vector3(Random.Range(-5f, 5f), Random.Range(-1.0f, 19.0f), -1.1f);
            Vector3 Cloud11Position = SpawnPoint.transform.position + new Vector3(Random.Range(-5f, 4f), Random.Range(-2.0f, 10.0f), -1.11f);
            Vector3 Cloud12Position = SpawnPoint.transform.position + new Vector3(Random.Range(-3f, 6f), Random.Range(-3.0f, 17.0f), -1.12f);
            Vector3 Cloud13Position = SpawnPoint.transform.position + new Vector3(Random.Range(-1f, 4f), Random.Range(-3.0f, 18.0f), -1.13f);
            float x = SpawnPoint.transform.position.x - transform.position.x;
            float y = SpawnPoint.transform.position.y - transform.position.y;
            
            GameObject createdBg = Instantiate(Bg, BgPosition, transform.rotation) as GameObject;

            ChanceNum = Random.Range(0f,1f);
            if (ChanceNum > 0.9f)
            {
                GameObject createdEnemy = Instantiate(BonusScore, EnPosition, transform.rotation) as GameObject;
            }
            else
            {
                GameObject createdEnemy = Instantiate(Enemy, EnPosition, transform.rotation) as GameObject;
            }
            

            GameObject createdCloud1 = Instantiate(Cloud1, Cloud1Position, transform.rotation) as GameObject;
            GameObject createdCloud2 = Instantiate(Cloud2, Cloud2Position, transform.rotation) as GameObject;
            GameObject createdCloud3 = Instantiate(Cloud3, Cloud3Position, transform.rotation) as GameObject;
            GameObject createdCloud4 = Instantiate(Cloud4, Cloud4Position, transform.rotation) as GameObject;
            GameObject createdCloud5 = Instantiate(Cloud5, Cloud5Position, transform.rotation) as GameObject;
            GameObject createdCloud6 = Instantiate(Cloud6, Cloud6Position, transform.rotation) as GameObject;
            GameObject createdCloud7 = Instantiate(Cloud7, Cloud7Position, transform.rotation) as GameObject;
            GameObject createdCloud8 = Instantiate(Cloud8, Cloud8Position, transform.rotation) as GameObject;
            GameObject createdCloud9 = Instantiate(Cloud9, Cloud9Position, transform.rotation) as GameObject;
            GameObject createdCloud10 = Instantiate(Cloud10, Cloud10Position, transform.rotation) as GameObject;
            GameObject createdCloud11 = Instantiate(Cloud11, Cloud11Position, transform.rotation) as GameObject;
            GameObject createdCloud12 = Instantiate(Cloud12, Cloud12Position, transform.rotation) as GameObject;
            GameObject createdCloud13 = Instantiate(Cloud13, Cloud13Position, transform.rotation) as GameObject;


        }
    }
}
