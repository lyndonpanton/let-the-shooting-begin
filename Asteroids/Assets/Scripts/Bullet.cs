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

    /// <summary>
    /// The amount of time before the game object is automatically destroyed
    /// </summary>
    const float totalLifeTime = 2.0f;

    /// <summary>
    /// Stores the amount of time the game object has been alive
    /// </summary>
    Timer deathTimer;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        deathTimer = GetComponent<Timer>();
        deathTimer.Duration = totalLifeTime;
        deathTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (deathTimer.Finished)
        {
            Destroy(gameObject);
        }
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
