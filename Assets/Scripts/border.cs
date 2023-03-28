using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{
    public int failNum;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("normal"))
        {
            failNum++;
            Debug.Log("错过！");
            Destroy(other.gameObject);
        }
    }
}
