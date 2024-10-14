using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 movevalue;
    public float speed;

    public int score = 0;
    // Start is called before the first frame update
    void OnMove(InputValue value)
    {
        movevalue = value.Get<Vector2>();
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movevalue.x, 0.0f, movevalue.y);
        GetComponent<Rigidbody>().AddForce(movement*speed*Time.fixedDeltaTime);

        if (score == 3)
        {
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            score += 1;
        }
    }
}
