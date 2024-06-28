using UnityEngine;

public class CloudSpawnerScript : ObjectSpawner
{
    void SetRandomSpawnRate()
    {
        spawnRate = Random.Range(0.5f, 5);
    }

    public override void Start()
    {
        SetRandomSpawnRate();
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0;
            SetRandomSpawnRate();
        }
    }
}
