using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LeftButton : Button
{
    // Start is called before the first frame update
    public bool isPressed = false;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        isPressed = true;
        //Vector3 direction = player2.transform.forward.normalized;
        //Vector3 forceVector = (direction * jumpLength);
        //player2.GetComponent<Rigidbody>().velocity = forceVector;
        //player2.transform.rotation = Quaternion.LookRotation(direction);
    }

    // Button is released
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        isPressed = false;
        //player2.GetComponent<Rigidbody>().velocity = Vector3.zero;
        //player2.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
