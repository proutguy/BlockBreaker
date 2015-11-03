using UnityEngine;
using System.Collections;

public class loose_collider : MonoBehaviour
{
    public LevelManager levelManager;
    void OnTriggerEnter2D (Collider2D trigger)
    {
        Debug.Log("trigger");
        levelManager.LoadLevel("Lose");

    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log("collision");
    }
}
