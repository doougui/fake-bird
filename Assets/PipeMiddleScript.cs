using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            LogicManagerScript.instance.addScore(1);
        }
    }
}
