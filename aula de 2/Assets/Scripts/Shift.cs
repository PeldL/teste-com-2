
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour
{
    public GameObject triangle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Instantiate"))
        {

            GameObject temp = Instantiate(triangle, transform.position, transform.rotation);
        }
    }
}