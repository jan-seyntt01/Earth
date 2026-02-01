using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Earth.Models;

namespace Earth.Data
{
    public class EarthContext : DbContext
    {
        public EarthContext (DbContextOptions<EarthContext> options)
            : base(options)
        {
        }

        public DbSet<Earth.Models.EarthModel> EarthModel { get; set; } = default!;
        public DbSet<AboutContent> AboutContents { get; set; } = default!;
        public DbSet<ExploreTopic> ExploreTopics { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial AboutContent
            modelBuilder.Entity<AboutContent>().HasData(
                new AboutContent
                {
                    Id = 1,
                    Introduction = "Founded in 2026, HelloEarth began as a small project to bridge the gap between complex planetary science and everyday curiosity. We believe that understanding Earth is the first step toward protecting it. Our platform provides immersive data, historical context, and real-time insights into the systems that sustain life.",
                    Mission = "To empower global citizens with accessible, science-based knowledge about Earth's changing environments.",
                    Vision = "A world where environmental literacy is universal, leading to a sustainable and thriving future for all.",
                    ImagePath = "/images/about-hero.jpg",
                    LastUpdated = new DateTime(2026, 2, 1)
                }
            );

            // Seed simple ExploreTopics
            modelBuilder.Entity<ExploreTopic>().HasData(
                new ExploreTopic
                {
                    Id = 1,
                    Title = "Biodiversity",
                    ShortDescription = "Biodiversity refers to the variety of living organisms on Earth, including plants, animals, and microorganisms. It is essential for ecosystem stability and human survival.",
                    ImagePath = "/images/bio.jpg",
                    FullContent = "Biodiversity operates at multiple interconnected levels, encompassing genetic variation within populations, differences among species, and the complexity of ecosystems across terrestrial, freshwater, and marine environments. High levels of biodiversity contribute to ecosystem resilience by enabling natural systems to recover from disturbances such as climate variability, natural disasters, and disease outbreaks, while also maintaining essential ecological processes like nutrient cycling, soil formation, water filtration, and pollination.\n" +
                    "The survival and development of human societies are deeply dependent on biodiversity, as it provides food sources, medicinal compounds, raw materials, and cultural value; however, modern human activities have dramatically accelerated biodiversity loss. Habitat fragmentation, deforestation, pollution, invasive species, and climate change have led to declining populations and increased extinction rates, making biodiversity conservation a global priority to preserve ecosystem services and maintain environmental balance for future generations.",
                    KeyFacts = "• Earth has 8.7 million species\n• Rainforests contain 50% of world's species\n• 1 million species face extinction",
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new ExploreTopic
                {
                    Id = 2,
                    Title = "Climate",
                    ShortDescription = "Climate describes the long-term patterns of temperature, precipitation, and weather conditions on Earth. It plays a major role in shaping ecosystems and human societies.",
                    ImagePath = "/images/climate.jpg",
                    FullContent = "Earth’s climate system is governed by the interaction of several components, including the atmosphere, hydrosphere, cryosphere, lithosphere, and biosphere, which together regulate the distribution of energy received from the Sun. Processes such as the greenhouse effect, ocean circulation, and atmospheric dynamics play critical roles in maintaining temperature balance and shaping regional climate zones, ranging from polar regions to tropical rainforests.\n" +
                    "In recent centuries, human-induced climate change has become a dominant force affecting the global climate system, primarily due to increased greenhouse gas emissions from industrialization, transportation, and land-use changes. These changes have resulted in rising global temperatures, altered precipitation patterns, increased frequency of extreme weather events, and disruptions to ecosystems, highlighting the urgent need for climate science, mitigation strategies, and sustainable environmental policies.",
                    KeyFacts = "• Global temperature rose 1.1°C since 1880\n• CO2 levels are highest in 3 million years\n• Sea levels rising 3.3 mm per year",
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new ExploreTopic
                {
                    Id = 3,
                    Title = "Oceans",
                    ShortDescription = "Oceans cover more than 70% of Earth’s surface and are vital to life on the planet. They regulate climate and support a vast range of marine life.",
                    ImagePath = "/images/oceans.jpg",
                    FullContent = "Oceans function as a major component of Earth’s climate system by absorbing solar radiation and redistributing heat through global ocean currents, which influence atmospheric circulation and regional weather patterns. They also act as a significant carbon sink, absorbing large amounts of carbon dioxide from the atmosphere, thereby helping to regulate global climate and slow the pace of climate change.\n" +
                    "Beyond climate regulation, oceans support an extraordinary diversity of life, ranging from microscopic plankton to large marine mammals, forming complex food webs that sustain both marine and terrestrial ecosystems. However, ocean health is increasingly threatened by human activities such as pollution, plastic waste accumulation, overfishing, coral reef destruction, and ocean acidification, underscoring the importance of marine conservation and sustainable ocean management practices.",
                    KeyFacts = "• Oceans cover 71% of Earth\n• Average depth is 3,688 meters\n• Oceans produce 50-80% of Earth's oxygen",
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new ExploreTopic
                {
                    Id = 4,
                    Title = "Continents",
                    ShortDescription = "Continents are large landmasses that shape Earth’s geography and influence climate, biodiversity, and human development. Each continent has unique landscapes and ecosystems.",
                    ImagePath = "/images/continents.jpg",
                    FullContent = "The continents of Earth were formed through tectonic plate movements driven by processes within the planet’s mantle, resulting in the gradual shifting, collision, and separation of landmasses over geological time. These processes have produced major geological features such as mountain ranges, volcanic regions, plains, and sedimentary basins, all of which influence regional ecosystems and biodiversity patterns.\n" +
                    "Continents play a critical role in shaping global climate systems by influencing ocean currents, wind patterns, and precipitation distribution, which directly affect the development of ecosystems and human settlements. Understanding continental structure and dynamics is essential for studying Earth’s geological history, natural resource distribution, and the complex relationship between physical geography and environmental sustainability.",
                    KeyFacts = "• Asia is the largest continent\n• Africa is the 'cradle of humankind'\n• Antarctica holds 90% of world's ice",
                    CreatedDate = new DateTime(2026, 1, 1)
                }
            );
        }
    }
}

