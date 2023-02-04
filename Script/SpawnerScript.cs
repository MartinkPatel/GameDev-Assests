using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject PlayerPrefab;
    public Transform[] spwanpoints;

    public float TimeToSpawn=5;

    // Start is called before the first frame update
    
    bool spwanned= false;
    // Update is called once per frame
    void Update()
    {

        if(Time.time>TimeToSpawn && !spwanned){
            
            Spwan();


            spwanned=true;
        }

        if(spwanned){
            
        }
    }

    void Spwan(){


        Vector3 sp=new Vector3(1,0,0);
        Instantiate(PlayerPrefab,sp,Quaternion.identity);

    }


}
