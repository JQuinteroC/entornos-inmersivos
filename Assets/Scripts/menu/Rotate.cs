using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationY;

    private float rotateSpeedModifier = 0.1f;

    void Start(){

    }

    void Update(){
        if(Input.touchCount > 0){
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
                rotationY = Quaternion.Euler(
                    0f,
                    - touch.deltaPosition.x * rotateSpeedModifier,
                    0f
                );
                Debug.Log("Girando");
                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
}