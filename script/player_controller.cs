using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
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
    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;
    public GameObject pic6;
    public GameObject showpic1;
    public GameObject showpic2;
    public GameObject showpic3;
    public GameObject showpic4;
    public GameObject showpic5;
    public GameObject showpic6;
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
            IsBlack=true;
        }
        if(transform.position==startPoint2.position){
             IsBlack=false;
        }
        if(isEnd==true){
           // Debug.Log("test");
            pic1.SetActive(false);
            pic2.SetActive(false);
            pic3.SetActive(false);
            pic4.SetActive(false);
            pic5.SetActive(false);
            pic6.SetActive(false);
            showpic1.SetActive(true);
            showpic2.SetActive(true);
            showpic3.SetActive(true);
            showpic4.SetActive(true);
            showpic5.SetActive(true);
            showpic6.SetActive(true);
            Invoke("showText",5f);//这块需要改动一下
           
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
            {IsBlack=false;}
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
    void showText(){
         vic.SetActive(true);
    }
     
}
