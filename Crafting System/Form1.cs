using Crafting_System.Gear;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
            foreach (var item in ItemCreationService.BaseItems)
            {
                lstInventory.Items.Add(item.Name);
            }

            lblInventoryCount.Text = lstInventory.Items.Count.ToString();
            //for (int i = 0; i < 10000; i++)
            //{
            //    bool weaponDrop = random.Next(0, 100) < 11;
            //    if (weaponDrop)
            //    {
            //        EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(
            //                            Convert.ToInt16(txtLevel.Text), gearService.GetRandomGearSlot(random));
            //        if (equipmentItem == null) continue;
            //        switch (equipmentItem.Rarity)
            //        {
            //            case Rarity.Normal: normalItems++; break;
            //            case Rarity.Magic: magicItems++; break;
            //            case Rarity.Rare: rareItems++; break;
            //            case Rarity.Epic: epicItems++; break;
            //            case Rarity.Legendary: legendaryItems++; break;
            //            case Rarity.Super: superItems++; break;
            //        }
            //    }
            //}

            //lstInventory.Items.Add($"Normal: {normalItems}");
            //lstInventory.Items.Add($"Magic: {magicItems}");
            //lstInventory.Items.Add($"Rare: {rareItems}");
            //lstInventory.Items.Add($"Epic: {epicItems}");
            //lstInventory.Items.Add($"Legendary: {legendaryItems}");
            //lstInventory.Items.Add($"Super: {superItems}");
        }
        private void btnCreate_Item_1_Click(object sender, EventArgs e)
        {
            EquipmentItem equipmentItem = new EquipmentItem();
            equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), gearService.GetRandomGearSlot(random));

            if (equipmentItem == null) return;

            lblItem1.Text = equipmentItem.Name;
            lblItem1_Level.Text = "LEVEL: " + equipmentItem.RequiredLevel.ToString() + " " + equipmentItem.Slot;

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
            lblItem1_affixes.Text = "";

            int prefixCount = 1;
            foreach (var affix in equipmentItem.Prefixes)
            {
                lblItem1_affixes.Text = lblItem1_affixes.Text + $"P{prefixCount}: {affix.Affix.GetDisplayName()}  - {affix.Values.Value} ({affix.Values.MinValue} - {affix.Values.MaxValue}) \n";
                prefixCount++;
            }

            int suffixCount = 1;
            foreach (var affix in equipmentItem.Suffixes)
            {
                lblItem1_affixes.Text = lblItem1_affixes.Text + $"S{suffixCount}: {affix.Affix.GetDisplayName()}  - {affix.Values.Value} ({affix.Values.MinValue} - {affix.Values.MaxValue})  \n";
                suffixCount++;
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