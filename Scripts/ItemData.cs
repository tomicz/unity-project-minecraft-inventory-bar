using UnityEngine;

namespace Tomicz.Inventory
{
    [CreateAssetMenu(fileName = "Item", menuName = "Data/ New Item")]
    public class ItemData : ScriptableObject
    {
        [SerializeField] private Sprite _icon;
    }
}