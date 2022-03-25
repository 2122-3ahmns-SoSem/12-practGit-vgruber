using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLuki : MonoBehaviour

{
    public Vector2 speed = new Vector2(50,50);
    private GameObject lukiii;
    
    // Start is called before the first frame update
    void Start()
    {
        lukiii = GameObject.FindGameObjectWithTag("PLayer");
    }

    // Update is called once per frame
    void Update()
    {
     
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

            movement *= Time.deltaTime;

            transform.Translate(movement);
      
    }
}
