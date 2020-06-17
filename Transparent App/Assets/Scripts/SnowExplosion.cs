using UnityEngine;

public class SnowExplosion : MonoBehaviour
{
    public float LifeTime;

    private float bornTime;

    private void Start()
    {
        bornTime = Time.time;
    }

    void Update()
    {
        if (bornTime + LifeTime < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
