using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSliding : MonoBehaviour {

	void Update () {
        Vector3 direction = new Vector3(1, 0, 0);
        transform.position += direction * Mathf.Cos(Time.timeSinceLevelLoad * 4f) * 15f * Time.deltaTime;
    }
}
