using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer renderer;

    void Start()
    {
        Enemylives = 1;
        speed = 2;
        renderer = GetComponent<Renderer>();
        InvokeRepeating("ToggleVisibility", 3f, 3f);
    }

    void ToggleVisibility()
    {
        StartCoroutine(ToggleVisibilityRoutine());
    }

    private IEnumerator ToggleVisibilityRoutine()
    {
        renderer.enabled = false;
        yield return new WaitForSeconds(0.5f);
        renderer.enabled = true;
    }
}
