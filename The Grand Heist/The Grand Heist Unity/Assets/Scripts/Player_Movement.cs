using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public CharacterController characterController;
    public float Speed = 12f;
    
    // Start is called before the first frame update
    void Start()
    {
    

        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();

    }

    public void playerMovement()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 targetArea = transform.right * xAxis + transform.forward * zAxis;

        characterController.Move(targetArea * Speed * Time.deltaTime);

    }


}
