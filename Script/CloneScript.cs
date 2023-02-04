using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    private List<ActionReplay> PreInput;
    int i=0;
    
    private float xinp;
    private float jk;
    public Rigidbody2D rb;
    private float speed;
    void Start()
    {
    
        PlayerScript sc=GameObject.Find("Player").GetComponent<PlayerScript>();
        PreInput=sc.InputRecord;
        speed=sc.speed;
    }

    // Update is called once per frame
    void Update()
    {
       
     
       
    }

    void FixedUpdate() {

        
        ActionReplay temp=PreInput[i];
        xinp=temp.Xinput;
        jk=temp.jInput;
        i++;
        rb.transform.position=new Vector2 ( rb.transform.position.x + speed*xinp*Time.deltaTime,rb.transform.position.y+ jk*speed*Time.deltaTime);
       
           
    }

}
