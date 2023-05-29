using UnityEngine;

namespace Tomicz.Inventory
{
    public class InventoryBar : MonoBehaviour
    {
        public DragSlot DragSlot => _dragSlot;

        [Header("Dependencies")]
        [SerializeField] private Slot _slot = null;
        [SerializeField] private DragSlot _dragSlot = null;

        [Header("Properties")]
        [SerializeField] private int _slotCount = 8;
        [SerializeField] private float _dropThreshold = 10f;

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
                slot.SetInventory(this, _dropThreshold);

                _slotArray[i] = slot;
            }

            _dragSlot.Hide();
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