using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    private List<Enemy> enemies = new List<Enemy>();

    private void Start()
    {
        enemies = new List<Enemy>
        {
            new GameObject().AddComponent<Zombie>(),
            new GameObject().AddComponent<Goblin>(),
            new GameObject().AddComponent<Dragon>(),
            new GameObject().AddComponent<Troll>() 
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("=== ALL ENEMIES ATTACK ===");

            foreach (Enemy enemy in enemies)
            {
                enemy.Attack(gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("=== ALL ENEMIES TAKE DAMAGE ===");

            foreach (Enemy enemy in enemies)
            {
                enemy.TakeDamage(25f);
            }

            // Remove dead enemies safely
            enemies.RemoveAll(e => e == null);
        }
    }
}
