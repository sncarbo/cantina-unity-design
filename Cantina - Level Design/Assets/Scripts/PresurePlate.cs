using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresurePlate : MonoBehaviour
{
    [SerializeField] GameObject door;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Box")
        {
            //Destroy(gameObject);
            //gameObject.SetActive(false);
            door.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Box")
        {
            //Destroy(gameObject);
            //gameObject.SetActive(true);
            door.SetActive(true);
        }

    }
}
