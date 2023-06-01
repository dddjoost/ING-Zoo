using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        public string AnimalName;
        [SerializeField] protected GameObject Balloon;
        [SerializeField] protected Text text;
        protected string message;
        
        public void SayHello(string name)
        {
            if (name != this.AnimalName && name != "") return;
            Balloon.SetActive(true);
            text.text = message;
        }
    }
}