using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    // You can't put this script in the player object directly, and instead it must be on
    // a different object (LookY). The reason being is because we rely on the Y of the player for 
    // movement. If we put this script on the player, we would move in the direction in which
    // we are looking. IE: if we look down, we will move down torwards the floor. 

    [SerializeField]
    private float _sensivity = 1f; // sensitivity of the mouse

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= _mouseY * _sensivity;
        transform.localEulerAngles = newRotation;
    }
}
