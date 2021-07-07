using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palitra : MonoBehaviour
{
    public int PalitraNumber;
    // Start is called before the first frame update
    void Start()
    {
        PalitraNumber=PlayerPrefs.GetInt("PalitraNumber");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PalitraNumber == 2)
            {
                PalitraNumber = 0;
            }

            if (PalitraNumber < 2)
            {
                PalitraNumber = PalitraNumber + 1;
            }
            PlayerPrefs.SetInt("PalitraNumber", PalitraNumber);

        }
    }
    private void OnMouseDown()
    {
        if (PalitraNumber == 2)
        {
            PalitraNumber = 0;
        }

        if (PalitraNumber < 2)
        {
            PalitraNumber = PalitraNumber + 1;
        }
        PlayerPrefs.SetInt("PalitraNumber", PalitraNumber);
    }
}
