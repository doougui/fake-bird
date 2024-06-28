using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public Animator wingsFlap;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidbody.velocity = Vector2.up * flapStrength;
            wingsFlap.CrossFade("WingsFlap", 0.01f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LogicManagerScript.instance.gameOver();
        birdIsAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag != "Killer") return;
        LogicManagerScript.instance.gameOver();
        birdIsAlive = false;
    }
}
