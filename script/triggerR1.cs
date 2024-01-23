using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerR1 : MonoBehaviour
{
    public GameObject changed;
    public GameObject thisGameObject;
    //public GameObject self;
    public Transform rightpoint;
    public bool istrigger;
    public GameObject Player;
    public GameObject textinfo;
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
            Player.transform.position=rightpoint.position;

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
    void DisText(){

        textinfo.SetActive(false);
    }

}
