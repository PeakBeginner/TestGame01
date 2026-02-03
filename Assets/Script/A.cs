using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public float speed = 5f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        movement = new Vector3(h * speed * Time.deltaTime, 0 , v * speed * Time.deltaTime);
        transform.position += movement;
    }
}
