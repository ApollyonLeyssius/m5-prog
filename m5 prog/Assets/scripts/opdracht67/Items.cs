using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Items : MonoBehaviour
{
    [SerializeField] private Image itemImageHolder;
    [SerializeField] private Shipmovement movement;
    [SerializeField] private Shooting shooting;
    [SerializeField] private ShipUi ui;

    private List<Color> items = new List<Color>();
    private int activeItemIndex = -1;

    private void Update()
    {
        CycleItems();
        UseItem();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            PickUpItem(other.gameObject);
        }
    }

    private void PickUpItem(GameObject item)
    {
        Color color = item.GetComponent<Renderer>().material.color;
        Destroy(item);

        items.Add(color);
        activeItemIndex = items.Count - 1;
        UpdateItemUI();
    }

    private void CycleItems()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count == 0)
            {
                itemImageHolder.enabled = false;
                return;
            }

            activeItemIndex = (activeItemIndex + 1) % items.Count;
            UpdateItemUI();
        }
    }

    private void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.E) && activeItemIndex != -1)
        {
            Color itemColor = items[activeItemIndex];

            if (itemColor == Color.blue)
            {
                ui.ShowMessage("+ Move Speed");
                movement.IncreaseMoveSpeed(5);
            }
            else if (itemColor == Color.red)
            {
                ui.ShowMessage("+ Fire Rate");
                shooting.IncreaseFireRate(0.1f);
            }
            else if (itemColor == Color.green)
            {
                ui.ShowMessage("+ Rotation Speed");
                movement.IncreaseRotationSpeed(10);
            }

            items.RemoveAt(activeItemIndex);
            if (items.Count == 0)
                activeItemIndex = -1;
            else
                activeItemIndex %= items.Count;

            UpdateItemUI();
        }
    }

    private void UpdateItemUI()
    {
        if (activeItemIndex != -1)
        {
            itemImageHolder.color = items[activeItemIndex];
            itemImageHolder.enabled = true;
        }
        else
        {
            itemImageHolder.enabled = false;
        }
    }
}
