using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obj;
    public float spawnRate = 5;
    protected float timer = 0;
    public float heightOffset = 8;

    // Start is called before the first frame update
    public virtual void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (LogicManagerScript.instance.gameOverScreen.activeSelf) return;
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0;
        }
    }

    public virtual void Spawn()
    {
        if (LogicManagerScript.instance.gameOverScreen.activeSelf) return;
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(obj, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
