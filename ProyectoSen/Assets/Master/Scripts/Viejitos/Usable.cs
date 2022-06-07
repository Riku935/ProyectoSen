using UnityEngine;
using UnityEngine.Events;
namespace com.Amerike.outside
{
    public class Usable : MonoBehaviour
    {
        public UnityEvent OnUse;
        public void Use()
        {
            if (OnUse != null)
            {
                print("hola");
                OnUse.Invoke();
            }
        }
    }
}