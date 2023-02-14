using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game objects that are produced from and by ship game objects
/// They destroy asteroid on collision
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// The rigidbody 2d component of the game object
    /// </summary>
    Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Defines the direction the bullet will travel
    /// </summary>
    /// <param name="direction">The direction the bullet travels in</param>
    public void ApplyForce(Vector2 direction)
    {
        const float magnitude = 10.0f;

        rb2d.AddForce(
            magnitude * direction,
            ForceMode2D.Impulse
        );
    }
}
