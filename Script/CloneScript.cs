using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    private List<ActionReplay> PreInput;
    public PlayerScript sc;
    int i=0;
    public GameObject clnObj;
    public Rigidbody2D rb;
    private float speed;
    void Start()
    {
        clnObj.SetActive(false);
        rb=clnObj.GetComponent<Rigidbody2D>();
        PreInput=sc.InputRecord;
        speed=sc.speed;
    }

    // Update is called once per frame
    void Update()
    {
       
    
        if(Time.time>5){
            
        ActionReplay temp=PreInput[i];
        rb.transform.position=new Vector2 ( rb.transform.position.x + speed*temp.Xinput*Time.deltaTime,rb.transform.position.y+ temp.jInput*speed*Time.deltaTime);
        

        i++;
        }
    }



}
