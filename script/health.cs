using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public bool istrigger;
    public GameObject player;
    void Update()
    {
        if(istrigger==true&&Input.GetKeyUp(KeyCode.J)){
           
            player.GetComponent<PlayerMoveL2>().health+=5;
        
        }
}
 void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            istrigger=true;
        }
    }
}
