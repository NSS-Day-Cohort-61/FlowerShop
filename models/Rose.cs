namespace FlowerShop
{
    public class Rose : IMothersDayFlower
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
    
        public bool Thorny { get; set; }
        public double StemLength { get; set; }

        public override string ToString()
        {
            return $"A fanciful {Color} rose with {PetalCount} petals.";
        }
    }
}

