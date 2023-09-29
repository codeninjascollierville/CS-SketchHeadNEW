using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")]
    public Rigibody2D rb;
    [Header("Default Down Speed")]


    public float DownSpeed = 20f;
    [Header("Default Movement Speed ")]


    public float MovmentSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    public float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigibody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (movement < 0)
        {
            this.GetComponent<SpiritRender>().flipX = false;
        }

    }
}
