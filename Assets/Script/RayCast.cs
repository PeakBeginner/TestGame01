using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Transform ball;
    bool cast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cast)
        {
            Vector3 direction = ball.position - transform.position + Vector3.forward;
            Debug.DrawRay(transform.position, direction, Color.blue);

            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == ball)
                {
                    Debug.Log("Hit Ball");
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        cast = true;
    }

    private void OnTriggerExit(Collider other)
    {
        cast = false;
    }
}
