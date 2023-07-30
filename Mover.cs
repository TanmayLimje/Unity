using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    /*
    // these variable change our movement speed
    [SerializeField]    float xValue = 0.0f;
    [SerializeField]    float yValue = 0.0f;
    [SerializeField]    float zValue = 0.0f;
    */

    [SerializeField] float moverSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
       printInstructions(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void printInstructions()
    {
        // this will print in the console of unity.
        Debug.Log("Welocme to the game");
        Debug.Log("Move your Player with WASD or arrow keys.");
        Debug.Log("Dont hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moverSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moverSpeed;

        transform.Translate(xValue,0,zValue);
    }

}
