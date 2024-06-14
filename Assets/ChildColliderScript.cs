using UnityEngine;

public class ChildColliderScript : MonoBehaviour
{
    // Declare any variables or properties you want to access
    public int health = 100;
    public float damageAmount = 10f;

    // Example method to apply damage
    public void TakeDamage(float amount)
    {
        health -= (int)amount;
        Debug.Log("Child object health: " + health);
    }

    // Example method for handling collisions
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Child object collided with: " + other.name);
        // You can add more logic here based on the collision
    }

}
