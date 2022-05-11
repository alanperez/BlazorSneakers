namespace BlazorSneakers.Server.Data
{
    //
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                Id = 1, Title = "OVO x Air Jordan 10 Retro 'Black 2014",  
                Description = "The OVO x Air Jordan 10 Retro Black received a super limited quickstrike release at an OVO pop-up in Los Angeles in April 2015 alongside a white colorway. The design features a premium tumbled black leather upper with stingray skin overlays, metallic gold accents, and a translucent outsole. The sneaker re-released during the 2016 NBA All-Star weekend in Toronto. In September of 2016, the two colorways were restocked online and sold out instantly",
                ImageUrl = "https://image.goat.com/transform/v1/attachments/product_template_additional_pictures/images/008/490/973/original/40672_01.jpg.jpeg?action=crop&width=750",
                Price = 200m
                },
                new Product
                {
                    Id = 2,
                    Title = "Kobe 11 Elite Low Fade to Black",
                    Description = "The Nike Kobe 11 Elite Low FTB was worn by Kobe Bryant in his final NBA game against the Utah Jazz on April 13, 2016. The 37-year-old ended his career with 60 points, 4 rebounds, 4 assists, 1 block, and 1 steal. The shoe features a black Flyknit upper with a metallic gold Swoosh. Released in April 2016, the 'FTB' was the final release in Nike's 'Fade to Black' Collection that released new colorways for all of Kobe Bryant's signature models. ",
                    ImageUrl = "https://image.goat.com/transform/v1/attachments/product_template_additional_pictures/images/009/501/936/original/45407_01.jpg.jpeg?action=crop&width=750",
                    Price = 1200m
                },
                new Product
                {
                    Id = 3,
                    Title = "Off-White x Blazer Mid Grim Reapers",
                    Description = "Releasing alongside an accompanying All Hallow's Eve colorway in orange, the Off-White x Blazer Mid Grim Reapers completes Virgil Abloh's Halloween-themed sneaker pack. The black and grey upper sports contrast orange stitching in celebration of the October holiday, along with an oversized white Swoosh, blue zip tie and Off-White lettering on the quarter panel of the shoe's medial side.",
                    ImageUrl = "https://image.goat.com/transform/v1/attachments/product_template_additional_pictures/images/015/072/548/original/406001_01.jpg.jpeg?action=crop&width=750",
                    Price = 1250m
                }
                );
        }

        public DbSet<Product> Products { get; set; }

    }
}
