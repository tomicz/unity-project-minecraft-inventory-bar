using UnityEngine;

namespace Tomicz.Inventory
{
    public class InventoryBar : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private Slot _slot = null;

        [Header("Properties")]
        [SerializeField] private int _slotCount = 8;

        private void Awake()
        {
            CreateInventorySlots();
        }

        private void CreateInventorySlots()
        {
            for (int i = 0; i < _slotCount; i++)
            {
                Slot slot = Instantiate(_slot, transform);
            }
        }
    }
}