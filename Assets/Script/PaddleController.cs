using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    { 
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        // Gerak Objek
        rig.velocity = movement;
    }

    public void Activateppaddle(int newSize)
    {
        
    }

    public void Activatepaddlespeed(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public static bool hasStatusEffect;
    public static bool isShrunk;
    public static bool isLarge;

    public void SetPaddleSize(int newSize)
    {
        hasStatusEffect = true;

        // Set the status effect
        if (newSize == 3)
        {
            isShrunk = true;
        }

        if (newSize == 7)
        {
            isLarge = true;
        }

        // Resize the Paddle
        Vector3 scale = transform.localScale;
        scale.y = newSize;
        transform.localScale = scale;
    }
}