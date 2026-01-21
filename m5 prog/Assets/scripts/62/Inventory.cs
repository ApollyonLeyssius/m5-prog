using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // List storing runtime item instances (Class)
    private List<Item> items = new List<Item>();

    // ScriptableObject templates assigned in Inspector
    [SerializeField] private ItemTemplate[] itemTemplates;

    // Enum used as filter
    [SerializeField] private ItemType filterType;

    private void Start()
    {
        // Create runtime items from templates
        foreach (ItemTemplate template in itemTemplates)
        {
            Item newItem = template.CreateInstance();
            items.Add(newItem);

            Debug.Log(newItem.Describe());
        }
    }

    public List<Item> GetItemsByType(ItemType type)
    {
        List<Item> filtered = new List<Item>();

        foreach (Item item in items)
        {
            if (item.ItemType == type)
            {
                filtered.Add(item);
            }
        }

        return filtered;
    }

    private void Update()
    {
        // Press Space to print filtered items
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("=== FILTERED ITEMS: " + filterType + " ===");

            List<Item> filteredItems = GetItemsByType(filterType);

            foreach (Item fi in filteredItems)
            {
                Debug.Log(fi.Describe());
            }
        }
    }
}
