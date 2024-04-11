using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachines : MonoBehaviour
{
    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }
    public State currentstate = State.idle;
    Vector3 LastPosition;
        // Start is called before the first frame update
    void Start()
    {
        LastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       switch(currentstate)
        {
            case State.idle: Idle(); break;
            case State.walking: Walking(); break;
            case State.swimming: Swimming(); break;
            case State.climbing: Climbing(); break;
                default: break; 

        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "WaterTrigger")
        {
            Swimming();
        }
    }
     void OnTriggerExit(Collider other)
    {
       
    }
    void Swimming()
    {
        Debug.Log("I am swimming");
    }

    void Climbing()
    {
        Debug.Log("I am climming");
    }
    void Idle()
    {
        Debug.Log("I am idle");
        if(LastPosition != transform.position)
        {
            Debug.Log("Moving");
        }
        LastPosition = transform.position;
    }
    void Walking()
    {
        Debug.Log("I am walking");
    }
}
