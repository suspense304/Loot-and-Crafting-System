using Crafting_System.Gear;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Crafting_System
{
    public partial class Form1 : Form
    {
        ItemCreationService itemCreationService = new ItemCreationService();
        GearService gearService = new GearService();
        Random random = new Random();

        int normalItems = 0;
        int magicItems = 0;
        int rareItems = 0;
        int epicItems = 0;
        int legendaryItems = 0;
        int superItems = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblItem1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Create_Inventory_Click(object sender, EventArgs e)
        {
            lstInventory.Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                bool weaponDrop = random.Next(0, 100) < 11;
                if (weaponDrop)
                {
                    EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(
                                        Convert.ToInt16(txtLevel.Text), gearService.GetRandomGearSlot(random));
                    switch (equipmentItem.Rarity)
                    {
                        case Rarity.Normal: normalItems++; break;
                        case Rarity.Magic: magicItems++; break;
                        case Rarity.Rare: rareItems++; break;
                        case Rarity.Epic: epicItems++; break;
                        case Rarity.Legendary: legendaryItems++; break;
                        case Rarity.Super: superItems++; break;
                    }
                }
            }

            lstInventory.Items.Add($"Normal: {normalItems}");
            lstInventory.Items.Add($"Magic: {magicItems}");
            lstInventory.Items.Add($"Rare: {rareItems}");
            lstInventory.Items.Add($"Epic: {epicItems}");
            lstInventory.Items.Add($"Legendary: {legendaryItems}");
            lstInventory.Items.Add($"Super: {superItems}");
        }

        private void AddItemToList(EquipmentItem equipmentItem)
        {
            switch (equipmentItem.Rarity)
            {
                case Rarity.Normal: normalItems++; break;
                case Rarity.Magic: magicItems++; break;
                case Rarity.Rare: rareItems++; break;
                case Rarity.Epic: epicItems++; break;
                case Rarity.Legendary: legendaryItems++; break;
                case Rarity.Super: superItems++; break;
            }
        }

        private void btnCreate_Item_1_Click(object sender, EventArgs e)
        {
            EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), gearService.GetRandomGearSlot(random));
            AddItemToList(equipmentItem);

            lblItem1.Text = equipmentItem.Name;
            lblItem1_Level.Text = "LEVEL: " + equipmentItem.RequiredLevel.ToString();

            if (equipmentItem.Armor != null) lblItem1_Armor_Damage.Text = "Armor: " + equipmentItem.Armor.ToString();
            if (equipmentItem.AttackDamage != null) lblItem1_Armor_Damage.Text = "Damage: " + equipmentItem.AttackDamage.ToString();

            if (equipmentItem.BaseAffixes != null)
            {
                if (equipmentItem.BaseAffixes.Count == 1)
                {
                    lblItem1_baseAffix_1.Text = $"{equipmentItem.BaseAffixes[0].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[0].Values.Value} ( {equipmentItem.BaseAffixes[0].Values.MinValue} - {equipmentItem.BaseAffixes[0].Values.MaxValue} )";
                    lblItem1_baseAffix_2.Text = "";
                }

                if (equipmentItem.BaseAffixes.Count == 2)
                {
                    lblItem1_baseAffix_1.Text = $"{equipmentItem.BaseAffixes[0].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[0].Values.Value} ( {equipmentItem.BaseAffixes[0].Values.MinValue} - {equipmentItem.BaseAffixes[0].Values.MaxValue} )";
                    lblItem1_baseAffix_2.Text = $"{equipmentItem.BaseAffixes[1].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[1].Values.Value} ( {equipmentItem.BaseAffixes[1].Values.MinValue} - {equipmentItem.BaseAffixes[1].Values.MaxValue} )";
                }
            }
            else
            {
                lblItem1_baseAffix_1.Text = "";
                lblItem1_baseAffix_2.Text = "";

            }

            switch (equipmentItem.Prefixes.Count)
            {
                case 0:
                    lblItem1_prefix_1.Text = "";
                    lblItem1_prefix_2.Text = "";
                    lblItem1_prefix_3.Text = "";
                    break;
                case 1:
                    lblItem1_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem1_prefix_2.Text = "";
                    lblItem1_prefix_3.Text = "";
                    break;
                case 2:
                    lblItem1_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem1_prefix_2.Text = $"{equipmentItem.Prefixes[1].Affix.GetDisplayName()} - {equipmentItem.Prefixes[1].Values.Value} ( {equipmentItem.Prefixes[1].Values.MinValue} - {equipmentItem.Prefixes[1].Values.MaxValue} )";
                    lblItem1_prefix_3.Text = "";
                    break;
                case 3:
                    lblItem1_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem1_prefix_2.Text = $"{equipmentItem.Prefixes[1].Affix.GetDisplayName()} - {equipmentItem.Prefixes[1].Values.Value} ( {equipmentItem.Prefixes[1].Values.MinValue} - {equipmentItem.Prefixes[1].Values.MaxValue} )";
                    lblItem1_prefix_3.Text = $"{equipmentItem.Prefixes[2].Affix.GetDisplayName()} - {equipmentItem.Prefixes[2].Values.Value} ( {equipmentItem.Prefixes[2].Values.MinValue} - {equipmentItem.Prefixes[2].Values.MaxValue} )";
                    break;
            }
            switch (equipmentItem.Suffixes.Count)
            {
                case 0:
                    lblItem1_suffix_1.Text = "";
                    lblItem1_suffix_2.Text = "";
                    lblItem1_suffix_3.Text = "";
                    break;
                case 1:
                    lblItem1_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem1_suffix_2.Text = "";
                    lblItem1_suffix_3.Text = "";
                    break;
                case 2:
                    lblItem1_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem1_suffix_2.Text = $"{equipmentItem.Suffixes[1].Affix.GetDisplayName()} - {equipmentItem.Suffixes[1].Values.Value} ( {equipmentItem.Suffixes[1].Values.MinValue} - {equipmentItem.Suffixes[1].Values.MaxValue} )";
                    lblItem1_suffix_3.Text = "";
                    break;
                case 3:
                    lblItem1_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem1_suffix_2.Text = $"{equipmentItem.Suffixes[1].Affix.GetDisplayName()} - {equipmentItem.Suffixes[1].Values.Value} ( {equipmentItem.Suffixes[1].Values.MinValue} - {equipmentItem.Suffixes[1].Values.MaxValue} )";
                    lblItem1_suffix_3.Text = $"{equipmentItem.Suffixes[2].Affix.GetDisplayName()} - {equipmentItem.Suffixes[2].Values.Value} ( {equipmentItem.Suffixes[2].Values.MinValue} - {equipmentItem.Suffixes[2].Values.MaxValue} )";
                    break;
            }
        }
        private void btnCreate_Item_2_Click(object sender, EventArgs e)
        {
            EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), gearService.GetRandomGearSlot(random));

            lblItem2.Text = equipmentItem.Name;
            lblItem2_Level.Text = "LEVEL: " + equipmentItem.RequiredLevel.ToString();


            if (equipmentItem.Armor != null) lblItem2_Armor_Damage.Text = "Armor: " + equipmentItem.Armor.ToString();
            if (equipmentItem.AttackDamage != null) lblItem2_Armor_Damage.Text = "Damage: " + equipmentItem.AttackDamage.ToString();

            if (equipmentItem.BaseAffixes != null)
            {
                if (equipmentItem.BaseAffixes.Count == 1)
                {
                    lblItem2_baseAffix_1.Text = $"{equipmentItem.BaseAffixes[0].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[0].Values.Value} ( {equipmentItem.BaseAffixes[0].Values.MinValue} - {equipmentItem.BaseAffixes[0].Values.MaxValue} )";
                    lblItem2_baseAffix_2.Text = "";
                }

                if (equipmentItem.BaseAffixes.Count == 2)
                {
                    lblItem2_baseAffix_1.Text = $"{equipmentItem.BaseAffixes[0].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[0].Values.Value} ( {equipmentItem.BaseAffixes[0].Values.MinValue} - {equipmentItem.BaseAffixes[0].Values.MaxValue} )";
                    lblItem2_baseAffix_2.Text = $"{equipmentItem.BaseAffixes[1].Affix.GetDisplayName()} - {equipmentItem.BaseAffixes[1].Values.Value} ( {equipmentItem.BaseAffixes[1].Values.MinValue} - {equipmentItem.BaseAffixes[1].Values.MaxValue} )";
                }
            }
            else
            {
                lblItem2_baseAffix_1.Text = "";
                lblItem2_baseAffix_2.Text = "";

            }

            switch (equipmentItem.Prefixes.Count)
            {
                case 0:
                    lblItem2_prefix_1.Text = "";
                    lblItem2_prefix_2.Text = "";
                    lblItem2_prefix_3.Text = "";
                    break;
                case 1:
                    lblItem2_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem2_prefix_2.Text = "";
                    lblItem2_prefix_3.Text = "";
                    break;
                case 2:
                    lblItem2_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem2_prefix_2.Text = $"{equipmentItem.Prefixes[1].Affix.GetDisplayName()} - {equipmentItem.Prefixes[1].Values.Value} ( {equipmentItem.Prefixes[1].Values.MinValue} - {equipmentItem.Prefixes[1].Values.MaxValue} )";
                    lblItem2_prefix_3.Text = "";
                    break;
                case 3:
                    lblItem2_prefix_1.Text = $"{equipmentItem.Prefixes[0].Affix.GetDisplayName()} - {equipmentItem.Prefixes[0].Values.Value} ( {equipmentItem.Prefixes[0].Values.MinValue} - {equipmentItem.Prefixes[0].Values.MaxValue} )";
                    lblItem2_prefix_2.Text = $"{equipmentItem.Prefixes[1].Affix.GetDisplayName()} - {equipmentItem.Prefixes[1].Values.Value} ( {equipmentItem.Prefixes[1].Values.MinValue} - {equipmentItem.Prefixes[1].Values.MaxValue} )";
                    lblItem2_prefix_3.Text = $"{equipmentItem.Prefixes[2].Affix.GetDisplayName()} - {equipmentItem.Prefixes[2].Values.Value} ( {equipmentItem.Prefixes[2].Values.MinValue} - {equipmentItem.Prefixes[2].Values.MaxValue} )";
                    break;
            }
            switch (equipmentItem.Suffixes.Count)
            {
                case 0:
                    lblItem2_suffix_1.Text = "";
                    lblItem2_suffix_2.Text = "";
                    lblItem2_suffix_3.Text = "";
                    break;
                case 1:
                    lblItem2_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem2_suffix_2.Text = "";
                    lblItem2_suffix_3.Text = "";
                    break;
                case 2:
                    lblItem2_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem2_suffix_2.Text = $"{equipmentItem.Suffixes[1].Affix.GetDisplayName()} - {equipmentItem.Suffixes[1].Values.Value} ( {equipmentItem.Suffixes[1].Values.MinValue} - {equipmentItem.Suffixes[1].Values.MaxValue} )";
                    lblItem2_suffix_3.Text = "";
                    break;
                case 3:
                    lblItem2_suffix_1.Text = $"{equipmentItem.Suffixes[0].Affix.GetDisplayName()} - {equipmentItem.Suffixes[0].Values.Value} ( {equipmentItem.Suffixes[0].Values.MinValue} - {equipmentItem.Suffixes[0].Values.MaxValue} )";
                    lblItem2_suffix_2.Text = $"{equipmentItem.Suffixes[1].Affix.GetDisplayName()} - {equipmentItem.Suffixes[1].Values.Value} ( {equipmentItem.Suffixes[1].Values.MinValue} - {equipmentItem.Suffixes[1].Values.MaxValue} )";
                    lblItem2_suffix_3.Text = $"{equipmentItem.Suffixes[2].Affix.GetDisplayName()} - {equipmentItem.Suffixes[2].Values.Value} ( {equipmentItem.Suffixes[2].Values.MinValue} - {equipmentItem.Suffixes[2].Values.MaxValue} )";
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstInventory.Items.Clear();
            normalItems = 0;
            magicItems = 0;
            rareItems = 0;
            epicItems = 0;
            legendaryItems = 0;
            superItems = 0;
        }
    }
}