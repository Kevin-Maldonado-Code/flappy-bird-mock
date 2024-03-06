using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongCloudScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // * Time.deltaTime is needed for standardizing the speed across frame rates/computer processing ability
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            //Debug.Log("Bong Cloud prefab deleted");
            Destroy(gameObject);
        }
    }
}
