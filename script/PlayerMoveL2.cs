using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveL2 : MonoBehaviour
{
   public float speed;
    Rigidbody2D rb;
    private Animator anim;
    private enum movementanim {idle,left,front,back};
    private float x;
    private float y;
    private SpriteRenderer sprite;
    movementanim state;
    public bool IsBlack;
    public Transform startPoint;
    public Transform startPoint2;
     public Transform startPoint3;
    
   
    public bool isEnd;
    public int career;
    public int relation;
    public int health;
    public GameObject vic;


    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody2D>(); 
       anim=GetComponent<Animator>();
       sprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update(){
        if(transform.position==startPoint.position){
            IsBlack=false;
        }
        if(transform.position==startPoint2.position){
             IsBlack=true;
        }
        if(transform.position==startPoint3.position){
             IsBlack=false;
        }
        if(isEnd==true){
           // Debug.Log("test");
            vic.SetActive(true);
           
           
        }
    }
    void FixedUpdate()
    {
       x=Input.GetAxisRaw("Horizontal");
       y=Input.GetAxisRaw("Vertical");
       Vector2 Movement=new Vector2(x,y);
       rb.velocity=Movement*speed*Time.deltaTime;
       UpdateAnimator();
    


    } 
    void UpdateAnimator(){
    
    if (x>0f){
        state=movementanim.left;
        sprite.flipX=true;
        
    }
    else if (x<0f){
        state=movementanim.left;
        sprite.flipX=false;
    }
    else {state=movementanim.idle;}
    if (y>0f){
        state=movementanim.back;
        
    }
    else if (y<0f){
        state=movementanim.front;
    }
    anim.SetInteger("state",(int)state);
    
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="black"){
            if(Input.GetKeyUp(KeyCode.J))
            {IsBlack=true;
            }
        }
        if(other.gameObject.tag=="white"){
           if(Input.GetKeyDown(KeyCode.J))
            {IsBlack=false;
            Debug.Log("test");
            }
            //else{
              // IsBlack=true; 
          //  }
        }
        if(other.gameObject.tag=="end"){
            if(Input.GetKeyDown(KeyCode.J)){
                isEnd=true;
            }
        }
        
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="white"){
           
            {IsBlack=false;}
        }
        
    }*/
    //void showText(){
      //   vic.SetActive(true);
    //}
}
