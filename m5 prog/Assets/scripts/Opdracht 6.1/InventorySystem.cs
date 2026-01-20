using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Inventory storage
    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    // World item counts shown in Inspector
    [SerializeField] private int worldGuns = 2;
    [SerializeField] private int worldMedipacks = 4;
    [SerializeField] private int worldKeycards = 1;

    private void Update()
    {
        HandleInput();
    }

    /// <summary>
    /// Handles keyboard input for picking up or dropping items.
    /// </summary>
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ToggleItem<GunItem>(ref worldGuns);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleItem<MedipackItem>(ref worldMedipacks);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            ToggleItem<KeycardItem>(ref worldKeycards);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayStatus();
        }
    }

    /// <summary>
    /// Picks up or drops an item depending on availability.
    /// </summary>
    private void ToggleItem<T>(ref int worldCount) where T : InventoryItem, new()
    {
        // If world has items -> pick up
        if (worldCount > 0)
        {
            inventoryItems.Add(new T());
            worldCount--;
            Debug.Log("Picking up a " + typeof(T).Name + "!");
        }
        // Otherwise drop from inventory
        else
        {
            InventoryItem item = inventoryItems.Find(i => i is T);
            if (item != null)
            {
                inventoryItems.Remove(item);
                worldCount++;
                Debug.Log("Dropping a " + typeof(T).Name + "!");
            }
        }
    }

    /// <summary>
    /// Displays world and inventory status in the Console.
    /// </summary>
    private void DisplayStatus()
    {
        int gunsInInventory = inventoryItems.FindAll(i => i is GunItem).Count;
        int medipacksInInventory = inventoryItems.FindAll(i => i is MedipackItem).Count;
        int keycardsInInventory = inventoryItems.FindAll(i => i is KeycardItem).Count;

        Debug.Log(
            "\n=== ITEMS IN WORLD ===" +
            "\nMedipacks : " + worldMedipacks +
            "\nGuns : " + worldGuns +
            "\nKeycards : " + worldKeycards +
            "\n\n=== ITEMS IN INVENTORY ===" +
            "\nMedipacks : " + medipacksInInventory +
            "\nGuns : " + gunsInInventory +
            "\nKeycards : " + keycardsInInventory
        );
    }
}
