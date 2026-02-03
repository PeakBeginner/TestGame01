using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public Material material;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        material.color = Color.white;
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube")) ;
        {
            Debug.Log("OnTriggerEnter");
            material.color = Color.yellow;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Cube")) ;
        {
            Debug.Log("OnTriggerStay");
            material.color = Color.green;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube")) ;
        {
            Debug.Log("OnTriggerExit");
            material.color = Color.red;
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //Vector3 pos = target.position;
    //    //transform.rotation = Quaternion.LookRotation(pos);
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Cube"))
    //    {
    //        Debug.Log("OnCollisionEnter");
    //        material.color = Color.yellow;
    //    }
    //    //if (collision.gameObject.name == "Cube")
    //    //{
    //    //    Debug.Log("OnCollisionEnter");
    //    //}
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Cube"))
    //    {
    //        Debug.Log("OnCollisionStay");
    //        material.color = Color.green;
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Cube"))
    //    {
    //        Debug.Log("OnCollisionExit");
    //        material.color = Color.red;
    //    }
    //}
}
