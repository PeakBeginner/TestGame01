using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    public enum model { model1, model2, model3 }
    public model mymodel;

    public GameObject gameObject1, gameObject2, gameObject3;
    // Start is called before the first frame update
    void Start()
    {
        gameObject1.SetActive(true);
        gameObject2.SetActive(false);
        gameObject3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (mymodel)
        {
            case model.model1:
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                gameObject3.SetActive(false);
                break;
            case model.model2:
                gameObject1.SetActive(false);
                gameObject2.SetActive(true);
                gameObject3.SetActive(false);
                break;
            case model.model3:
                gameObject1.SetActive(false);
                gameObject2.SetActive(false);
                gameObject3.SetActive(true);
                break;
        }
    }
}
