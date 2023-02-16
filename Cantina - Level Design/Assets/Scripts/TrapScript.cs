using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    private bool colided = false;
    private float dt = 0;
    [SerializeField]
    private GameObject destiny;
    [SerializeField]
    private GameObject player;

    private void Update()
    {
        if(colided)
        {
            dt += Time.deltaTime;
            Debug.Log(dt);
            if (dt >= 2)
            {
                player.transform.position = destiny.transform.position;
                dt = 0;
                colided = false;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            colided = true;
        }
    }
}
