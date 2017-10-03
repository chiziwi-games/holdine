using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Spawn : MonoBehaviour {

    public GameObject navableAgent;
    public GameObject initialDestination;

    public int spawnLimit = 250;
    private int spawnCount = 0;
	// Use this for initialization
	void Start () {
        Invoke("SpawnAgent", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnAgent()
    {
        GameObject agent = (GameObject)Instantiate(navableAgent, this.transform.position, Quaternion.identity);
        agent.GetComponent<AICharacterControl>().target = initialDestination.transform;
        spawnCount++;
        if (spawnCount >= spawnLimit) {
            Destroy(gameObject);
        }
        gameObject.transform.Translate(0f, 0f, Random.Range(5f,25f));
        if (gameObject.transform.position.z > 225f)
        {
            gameObject.transform.Translate(-3f, 0f, -450f);
        }
        Invoke("SpawnAgent", 0);
    }
}
