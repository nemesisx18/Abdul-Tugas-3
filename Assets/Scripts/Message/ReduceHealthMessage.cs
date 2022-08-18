namespace SpaceInvader.Message
{
    public struct ReduceHealthMessage
    {
        public int Health { get; private set; }

        public ReduceHealthMessage(int health)
        {
            Health = health;
        }
    }
}