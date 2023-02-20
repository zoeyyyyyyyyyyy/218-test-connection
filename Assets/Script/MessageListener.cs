/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;

/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */
public class MessageListener : MonoBehaviour
{
    public string buttonPressed;
    public float crank;
    public float z;
    public float delta_z;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(z);
        
        // Debug.Log(buttonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(z);
        Debug.Log("crank = " + crank);
        // Debug.Log(buttonPressed);
    }

    void OnMessageArrived(string msg)
    {
        // Debug.Log(msg);
        string[] msgSplit = msg.Split('|');
        buttonPressed = msgSplit[1];
        crank = float.Parse(msgSplit[0]);
        z = float.Parse(msgSplit[2]);
        delta_z = float.Parse(msgSplit[3]);
       
    }


    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
