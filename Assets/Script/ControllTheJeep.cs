using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllTheJeep : MonoBehaviour
{
    public MessageListener messageListenerScript;
    public float jeepY = 2.0f;
    public float Force = 0.4f;
    public float Force2 = 0.1f;
    public float Speed = 1;

    private Rigidbody2D rb;
    public Vector3 v;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        v = this.transform.position;

        // if (v.y < jeepY ) {
        //     if(Input.GetKeyDown("space"))
        //         {
        //             transform.position += new Vector3(0,Force,0);
                    

        //         }
        // }

        if(messageListenerScript.buttonPressed.Equals(" False "))
                {
                    transform.position += new Vector3(0,Force * Time.deltaTime * Speed,0);
                    

                }
        
        if(messageListenerScript.crank < 0)
            {
    
                if (messageListenerScript.crank > -4)
                {
                    transform.position += new Vector3(Force2 * messageListenerScript.crank,0,0);
                


                } 

            }
        
        if(messageListenerScript.crank > 0)
            {
    
                if (messageListenerScript.crank < 4)
                {
                    transform.position -= new Vector3(Force2 * - messageListenerScript.crank,0,0);

                } 

            }


        // if(messageListenerScript.z > -10)
        // {
        //     transform.position += new Vector3(0,Force2 * -messageListenerScript.delta_z,0);
        // }
        
    }
}
