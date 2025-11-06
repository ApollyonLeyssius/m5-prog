using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected int Enemylives;
    protected int speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    protected void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Enemylives--;
            if (Enemylives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
