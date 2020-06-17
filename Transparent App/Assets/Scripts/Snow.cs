using UnityEngine;

public class Snow : MonoBehaviour
{
    public GameObject SnowExplosion;

    void Update()
    {
        var v3 = Input.mousePosition;
        v3.z = 20.0f;
        v3 = Camera.main.ScreenToWorldPoint(v3);

        transform.position = Vector2.MoveTowards(transform.position, v3, 1);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(SnowExplosion, transform.position, Quaternion.identity);
        }
    }
}
