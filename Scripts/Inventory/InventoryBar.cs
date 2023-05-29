using UnityEngine;

namespace Tomicz.Inventory
{
    public class InventoryBar : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private Slot _slot = null;

        [Header("Properties")]
        [SerializeField] private int _slotCount = 8;

        private Slot[] _slotArray;

        private void Awake()
        {
            CreateInventorySlots();
        }

        public void AddItem(ItemData itemData)
        {
            if (GetEmptySlotIndex() == -1) return;

            _slotArray[GetEmptySlotIndex()].AddItem(itemData);
        }

        private void CreateInventorySlots()
        {
            _slotArray = new Slot[_slotCount];

            for (int i = 0; i < _slotCount; i++)
            {
                Slot slot = Instantiate(_slot, transform);
                _slotArray[i] = slot;
            }
        }

        private int GetEmptySlotIndex()
        {
            int emptySlotIndex = -1;

            foreach(var slot in _slotArray)
            {
                emptySlotIndex += 1;
                if (slot.IsEmpty)
                {
                    return emptySlotIndex;
                }
            }

            return -1;
        }
    }
}