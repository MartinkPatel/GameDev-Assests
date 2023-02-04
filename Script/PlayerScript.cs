using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour

{
    public List<ActionReplay> InputRecord= new List<ActionReplay>();
    public Rigidbody2D rb;
    private float horizontal;
    public float jumpingPower=10f;
    public float speed=5f; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb.transform.position=new Vector2(1,0);
    }

    // Update is called once per frame
    void Update()
    {
    


    

    }
    
     void FixedUpdate() {

        horizontal=Input.GetAxisRaw("Horizontal");   
        ActionReplay temp=new ActionReplay{Xinput=horizontal,jInput=0};
        InputRecord.Add(temp);
        rb.transform.position=(new Vector2(rb.transform.position.x +speed*horizontal*Time.deltaTime,rb.transform.position.y ));    
    }
 
}
