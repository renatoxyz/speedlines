using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    [SerializeField] private float speedChangeRate = 5f;
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += speedChangeRate * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= speedChangeRate * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0, 100);
        animator.SetFloat("Speed", speed);
      
    }
}
