namespace FlowerShop
{
    using System.Collections.Generic;

    public class FlowerShopModel
    {
        public List<Rose> Roses { get; set; } = new List<Rose>();
        public List<Chrysanthemum> Chrysanthemums { get; set; } = new List<Chrysanthemum>();
        public List<DragonsBreath> DragonsBreaths { get; set; } = new List<DragonsBreath>();
        public List<Tulip> Tulips { get; set; } = new List<Tulip>();

        public List<IMothersDayFlower> MakeMothersDayArrangement()
        {
            List<IMothersDayFlower> arrangement = new List<IMothersDayFlower>() {
                new Rose() { StemLength = 12.5 },
                new Tulip() { StemLength = 8.5 },
                new Rose() { StemLength = 7.5 },
                new Tulip() { StemLength = 9.5 },
                new Rose() { StemLength = 10.5 },
                new Chrysanthemum() { StemLength = 6.5 }
                };

            return arrangement;
        }

        public List<IBirthdayFlower> MakeBirthdayArrangement()
            {
                List<IBirthdayFlower> arrangement = new List<IBirthdayFlower>() {
                new DragonsBreath() { Color = "Blue & White" },
                new DragonsBreath() { Color = "Red & White" },
                new DragonsBreath() { Color = "Blue & White" },
                new Chrysanthemum() { Color = "Purple & White"},
                new Chrysanthemum() { Color = "White" },
                };

                return arrangement;
            }
    }
}
