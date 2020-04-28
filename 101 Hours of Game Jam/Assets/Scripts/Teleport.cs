using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Teleport_Gate());  
        }
    }

    IEnumerator Teleport_Gate()
    {
        yield return new WaitForSeconds (0.3f);
        Player.transform.position = new Vector2 (Portal.transform.position.x, Portal.transform.position.y);
    }
}
