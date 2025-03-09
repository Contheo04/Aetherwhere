using System.Collections.Generic;

namespace Aetherwhere
{
    public static class AetherCurrentList
    {
        public static readonly List<AetherCurrentData> aetherCurrents = new()
        {
            // **Heavensward** (Field & Quest)
        new("Heavensward", "Coerthas Western Highlands", 30.6f, 33.7f, "Field", ""), // On the road north of Falcon's Nest
        new("Heavensward", "Coerthas Western Highlands", 31.5f, 11.8f, "Field", ""), // Atop a house; access via stairs at (31.1, 11.5)
        new("Heavensward", "Coerthas Western Highlands", 9.3f, 15.0f, "Field", ""),  // On the edge of a cliff
        new("Heavensward", "Coerthas Western Highlands", 15.8f, 22.3f, "Field", ""), // Overlooking The Convictory
        new("Heavensward", "Coerthas Western Highlands", 32.4f, 35.8f, "Sidequest", "Bridge Over Frozen Water", 67280), // "Bridge Over Frozen Water" quest
        new("Heavensward", "Coerthas Western Highlands", 16.9f, 22.8f, "Sidequest", "For AllB the Nights to Come",67647), // "For All the Nights to Come" quest
        new("Heavensward", "Coerthas Western Highlands", 16.7f, 22.8f, "Sidequest", "Baby Steps",67296), // "Baby Steps" quest
        new("Heavensward", "Coerthas Western Highlands", 16.5f, 22.5f, "Sidequest", "Protecting What's Important",67295), // "Protecting What's Important" quest
        new("Heavensward", "Coerthas Western Highlands", 16.4f, 22.4f, "MSQ", "Purple Flame, Purple Flame",67144), // "Purple Flame, Purple Flame" quest

        new("Heavensward", "The Dravanian Forelands", 37.8f, 28.3f, "Field", ""), // On top of the arched tree near the entrance
        new("Heavensward", "The Dravanian Forelands", 31.2f, 16.8f, "Field", ""), // In Whilom River, north of the fork
        new("Heavensward", "The Dravanian Forelands", 12.9f, 14.0f, "Field", ""), // Inside the cavern at Mourn
        new("Heavensward", "The Dravanian Forelands", 30.6f, 36.2f, "Field", ""), // Past the second door in Loth ast Gnath
        new("Heavensward", "The Dravanian Forelands", 31.9f, 23.9f, "Quest", "Some Bad News"), // "Some Bad News"
        new("Heavensward", "The Dravanian Forelands", 24.9f, 19.7f, "Quest", "Stolen Munitions"), // "Stolen Munitions"
        new("Heavensward", "The Dravanian Forelands", 16.4f, 23.0f, "Quest", "A Lesson in Humility"), // "A Lesson in Humility"
        new("Heavensward", "The Dravanian Forelands", 23.0f, 19.0f, "Quest", "Mourn in Passing"), // "Mourn in Passing"
        new("Heavensward", "The Dravanian Forelands", 31.9f, 23.9f, "Quest", "The Hunter Becomes the Kweh"),  // "The Hunter Becomes the Kweh"

        new("Heavensward", "The Dravanian Hinterlands", 37.1f, 25.5f, "Field", ""), // Entrance to area from main quest
        new("Heavensward", "The Dravanian Hinterlands", 24.5f, 19.0f, "Field", ""), // Across the bridge east of Bigwest Shortstop settlement
        new("Heavensward", "The Dravanian Hinterlands", 12.8f, 16.8f, "Field", ""), // Entrance to The Answering Quarter
        new("Heavensward", "The Dravanian Hinterlands", 13.5f, 36.1f, "Field", ""), // In the caverns by Matoya's Cave
        new("Heavensward", "The Dravanian Hinterlands", 21.0f, 18.0f, "Quest", "Louder than Words"), // "Louder than Words"
        new("Heavensward", "The Dravanian Hinterlands", 7.0f, 6.0f, "Quest", "Ebb and Aetherflow"),   // "Ebb and Aetherflow"
        new("Heavensward", "The Dravanian Hinterlands", 5.0f, 6.0f, "Quest", "Taking Stock"),   // "Taking Stock"
        new("Heavensward", "The Dravanian Hinterlands", 21.0f, 15.0f, "Quest", "Systematic Exploration"), // "Systematic Exploration"
        new("Heavensward", "The Dravanian Hinterlands", 6.0f, 10.0f, "Quest", "In Node We Trust"),   // "In Node We Trust"

        new("Heavensward", "The Churning Mists", 30.9f, 35.7f, "Field", ""), // On the clearing above Moghome (accessed via a ramp on the east side)
        new("Heavensward", "The Churning Mists", 20.6f, 27.0f, "Field", ""), // In the Asah settlement connecting the Landlord Colony and The Four Arms areas
        new("Heavensward", "The Churning Mists", 7.0f, 27.4f, "Field", ""),  // At the top of Zenith's palace
        new("Heavensward", "The Churning Mists", 29.3f, 19.9f, "Field", ""), // On the road heading toward the Monsterie
        new("Heavensward", "The Churning Mists", 29.0f, 36.0f, "Quest", ""), // "The Bathing Bully"
        new("Heavensward", "The Churning Mists", 33.0f, 15.0f, "Quest", "Waiting to Inhale"), // "Waiting to Inhale"
        new("Heavensward", "The Churning Mists", 27.5f, 33.8f, "Quest", "Road Kill"), // "Road Kill"
        new("Heavensward", "The Churning Mists", 12.3f, 29.5f, "Quest", "Hide Your Moogles"), // "Hide Your Moogles"
        new("Heavensward", "The Churning Mists", 13.3f, 11.0f, "Quest", "Into the Aery"), // "Into the Aery"

        new("Heavensward", "The Sea of Clouds", 7.6f, 25.8f, "Field", ""), // Immediately after disembarking the airship
        new("Heavensward", "The Sea of Clouds", 7.3f, 20.3f, "Field", ""), // Just outside Ok' Zundu
        new("Heavensward", "The Sea of Clouds", 18.9f, 11.6f, "Field", ""), // Next to Cid's airship
        new("Heavensward", "The Sea of Clouds", 11.2f, 15.2f, "Field", ""), // Up the stairs behind Vanu Chieftain Sonu Vanu
        new("Heavensward", "The Sea of Clouds", 17.0f, 37.0f, "Quest", "Clipped Wings"), // "Clipped Wings"
        new("Heavensward", "The Sea of Clouds", 11.5f, 10.9f, "Quest", "Honoring the Past"), // "Honoring the Past"
        new("Heavensward", "The Sea of Clouds", 9.6f, 14.2f, "Quest", "Sleepless in Ok' Zundu"), // "Sleepless in Ok' Zundu"
        new("Heavensward", "The Sea of Clouds", 10.6f, 14.8f, "Quest", "Flying the Nest"), // "Flying the Nest"
        new("Heavensward", "The Sea of Clouds", 10.8f, 13.6f, "Quest", "Bolt, Chain, and Island"), // "Bolt, Chain, and Island"

        new("Heavensward", "Azys Lla", 21.0f, 18.0f, "Quest", "Systematic Exploration"), // "Systematic Exploration"
        new("Heavensward", "Azys Lla", 7.0f, 6.0f, "Quest", "In Node We Trust"),   // "In Node We Trust"
        new("Heavensward", "Azys Lla", 5.0f, 6.0f, "Quest", "Chimerical Maintenance"),   // "Chimerical Maintenance"
        new("Heavensward", "Azys Lla", 21.0f, 15.0f, "Quest", "Close Encounters of the VIth Kind"), // "Close Encounters of the VIth Kind"
        new("Heavensward", "Azys Lla", 6.0f, 10.0f, "Quest", "Fetters of Lament"),   // "Fetters of Lament"

        // **Stormblood** (Field & Quest)        
        new("Stormblood", "The Fringes", 36.3f, 17.2f, "Field", "Near the edge of a cliff overlooking the river"), // Near the edge of a cliff overlooking the river
        new("Stormblood", "The Fringes", 27.9f, 21.6f, "Field", "Beside a large tree near the water"), // Beside a large tree near the water
        new("Stormblood", "The Fringes", 24.5f, 11.4f, "Field", "On a hill overlooking the area"), // On a hill overlooking the area
        new("Stormblood", "The Fringes", 11.7f, 16.4f, "Field", "Near the entrance to a cave"), // Near the entrance to a cave
        new("Stormblood", "The Fringes", 9.2f, 10.9f, "Quest", "Magiteknical Failure"),  // "Magiteknical Failure"
        new("Stormblood", "The Fringes", 9.2f, 10.9f, "Quest", "The Hidden Truth"),  // "The Hidden Truth"
        new("Stormblood", "The Fringes", 30.1f, 26.1f, "Quest", "Eyes Bigger Than Her Stomach"), // "Eyes Bigger Than Her Stomach"
        new("Stormblood", "The Fringes", 27.0f, 21.0f, "Quest", "Unexpected Guests"), // "Unexpected Guests"
        new("Stormblood", "The Fringes", 31.6f, 16.6f, "Quest", "The Silence of the Gods"), // "The Silence of the Gods"

        // The Ruby Sea (4 Field, 5 Quest)
        new ("Stormblood", "The Ruby Sea", 5.3f, 26.1f, "Field", "Swim to an underwater cave"),
        new ("Stormblood", "The Ruby Sea", 35.5f, 20.5f, "Field", "Near a shipwreck"),
        new ("Stormblood", "The Ruby Sea", 21.9f, 9.0f, "Field", "On the roof of a hut"),
        new ("Stormblood", "The Ruby Sea", 29.9f, 38.8f, "Field", "Atop a coral formation"),
        new ("Stormblood", "The Ruby Sea", 31.4f, 37.1f, "Quest", "The Price of Betrayal"),
        new ("Stormblood", "The Ruby Sea", 23.4f, 9.1f, "Quest", "Pulling Double Booty"),
        new ("Stormblood", "The Ruby Sea", 32.7f, 18.5f, "Quest", "The Sword in the Stone"),
        new ("Stormblood", "The Ruby Sea", 20.2f, 20.1f, "Quest", "The Palace of Lost Souls"),
        new ("Stormblood", "The Ruby Sea", 6.2f, 12.3f, "Quest", "Tide Goes In, Imperials Go Out"),
        
         // The Peaks (4 Field, 5 Quest)
        new("Stormblood", "The Peaks", 24.4f, 30.6f, "Field", ""), // On a cliff edge overlooking a lake
        new("Stormblood", "The Peaks", 11.7f, 26.4f, "Field", ""), // Near a waterfall
        new("Stormblood", "The Peaks", 16.0f, 15.8f, "Field", ""), // Beside a large rock formation
        new("Stormblood", "The Peaks", 25.5f, 6.4f, "Field", ""),  // On a plateau
        new("Stormblood", "The Peaks", 24.3f, 6.8f, "Quest", "Saint Sayer"),  // "Saint Sayer"
        new("Stormblood", "The Peaks", 27.7f, 28.7f, "Quest", "A Hunger for Trade"), // "A Hunger for Trade"
        new("Stormblood", "The Peaks", 14.9f, 36.6f, "Quest", "Out of Sight"), // "Out of Sight"
        new("Stormblood", "The Peaks", 27.1f, 36.5f, "Quest", "Closing Up Shop"), // "Closing Up Shop"
        new("Stormblood", "The Peaks", 26.7f, 36.2f, "Quest", "Liberty or Death"), // "Liberty or Death"

        // Yanxia (4 Field, 5 Quest)
        new("Stormblood", "Yanxia", 30.0f, 19.8f, "Field", ""), // Near the riverbank
        new("Stormblood", "Yanxia", 31.4f, 29.5f, "Field", ""), // By the Dairyu Moon Gates
        new("Stormblood", "Yanxia", 30.6f, 37.8f, "Field", ""), // On a hill overlooking the bridge
        new("Stormblood", "Yanxia", 19.4f, 32.7f, "Field", ""), // Near Doma Castle
        new("Stormblood", "Yanxia", 30.4f, 17.6f, "Quest", "Fly My Pretties"), // "Fly My Pretties"
        new("Stormblood", "Yanxia", 20.7f, 15.6f, "Quest", "Something Smells"), // "Something Smells"
        new("Stormblood", "Yanxia", 30.1f, 18.9f, "Quest", "Wolves and Weeds"), // "Wolves and Weeds"
        new("Stormblood", "Yanxia", 30.7f, 18.0f, "Quest", "Whacking Day"), // "Whacking Day"
        new("Stormblood", "Yanxia", 31.2f, 28.9f, "Quest", "All the Little Angels"), // "All the Little Angels"

        // The Lochs (4 Field, 5 Quest)
        new("Stormblood", "The Lochs", 12.6f, 22.3f, "Field", ""), // Near the entrance to a cave
        new("Stormblood", "The Lochs", 36.1f, 26.4f, "Field", ""), // On a cliff overlooking the lake
        new("Stormblood", "The Lochs", 22.4f, 34.0f, "Field", ""), // Beside a large tree
        new("Stormblood", "The Lochs", 14.8f, 35.5f, "Field", ""), // Near the ruins
        new("Stormblood", "The Lochs", 32.6f, 23.4f, "Quest", "The Lies We Tell"), // "The Lies We Tell"
        new("Stormblood", "The Lochs", 21.2f, 36.2f, "Quest", "A Rite to Rest"), // "A Rite to Rest"
        new("Stormblood", "The Lochs", 27.5f, 16.8f, "Quest", "The Reluctant Researcher"), // "The Reluctant Researcher"
        new("Stormblood", "The Lochs", 35.0f, 21.0f, "Quest", "The Price of Freedom"), // "The Price of Freedom"
        new("Stormblood", "The Lochs", 19.0f, 31.0f, "Quest", "The Will to Live"),  // "The Will to Live"

        // The Azim Steppe (4 Field, 5 Quest)
        new("Stormblood", "The Azim Steppe", 33.9f, 30.6f, "Field", ""), // Overlooking a serene lake
        new("Stormblood", "The Azim Steppe", 26.2f, 12.0f, "Field", ""), // Amidst the whispering grasses
        new("Stormblood", "The Azim Steppe", 23.5f, 20.5f, "Field", ""), // At the edge of a nomad's camp
        new("Stormblood", "The Azim Steppe", 8.7f, 35.5f, "Field", ""),  // Beneath the shadow of a towering rock formation
        new("Stormblood", "The Azim Steppe", 32.9f, 28.3f, "Quest", "Words Are Very Unnecessary"), // "Words Are Very Unnecessary"
        new("Stormblood", "The Azim Steppe", 28.1f, 15.1f, "Quest", "Sheep Snatcher"), // "Sheep Snatcher"
        new("Stormblood", "The Azim Steppe", 23.0f, 23.3f, "Quest", "Forty Years and Counting"), // "Forty Years and Counting"
        new("Stormblood", "The Azim Steppe", 12.7f, 34.4f, "Quest", "Mauci of the Seven Worries"), // "Mauci of the Seven Worries"
        new("Stormblood", "The Azim Steppe", 16.8f, 22.9f, "Quest", "The Children of Azim"), // "The Children of Azim"

        // **Shadowbringers**
        // Lakeland (4 Field, 5 Quest)
        new("Shadowbringers", "Lakeland", 9.0f, 17.5f, "Field", ""), // On the castle wall, northwest and below from the Amarokeep
        new("Shadowbringers", "Lakeland", 18.4f, 19.4f, "Field", ""), // On the second floor of the tower structure
        new("Shadowbringers", "Lakeland", 33.7f, 16.8f, "Field", ""), // On a small rocky ledge, a bit east of the road fork
        new("Shadowbringers", "Lakeland", 32.5f, 28.5f, "Field", ""), // Atop a flight of stairs at The Accensor Gate
        new("Shadowbringers", "Lakeland", 7.4f, 14.4f, "Quest", "An Unreasonable Request"),  // "An Unreasonable Request"
        new("Shadowbringers", "Lakeland", 8.0f, 17.0f, "Quest", "The Astute Amaro"),  // "The Astute Amaro"
        new("Shadowbringers", "Lakeland", 6.1f, 15.4f, "Quest", "Imperative Repairs"),  // "Imperative Repairs"
        new("Shadowbringers", "Lakeland", 12.0f, 16.4f, "Quest", "A Jobb Well Done"), // "A Jobb Well Done"
        new("Shadowbringers", "Lakeland", 8.5f, 9.7f, "Quest", "Logistics of War"),   // "Logistics of War"

        // Amh Araeng (4 Field, 5 Quest)
        new("Shadowbringers", "Amh Araeng", 24.6f, 34.9f, "Field", ""), // On the round platform in the center of The Pristine Palace of Amh Malik
        new("Shadowbringers", "Amh Araeng", 14.6f, 16.7f, "Field", ""), // On the railroad track, east of Twine
        new("Shadowbringers", "Amh Araeng", 28.3f, 32.2f, "Field", ""), // The Derrick, directly south from The Inn at Journey's Head
        new("Shadowbringers", "Amh Araeng", 30.3f, 10.4f, "Field", ""), // North of bridge when entering from The Crystarium
        new("Shadowbringers", "Amh Araeng", 11.3f, 17.5f, "Quest", "A Vein Pursuit"), // "A Vein Pursuit"
        new("Shadowbringers", "Amh Araeng", 11.8f, 17.4f, "Quest", "Charmless Man"), // "Charmless Man"
        new("Shadowbringers", "Amh Araeng", 12.9f, 16.9f, "Quest", "Scavengers Assemble"), // "Scavengers Assemble"
        new("Shadowbringers", "Amh Araeng", 26.8f, 18.5f, "Quest", "Work to Live or Live to Work"), // "Work to Live or Live to Work"
        new("Shadowbringers", "Amh Araeng", 15.8f, 29.1f, "Quest", "A Fresh Start"), // "A Fresh Start"

        // Il Mheg (4 Field, 5 Quest)
        new("Shadowbringers", "Il Mheg", 21.2f, 16.5f, "Field", ""), // Platform on the stairs towards Lyhe Ghiah
        new("Shadowbringers", "Il Mheg", 30.1f, 6.0f, "Field", ""),  // Just northeast of the Wolekdorf Aetheryte
        new("Shadowbringers", "Il Mheg", 21.8f, 4.4f, "Field", ""),  // Up a staircase of mushrooms in Pla Enni
        new("Shadowbringers", "Il Mheg", 16.8f, 24.6f, "Field", ""), // The roof of a sunken house
        new("Shadowbringers", "Il Mheg", 30.3f, 8.3f, "Quest", "A New Amaro"),  // "A New Amaro"
        new("Shadowbringers", "Il Mheg", 15.7f, 30.4f, "Quest", "The Path to Popularity"), // "The Path to Popularity"
        new("Shadowbringers", "Il Mheg", 9.2f, 17.1f, "Quest", "Delightful Decorations"),  // "Delightful Decorations"
        new("Shadowbringers", "Il Mheg", 14.1f, 32.6f, "Quest", "The Forbidden Lran"), // "The Forbidden Lran"
        new("Shadowbringers", "Il Mheg", 30.4f, 7.5f, "Quest", "Acht-la Ormh Inn"),   // "Acht-la Ormh Inn"

        // Kholusia (4 Field, 5 Quest)
        new("Shadowbringers", "Kholusia", 20.3f, 21.1f, "Field", "Perched atop a coastal cliff"), // Perched atop a coastal cliff
        new("Shadowbringers", "Kholusia", 34.7f, 9.8f, "Field", "Hidden within the ruins of a dilapidated factory"),  // Hidden within the ruins of a dilapidated factory
        new("Shadowbringers", "Kholusia", 7.4f, 34.2f, "Field", "Along the shores, whispered by the sea's eternal song"),  // Along the shores, whispered by the sea's eternal song
        new("Shadowbringers", "Kholusia", 34.4f, 32.6f, "Field", "Nestled in the shadow of Wright's monument"), // Nestled in the shadow of Wright's monument
        new("Shadowbringers", "Kholusia", 12.3f, 9.1f, "Quest", "A Disagreeable Dwarf"),  // "A Disagreeable Dwarf"
        new("Shadowbringers", "Kholusia", 18.8f, 17.8f, "Quest", "Fugitive of Fear"), // "Fugitive of Fear"
        new("Shadowbringers", "Kholusia", 15.3f, 28.7f, "Quest", "Village of Woe"), // "Village of Woe"
        new("Shadowbringers", "Kholusia", 15.3f, 29.6f, "Quest", "A Plankless Task"), // "A Plankless Task"
        new("Shadowbringers", "Kholusia", 34.7f, 18.2f, "Quest", "A Disagreeable Dwarf"), // "A Disagreeable Dwarf"

        // The Rak'tika Greatwood (4 Field, 5 Quest)
        new("Shadowbringers", "The Rak'tika Greatwood", 35.1f, 16.2f, "Field", ""), // -
        new("Shadowbringers", "The Rak'tika Greatwood", 28.2f, 25.5f, "Field", "On a ledge hanging over the path between Fanow and Slitherbough"), // On a ledge hanging over the path between Fanow and Slitherbough
        new("Shadowbringers", "The Rak'tika Greatwood", 18.6f, 22.4f, "Field", ""), // -
        new("Shadowbringers", "The Rak'tika Greatwood", 13.3f, 31.6f, "Field", "At the ruins of Fort Gohn"), // At the ruins of Fort Gohn
        new("Shadowbringers", "The Rak'tika Greatwood", 31.3f, 16.9f, "Quest", "Stand on Ceremony"), // "Stand on Ceremony"
        new("Shadowbringers", "The Rak'tika Greatwood", 29.4f, 17.8f, "Quest", "Suit Up"), // "Suit Up"
        new("Shadowbringers", "The Rak'tika Greatwood", 19.8f, 27.6f, "Quest", "The Great Deceiver"), // "The Great Deceiver"
        new("Shadowbringers", "The Rak'tika Greatwood", 18.8f, 27.7f, "Quest", "What We Do For Family"), // "What We Do For Family"
        new("Shadowbringers", "The Rak'tika Greatwood", 30.5f, 17.4f, "Quest", "The Burden of Knowledge"), // "The Burden of Knowledge"

        // The Tempest (4 Field, 5 Quest)
        new("Shadowbringers", "The Tempest", 10.4f, 15.0f, "Field", "Near the entrance to an underwater cave"), // Near the entrance to an underwater cave
        new("Shadowbringers", "The Tempest", 26.5f, 16.5f, "Field", "On a cliff overlooking the abyss"), // On a cliff overlooking the abyss
        new("Shadowbringers", "The Tempest", 34.2f, 30.0f, "Field", "Beside a large coral formation"), // Beside a large coral formation
        new("Shadowbringers", "The Tempest", 21.0f, 7.0f, "Field", "Near the ruins of a sunken ship"),  // Near the ruins of a sunken ship
        new("Shadowbringers", "The Tempest", 33.3f, 18.0f, "Quest", "A Greater Purpose"), // "A Greater Purpose"
        new("Shadowbringers", "The Tempest", 26.8f, 16.4f, "Quest", "The Heart's Desire"), // "The Heart's Desire"
        new("Shadowbringers", "The Tempest", 22.1f, 11.0f, "Quest", "A Relic of a Journey Past"), // "A Relic of a Journey Past"
        new("Shadowbringers", "The Tempest", 15.6f, 28.9f, "Quest", "The Best Way Out"), // "The Best Way Out"
        new("Shadowbringers", "The Tempest", 38.5f, 15.5f, "Quest", "A Secret Unveiled"),  // "A Secret Unveiled"

        // **Endwalker**
        // Labyrinthos (4 Field, 5 Quest)
        new("Endwalker", "Labyrinthos", 18.9f, 35.0f, "Field", "On some grass-covered rock, west of Kokkol's Forge"), // On some grass-covered rock, west of Kokkol's Forge
        new("Endwalker", "Labyrinthos", 10.5f, 34.7f, "Field", "On a ledge overlooking a tower, northwest of Logistikon Gamma"), // On a ledge overlooking a tower, northwest of Logistikon Gamma
        new("Endwalker", "Labyrinthos", 36.4f, 22.8f, "Field", "In a mineshaft; take the first tunnel on the left; it's on the ledge at The Thirty-third Facet"), // In a mineshaft; take the first tunnel on the left; it's on the ledge at The Thirty-third Facet
        new("Endwalker", "Labyrinthos", 28.4f, 6.1f, "Field", "Atop the cliff next to the tower Mistloom"),  // Atop the cliff next to the tower Mistloom
        new("Endwalker", "Labyrinthos", 30.3f, 19.3f, "Quest", "Lost Little Troll"), // "Lost Little Troll"
        new("Endwalker", "Labyrinthos", 21.0f, 21.5f, "Quest", "Let the Good Times Troll"), // "Let the Good Times Troll"
        new("Endwalker", "Labyrinthos", 27.8f, 17.9f, "Quest", "A Fisherman's Friend"), // "A Fisherman's Friend"
        new("Endwalker", "Labyrinthos", 19.6f, 22.4f, "Quest", "A Test of Courage"), // "A Test of Courage"
        new("Endwalker", "Labyrinthos", 23.4f, 26.7f, "Quest", "The Sins We Bear"), // "The Sins We Bear"

        // Thavnair (4 Field, 5 Quest)
        new("Endwalker", "Thavnair", 17.9f, 32.2f, "Field", "On a ledge next to a large rock, southwest of Akyaali"), // On a ledge next to a large rock, southwest of Akyaali
        new("Endwalker", "Thavnair", 20.4f, 7.2f, "Field", "On a quarried ledge accessed from the left (Giantsgall Grounds)"),  // On a quarried ledge accessed from the left (Giantsgall Grounds)
        new("Endwalker", "Thavnair", 23.8f, 14.6f, "Field", "In water at Pavana's Remorse, after the quest 'Beyond the Depths of Despair'"), // In water at Pavana's Remorse, after the quest "Beyond the Depths of Despair"
        new("Endwalker", "Thavnair", 32.4f, 18.2f, "Field", "Southeast of Palaka's Stand on some rocks, after the quest 'Beyond the Depths of Despair'"), // Southeast of Palaka's Stand on some rocks, after the quest "Beyond the Depths of Despair"
        new("Endwalker", "Thavnair", 25.5f, 35.6f, "Quest", "Steppe Child"), // "Steppe Child"
        new("Endwalker", "Thavnair", 11.0f, 21.0f, "Quest", "Alchemist or Dancer"), // "Alchemist or Dancer"
        new("Endwalker", "Thavnair", 29.1f, 17.3f, "Quest", "Radiant Patrol"), // "Radiant Patrol"
        new("Endwalker", "Thavnair", 24.3f, 19.8f, "Quest", "A Budding Adventure"), // "A Budding Adventure"
        new("Endwalker", "Thavnair", 30.5f, 23.7f, "Quest", "The Fruits of Our Labor"), // "The Fruits of Our Labor"

        // Garlemald (4 Field, 5 Quest)
        new("Endwalker", "Garlemald", 17.7f, 29.9f, "Field", "On top of a rock outcropping east of Camp Broken Glass"), // On top of a rock outcropping east of Camp Broken Glass
        new("Endwalker", "Garlemald", 25.3f, 34.3f, "Field", "In the ravine next to the east of the Tapper's Den"), // In the ravine next to the east of the Tapper's Den
        new("Endwalker", "Garlemald", 9.4f, 14.9f, "Field", "Behind a tree west of Forum Patens"),  // Behind a tree west of Forum Patens
        new("Endwalker", "Garlemald", 29.1f, 11.8f, "Field", "Up the ramp to a pedestrian sitting area, southwest of Forum Solius"), // Up the ramp to a pedestrian sitting area, southwest of Forum Solius
        new("Endwalker", "Garlemald", 12.6f, 20.3f, "Quest", "No Good Deed"), // "No Good Deed"
        new("Endwalker", "Garlemald", 22.8f, 15.7f, "Quest", "The Last Bastion"), // "The Last Bastion"
        new("Endwalker", "Garlemald", 30.9f, 16.1f, "Quest", "The Fortunes of War"), // "The Fortunes of War"
        new("Endwalker", "Garlemald", 35.4f, 19.8f, "Quest", "The Wind Rises"), // "The Wind Rises"
        new("Endwalker", "Garlemald", 19.5f, 23.6f, "Quest", "The Road to Recovery"), // "The Road to Recovery"

        // Mare Lamentorum (4 Field, 5 Quest)
        new("Endwalker", "Mare Lamentorum", 22.0f, 10.4f, "Field", "Near the entrance to an underground cave"), // Near the entrance to an underground cave
        new("Endwalker", "Mare Lamentorum", 27.8f, 9.5f, "Field", "On a cliff overlooking a crater"),  // On a cliff overlooking a crater
        new("Endwalker", "Mare Lamentorum", 34.5f, 13.3f, "Field", "Beside a large rock formation"), // Beside a large rock formation
        new("Endwalker", "Mare Lamentorum", 11.8f, 34.3f, "Field", "Near the edge of a cliff"), // Near the edge of a cliff
        new("Endwalker", "Mare Lamentorum", 22.1f, 10.9f, "Quest", "A Moonlight Reprieve"), // "A Moonlight Reprieve"
        new("Endwalker", "Mare Lamentorum", 18.7f, 30.5f, "Quest", "The Celestial Expanse"), // "The Celestial Expanse"
        new("Endwalker", "Mare Lamentorum", 24.5f, 34.8f, "Quest", "The Stigma of the Sea"), // "The Stigma of the Sea"
        new("Endwalker", "Mare Lamentorum", 28.1f, 34.0f, "Quest", "Lunar Love"), // "Lunar Love"
        new("Endwalker", "Mare Lamentorum", 34.7f, 11.6f, "Quest", "The Light of Inspiration"), // "The Light of Inspiration"

        // Elpis (4 Field, 5 Quest)
        new("Endwalker", "Elpis", 13.9f, 15.4f, "Field", "On a floating island"), // On a floating island
        new("Endwalker", "Elpis", 31.5f, 15.1f, "Field", "Near a waterfall"), // Near a waterfall
        new("Endwalker", "Elpis", 17.9f, 7.2f, "Field", "Beside a large tree"),  // Beside a large tree
        new("Endwalker", "Elpis", 12.1f, 32.4f, "Field", "On a cliff edge"), // On a cliff edge
        new("Endwalker", "Elpis", 32.5f, 23.7f, "Quest", "An Expected Guest"), // "An Expected Guest"
        new("Endwalker", "Elpis", 24.3f, 19.8f, "Quest", "A Flower upon Your Return"), // "A Flower upon Your Return"
        new("Endwalker", "Elpis", 30.5f, 23.7f, "Quest", "The Color of Joy"), // "The Color of Joy"
        new("Endwalker", "Elpis", 28.1f, 34.0f, "Quest", "A Past, Not Yet Come to Pass"), // "A Past, Not Yet Come to Pass"
        new("Endwalker", "Elpis", 34.7f, 11.6f, "Quest", "The Future Is Not Yet Written"), // "The Future Is Not Yet Written"

        // Ultima Thule (4 Field, 5 Quest)
        new("Endwalker", "Ultima Thule", 16.6f, 15.5f, "Field", "On top of the stone spiral tower"), // On top of the stone spiral tower
        new("Endwalker", "Ultima Thule", 14.8f, 14.2f, "Field", "Near remnants of ancient civilizations"), // Near remnants of ancient civilizations
        new("Endwalker", "Ultima Thule", 13.7f, 8.8f, "Field", "Close to the Omicron tribal quests area"),  // Close to the Omicron tribal quests area
        new("Endwalker", "Ultima Thule", 21.7f, 6.3f, "Field", "Amidst the whispers of the dead sun"),  // Amidst the whispers of the dead sun
        new("Endwalker", "Ultima Thule", 22.4f, 11.0f, "Quest", "Ending as One"), // "Ending as One"
        new("Endwalker", "Ultima Thule", 23.5f, 12.3f, "Quest", "A Most Stimulating Discussion"), // "A Most Stimulating Discussion"
        new("Endwalker", "Ultima Thule", 30.8f, 27.8f, "Quest", "Combat Evolved"), // "Combat Evolved"
        new("Endwalker", "Ultima Thule", 31.6f, 27.6f, "Quest", "Learn to Love"), // "Learn to Love"
        new("Endwalker", "Ultima Thule", 25.9f, 27.7f, "Quest", "You're Not Alone")  // "You're Not Alone"
        };
    }
}
