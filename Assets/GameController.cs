using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject high;
    public GameObject low;
    public GameObject mid;

    public float spawnTime;


    // Use this for initialization
    void Start () {
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator spawn()
    {
        float choice;
        while (true)
        {
            choice = (int)(Random.value * 3);

            if(choice == 0)
            {
                Instantiate(high);
            }
            else if (choice == 1)
            {
                Instantiate(low);
            }
            else
            {
                Instantiate(mid);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
