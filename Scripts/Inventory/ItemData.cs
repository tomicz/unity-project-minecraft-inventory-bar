using UnityEngine;

namespace Tomicz.Inventory
{
    [CreateAssetMenu(fileName = "Item", menuName = "Data/ New Item")]
    public class ItemData : ScriptableObject
    {
        public Sprite Icon => _icon;

        [SerializeField] private Sprite _icon;
    }
}