using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Tomicz.Inventory
{
    public class Slot : MonoBehaviour, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        public bool IsEmpty => _isEmpty;


        [Header("Dependencies")]
        [SerializeField] private Image _spriteContainer;
        [SerializeField] private ItemData _itemData;
        [SerializeField] private InventoryBar _inventoryBar;

        private bool _isEmpty = true;
        private bool _canDropItem = false;
        private float _dropThreshold = 10f;

        public void SetInventory(InventoryBar inventoryBar, float dropThreshold)
        {
            _inventoryBar = inventoryBar;
            _dropThreshold = dropThreshold;
        }

        public void AddItem(ItemData itemData)
        {
            _itemData = itemData;
            _isEmpty = false;
            _spriteContainer.sprite = _itemData.Icon;
        }

        private void RemoveItem()
        {
            _spriteContainer.sprite = null;
            _isEmpty = true;
            _itemData = null;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (!_canDropItem) return;

            RemoveItem();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _inventoryBar.DragSlot.Show();
        }

        public void OnDrag(PointerEventData eventData)
        {
            _inventoryBar.DragSlot.SetUIPosition(eventData.position);

            float distance = Vector2.Distance(transform.position, eventData.position);

            if(distance > _dropThreshold)
            {
                _canDropItem = true;
            }
            else
            {
                _canDropItem = false;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _inventoryBar.DragSlot.Hide();
        }
    }
}