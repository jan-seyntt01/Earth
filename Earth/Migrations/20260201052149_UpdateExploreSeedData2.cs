using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExploreSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullContent",
                value: "Biodiversity operates at multiple interconnected levels, encompassing genetic variation within populations, differences among species, and the complexity of ecosystems across terrestrial, freshwater, and marine environments. High levels of biodiversity contribute to ecosystem resilience by enabling natural systems to recover from disturbances such as climate variability, natural disasters, and disease outbreaks, while also maintaining essential ecological processes like nutrient cycling, soil formation, water filtration, and pollination.\nThe survival and development of human societies are deeply dependent on biodiversity, as it provides food sources, medicinal compounds, raw materials, and cultural value; however, modern human activities have dramatically accelerated biodiversity loss. Habitat fragmentation, deforestation, pollution, invasive species, and climate change have led to declining populations and increased extinction rates, making biodiversity conservation a global priority to preserve ecosystem services and maintain environmental balance for future generations.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullContent",
                value: "Earth’s climate system is governed by the interaction of several components, including the atmosphere, hydrosphere, cryosphere, lithosphere, and biosphere, which together regulate the distribution of energy received from the Sun. Processes such as the greenhouse effect, ocean circulation, and atmospheric dynamics play critical roles in maintaining temperature balance and shaping regional climate zones, ranging from polar regions to tropical rainforests.\nIn recent centuries, human-induced climate change has become a dominant force affecting the global climate system, primarily due to increased greenhouse gas emissions from industrialization, transportation, and land-use changes. These changes have resulted in rising global temperatures, altered precipitation patterns, increased frequency of extreme weather events, and disruptions to ecosystems, highlighting the urgent need for climate science, mitigation strategies, and sustainable environmental policies.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullContent",
                value: "Oceans function as a major component of Earth’s climate system by absorbing solar radiation and redistributing heat through global ocean currents, which influence atmospheric circulation and regional weather patterns. They also act as a significant carbon sink, absorbing large amounts of carbon dioxide from the atmosphere, thereby helping to regulate global climate and slow the pace of climate change.\nBeyond climate regulation, oceans support an extraordinary diversity of life, ranging from microscopic plankton to large marine mammals, forming complex food webs that sustain both marine and terrestrial ecosystems. However, ocean health is increasingly threatened by human activities such as pollution, plastic waste accumulation, overfishing, coral reef destruction, and ocean acidification, underscoring the importance of marine conservation and sustainable ocean management practices.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "FullContent",
                value: "The continents of Earth were formed through tectonic plate movements driven by processes within the planet’s mantle, resulting in the gradual shifting, collision, and separation of landmasses over geological time. These processes have produced major geological features such as mountain ranges, volcanic regions, plains, and sedimentary basins, all of which influence regional ecosystems and biodiversity patterns.\nContinents play a critical role in shaping global climate systems by influencing ocean currents, wind patterns, and precipitation distribution, which directly affect the development of ecosystems and human settlements. Understanding continental structure and dynamics is essential for studying Earth’s geological history, natural resource distribution, and the complex relationship between physical geography and environmental sustainability.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullContent",
                value: "Biodiversity encompasses the diversity of life at all levels, from genetic variation within species to entire ecosystems. Healthy biodiversity ensures that ecosystems can withstand environmental changes, provide food, regulate climate, and support natural cycles such as pollination and nutrient recycling.\nHuman activities such as deforestation, pollution, and climate change are major threats to biodiversity. Protecting biodiversity through conservation, sustainable resource use, and environmental awareness is critical to maintaining the balance of life on Earth and ensuring future generations can thrive.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullContent",
                value: "Climate influences where plants and animals can survive and how ecosystems function. Earth’s climate system is driven by interactions between the atmosphere, oceans, land surfaces, and ice, creating regional and global climate patterns over time.\nIn recent decades, human activities such as burning fossil fuels and deforestation have accelerated climate change. Rising global temperatures, melting ice caps, and extreme weather events highlight the importance of understanding climate systems and taking action to reduce environmental impact.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullContent",
                value: "Oceans play a crucial role in controlling Earth’s temperature by absorbing heat and carbon dioxide from the atmosphere. They also drive weather patterns and support global food systems through fisheries and marine ecosystems.\nDespite their importance, oceans face serious threats such as pollution, overfishing, and climate change. Protecting marine environments through sustainable practices and conservation efforts is essential for preserving ocean health and maintaining Earth’s ecological balance.");

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 4,
                column: "FullContent",
                value: "Earth’s continents were formed through tectonic plate movements over millions of years. These landmasses contain mountains, deserts, forests, and rivers that support diverse forms of life and natural resources essential to human civilization.\nContinents influence climate patterns by affecting ocean currents and atmospheric circulation. Understanding continental geography helps us better appreciate Earth’s natural processes and the interconnectedness between land, climate, and living organisms.");
        }
    }
}
