using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Assignables
    public CharacterController controller;
    public GameObject cam;
    
    //Movement
    public float moveSpeed;
    
    
    //Jumping
    
    //Look
    public float sensitivity;
    
    // Start is called before the first frame update
    void Start()
    { 
       controller = GetComponent<CharacterController>();
        
       Cursor.lockState = CursorLockMode.Locked
       Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
