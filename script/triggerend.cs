using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerend : MonoBehaviour
{
    public GameObject changed;
    public GameObject thisGameObject;
    //public GameObject self;
    public bool istrigger;
    public GameObject Player;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(istrigger==true&Input.GetKeyUp(KeyCode.J)){
           if(Player.GetComponent<PlayerMoveL2>().IsBlack==true){
            changed.SetActive(true);
            thisGameObject.SetActive(false);
            Player.GetComponent<PlayerMoveL2>().isEnd=true;
           Player.GetComponent<PlayerMoveL2>().IsBlack=false;
        }
       /* if(Player.GetComponent<player_controller>().IsBlack==false){
            textinfo.SetActive(true);
            Invoke("DisText",2f);

            }*/
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            istrigger=true;
        }
    }
}
