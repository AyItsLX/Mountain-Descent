using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] Slope;
    Vector2 SpawnLocation, BGSpawnLocation;
    private GameObject Player;
    public GameObject Filler;
    public GameObject[] BG;

    public GameObject[] S1F;
    public GameObject[] S2F;
    public GameObject[] S3F;

    void Start () {
        SpawnLocation = new Vector2(6f, -3f);
        BGSpawnLocation = new Vector2(243.2f, 4.68f);
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
		if (SpawnLocation.x < (Player.transform.position.x + 40)) {
            int slopen = Random.Range(0, 3);
            Instantiate(Slope[slopen], SpawnLocation, Quaternion.identity);
            if (slopen == 0) {
                Instantiate(S1F[Random.Range(0, 4)], new Vector3(SpawnLocation.x, SpawnLocation.y, -1f), Quaternion.identity);

            } else if (slopen == 1) {
                Instantiate(S2F[Random.Range(0, 4)], new Vector3(SpawnLocation.x, SpawnLocation.y, -1f), Quaternion.identity);

            }
            else if (slopen == 2) {
                Instantiate(S3F[Random.Range(0, 4)], new Vector3(SpawnLocation.x, SpawnLocation.y, -1f), Quaternion.identity);

            }
            Instantiate(Filler, new Vector3(SpawnLocation.x, SpawnLocation.y - 4.5f), Quaternion.identity);
            SpawnLocation.x += 14;
        }
        if (BGSpawnLocation.x < (Player.transform.position.x + 200)) {
            Instantiate(BG[Random.Range(0, 3)], new Vector3(BGSpawnLocation.x, BGSpawnLocation.y, 1), Quaternion.identity);
            BGSpawnLocation.x += 102.33f;
        }
    }
}
