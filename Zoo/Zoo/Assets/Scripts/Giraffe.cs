namespace Zoo
{
    public class Giraffe : Animal
    {
     
        private const string eatLeavesText = "What about supper?";
        private void Start()
        {
            message = "Hellooowww";
        }

        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatLeaves += EatLeaves;
            
        }

        private void OnDisable()
        {
            EventManager.SayHello -= SayHello;
            EventManager.EatLeaves -= EatLeaves;
            
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = eatLeavesText;
        }
    }
}