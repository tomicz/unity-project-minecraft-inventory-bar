using UnityEngine;
using UnityEngine.UI;

namespace Tomicz.Inventory
{
    public class Slot : MonoBehaviour
    {
        public bool IsEmpty => _isEmpty;

        [Header("Dependencies")]
        [SerializeField] private Image _spriteContainer;
        [SerializeField] private ItemData _itemData;

        private bool _isEmpty = true;

        public void AddItem(ItemData itemData)
        {
            _itemData = itemData;
            _isEmpty = false;
            _spriteContainer.sprite = _itemData.Icon;
        }

        public void RemoveItem()
        {
            _spriteContainer.sprite = null;
            _isEmpty = true;
            _itemData = null;
        }
    }
}