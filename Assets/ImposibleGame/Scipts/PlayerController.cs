using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick;
    public float speed = 5;
    public Transform spawnPoint;

    void Update()
    {
        Vector3 direction = new Vector3();
        direction.x = joystick.Horizontal;
        direction.z = joystick.Vertical;
        direction.Normalize();

        if (direction != Vector3.zero)
            transform.forward = direction;

        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Teleporter")
        {
            LevelManager.inst.LoadTrap();
            transform.position = spawnPoint.position;
        }
        else if(collision.transform.tag == "Trap")
        {
            transform.position = spawnPoint.position;
        }
    }
}
