using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject circle;
    //public GameObject self;
    public Transform rightpoint;
    public bool istrigger;
    public GameObject Player;
    public GameObject textinfo;
    public GameObject startPoint;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(istrigger==true&&Input.GetKeyUp(KeyCode.J)){
            if(Player.GetComponent<PlayerMoveL2>().IsBlack==false){
            circle.SetActive(true);
            this.gameObject.SetActive(false);
            Player.transform.position=rightpoint.position;
            Player.GetComponent<PlayerMoveL2>().IsBlack=true;
            startPoint.SetActive(true);
            }
            
           /*if(Player.GetComponent<player_controller>().IsBlack==true){
            textinfo.SetActive(true);
            Invoke("DisText",2f);

            }
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
