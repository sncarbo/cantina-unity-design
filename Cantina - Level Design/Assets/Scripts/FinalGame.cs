using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGame : MonoBehaviour
{

    [SerializeField] GameObject finalMesh;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Application.Quit();
        }
    }
}
