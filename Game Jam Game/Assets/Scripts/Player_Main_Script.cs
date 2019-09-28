using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main_Script : MonoBehaviour
{
    private float y_movement;
    private float x_movement;
    private float movementMultiplier = 1.0f;

    public GameObject coffee;
    public GameObject tea;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///Check for movement
        transform.position += new Vector3(x_movement, y_movement, 0.000f);

        ///Movement input
        if (Input.GetKey(KeyCode.A))
        {
            x_movement = -0.200f * movementMultiplier;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            x_movement = 0.200f * movementMultiplier;
        }
        else
        {
            x_movement = 0.000f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            y_movement = 0.10f * movementMultiplier;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            y_movement = -0.10f * movementMultiplier;
        }
        else
        {
            y_movement = 0.000f;
        }

        ///Screen Boundries

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("CollectableCoffee(Clone)"))
        {
            movementMultiplier += 0.1f;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.name.Equals("CollectableTea(Clone)"))
        {
            movementMultiplier -= 0.1f;
            Destroy(other.gameObject);
        }
    }
}
