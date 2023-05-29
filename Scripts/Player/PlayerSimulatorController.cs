using Tomicz.Inventory;
using UnityEngine;

namespace Tomicz.Player
{
    public class PlayerSimulatorController : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private InventoryBar _inventoryBar;

        [SerializeField] private ItemData[] _itemDatabase;

        public void AddRandomItemAtBeginning()
        {
            _inventoryBar.AddItem(_itemDatabase[Random.Range(0, _itemDatabase.Length)]);
        }
    }
}