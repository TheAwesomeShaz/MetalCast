using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float lavaSpeed = 2f;
    GameController gc;

    private void Start()
    {
        gc = FindObjectOfType<GameController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gc.startFill)
        {

            if (transform.localScale.x < 20)
                transform.localScale = Vector3.Lerp(transform.localScale,
                    new Vector3(20f, transform.localScale.y, transform.localScale.z), lavaSpeed * Time.deltaTime);
        }
    }

    
}
