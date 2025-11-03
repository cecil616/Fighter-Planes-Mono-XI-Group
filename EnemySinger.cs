using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySinger : MonoBehaviour
{
    public float movespeed = 0.1f; // Speed of Movement Downward
    public float frequency = 0.1f; // How Fast it goes Back and Forth
    public float amplitude = 0.1f; // How Long it goes Back and Forth

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = startPosition.x + Mathf.Sin(Time.time * frequency) * amplitude; // Determines Horizontal Movement
        float y = transform.position.y - movespeed * Time.deltaTime; // Determines Vertical Movement

        transform.position = new Vector3(x, y, 0); // Changes X Value and Y value, keeping Z Value 0.

        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
