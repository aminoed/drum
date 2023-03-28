using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour
{
    public Rigidbody2D rb;

    public Vector2 targetPos;
    private GameObject gen;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {

    }
    void Update()
    {
        if (transform.position.y == 2.1f)
        {
            targetPos.y = 2.1f; targetPos.x = -10f;
            //匀速运动
            transform.position = Vector2.MoveTowards(transform.position, targetPos, 0.02f * Time.timeScale);
        }
        if (transform.position.y == 0.88f)
        {
            targetPos.y = 0.88f; targetPos.x = -10f;
            transform.position = Vector2.MoveTowards(transform.position, targetPos, 0.02f * Time.timeScale);
        }
    }
}
