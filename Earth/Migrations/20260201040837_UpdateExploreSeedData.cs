using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExploreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Biodiversity encompasses the diversity of life at all levels, from genetic variation within species to entire ecosystems. Healthy biodiversity ensures that ecosystems can withstand environmental changes, provide food, regulate climate, and support natural cycles such as pollination and nutrient recycling.\nHuman activities such as deforestation, pollution, and climate change are major threats to biodiversity. Protecting biodiversity through conservation, sustainable resource use, and environmental awareness is critical to maintaining the balance of life on Earth and ensuring future generations can thrive.", "Biodiversity refers to the variety of living organisms on Earth, including plants, animals, and microorganisms. It is essential for ecosystem stability and human survival." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Climate influences where plants and animals can survive and how ecosystems function. Earth’s climate system is driven by interactions between the atmosphere, oceans, land surfaces, and ice, creating regional and global climate patterns over time.\nIn recent decades, human activities such as burning fossil fuels and deforestation have accelerated climate change. Rising global temperatures, melting ice caps, and extreme weather events highlight the importance of understanding climate systems and taking action to reduce environmental impact.", "Climate describes the long-term patterns of temperature, precipitation, and weather conditions on Earth. It plays a major role in shaping ecosystems and human societies." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Oceans play a crucial role in controlling Earth’s temperature by absorbing heat and carbon dioxide from the atmosphere. They also drive weather patterns and support global food systems through fisheries and marine ecosystems.\nDespite their importance, oceans face serious threats such as pollution, overfishing, and climate change. Protecting marine environments through sustainable practices and conservation efforts is essential for preserving ocean health and maintaining Earth’s ecological balance.", "Oceans cover more than 70% of Earth’s surface and are vital to life on the planet. They regulate climate and support a vast range of marine life." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Earth’s continents were formed through tectonic plate movements over millions of years. These landmasses contain mountains, deserts, forests, and rivers that support diverse forms of life and natural resources essential to human civilization.\nContinents influence climate patterns by affecting ocean currents and atmospheric circulation. Understanding continental geography helps us better appreciate Earth’s natural processes and the interconnectedness between land, climate, and living organisms.", "Continents are large landmasses that shape Earth’s geography and influence climate, biodiversity, and human development. Each continent has unique landscapes and ecosystems." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Biodiversity refers to the variety of life on Earth. It includes different plants, animals, and microorganisms, as well as the ecosystems they form.", "Discover the incredible variety of life on Earth." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Climate is the long-term pattern of weather in a particular area. Earth's climate is influenced by the atmosphere, oceans, and land.", "Learn about Earth's climate systems and weather patterns." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Oceans are large bodies of salt water that cover most of Earth's surface. They regulate climate and support marine life.", "Explore the vast oceans covering 71% of Earth's surface." });

            migrationBuilder.UpdateData(
                table: "ExploreTopics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FullContent", "ShortDescription" },
                values: new object[] { "Continents are large land masses on Earth. There are seven continents: Asia, Africa, North America, South America, Antarctica, Europe, and Australia.", "Discover Earth's seven continents and their features." });
        }
    }
}
