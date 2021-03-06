﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_SAND = 11;
        public const int ITEM_ID_MONSTER_EYE = 12;
        public const int ITEM_ID_TRAINTICKET = 13;
        public const int ITEM_ID_LONG_SWORD = 14;
        public const int ITEM_ID_CLIMBING_SHOES = 15;
        public const int ITEM_ID_PEBLES = 16;
        public const int ITEM_ID_STONEKEY = 17;
        public const int ITEM_ID_WALLACE_SWORD = 18;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_DESERT_MONSTER = 4;
        public const int MONSTER_ID_GARGOYLE = 5;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_CLEAR_DESERT = 3;
        public const int QUEST_ID_CLEAR_MOUNTAIN = 4;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_RAILROAD = 10;
        public const int LOCATION_ID_DESERT = 11;
        public const int LOCATION_ID_DEEP_FOREST = 12;
        public const int LOCATION_ID_MOUNTAIN = 13;


        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }





        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION,"Healing potion", "Healing potions", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS,"Adventurer pass", "Adventurer passes"));
            Items.Add(new Item(ITEM_ID_SAND, "Sand", "More sand"));
            Items.Add(new Item(ITEM_ID_MONSTER_EYE, "Monster eye", "Monster eyes"));
            Items.Add(new Item(ITEM_ID_TRAINTICKET, "Trainticket", "Traintickets"));
            Items.Add(new Weapon(ITEM_ID_LONG_SWORD, "Longsword", "Longswords",5 , 15));
            Items.Add(new Item(ITEM_ID_CLIMBING_SHOES, "Climbingshoes", "Climbingshoes"));
            Items.Add(new Weapon(ITEM_ID_WALLACE_SWORD, "The Wallace Sword", "Wallace Swords", 100, 10000));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TRAINTICKET), 10, false));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster desertmonster = new Monster(MONSTER_ID_DESERT_MONSTER, "Desert monster", 15, 5, 50, 10, 10);
            desertmonster.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SAND), 80, true));
            desertmonster.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MONSTER_EYE), 20, false));

            Monster gargoyle = new Monster(MONSTER_ID_GARGOYLE, "Stone gargoyle", 20, 100, 150, 40, 40);
            gargoyle.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PEBLES), 70, true));
            gargoyle.LootTable.Add(new LootItem(ItemByID(ITEM_ID_STONEKEY), 10, false));


            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(desertmonster);
            Monsters.Add(gargoyle);
        }


        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails.You will receive a healing potion and 10 gold pieces.", 20, 10);
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD,"Clear the farmer's field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs.You will receive an adventurer's pass and a longsword.", 20, 0);
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest clearDesert = new Quest(QUEST_ID_CLEAR_DESERT, "Clear the desert for monsters", "kill desert monsters int the desert and collect 3 eyes. You will recieve a powerfull longsword", 50, 50);
            clearDesert.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_MONSTER_EYE), 3));
            clearDesert.RewardItem = ItemByID(ITEM_ID_CLIMBING_SHOES);

            Quest clearMountain = new Quest(QUEST_ID_CLEAR_MOUNTAIN, "Clear the mountain for gargoyles", "Kill the gargoyles to collect pebles, return with 20 pebles for a reward.", 200, 100);
            clearMountain.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_PEBLES), 20));
            clearMountain.RewardItem = ItemByID(ITEM_ID_WALLACE_SWORD);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearDesert);
        }





        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home",
                "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE,"Town square", "You see a fountain.");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT,
                "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD,"Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post",
                "There is a large, tough-looking guard here.",ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE,"Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD,"Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location railroad = new Location(LOCATION_ID_RAILROAD,"Railroad","There is a long railroad leading into the desert");

            Location desert = new Location(LOCATION_ID_DESERT, "Desert", "The only thing that is visible to the eye is just endless amount of sand",
                ItemByID(ITEM_ID_TRAINTICKET));
            desert.MonsterLivingHere = MonsterByID(MONSTER_ID_DESERT_MONSTER);

            Location deepforest = new Location(LOCATION_ID_DEEP_FOREST, "Deep forest", "It's a deep forest, but over the trees you see a big mountain.",
                null,QuestByID(QUEST_ID_CLEAR_MOUNTAIN));
           

            Location mountain = new Location(LOCATION_ID_MOUNTAIN, "Mountain", "It's really cold up here, and you see something moving in the snow.", ItemByID(ITEM_ID_CLIMBING_SHOES),
                null,MonsterByID(MONSTER_ID_GARGOYLE));


            // Link the locations together
            home.LocationToNorth = townSquare;
            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;
            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;
            farmersField.LocationToEast = farmhouse;
            farmersField.LocationToWest = railroad;
            railroad.LocationToEast = farmersField;
            railroad.LocationToWest = desert;
            desert.LocationToEast = railroad;
            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;
            alchemistsGarden.LocationToSouth = alchemistHut;
            alchemistsGarden.LocationToNorth = deepforest;
            deepforest.LocationToSouth = alchemistsGarden;
            deepforest.LocationToNorth = mountain;
            mountain.LocationToSouth = deepforest;
            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;
            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;
            spiderField.LocationToWest = bridge;


            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(railroad);
            Locations.Add(desert);
            Locations.Add(deepforest);
            Locations.Add(mountain);
        }



        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach
                (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }



}
}
