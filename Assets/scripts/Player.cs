using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour

{
    [SerializeField]
    private float _speed = 3.5f;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

        
        //take the current postion = new postion (0, 0, 0,)
        transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {     
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

         //new vector(1, 0, 0) * real time
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
       //transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

       Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

       transform.Translate(direction * _speed *Time.deltaTime);

        
        
    }
}
