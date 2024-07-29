using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //declaring variable for rotation around 
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //target 
        //rotate axis up
        //speed
       transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime); 
    }
}
