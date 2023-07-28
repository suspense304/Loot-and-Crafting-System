namespace Crafting_System
{
    public partial class Form1 : Form
    {
        ItemCreationService itemCreationService = new ItemCreationService();
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
            int normalItems = 0;
            int magicItems = 0;
            int rareItems = 0;
            int epicItems = 0;
            int legendaryItems = 0;
            int superItems = 0;


            for (int i = 0; i < 5000; i++)
            {
                EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), itemCreationService.GetRandomGearSlot());
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

            lstInventory.Items.Add($"Normal: {normalItems}");
            lstInventory.Items.Add($"Magic: {magicItems}");
            lstInventory.Items.Add($"Rare: {rareItems}");
            lstInventory.Items.Add($"Epic: {epicItems}");
            lstInventory.Items.Add($"Legendary: {legendaryItems}");
            lstInventory.Items.Add($"Super: {superItems}");
        }

        private void btnCreate_Item_1_Click(object sender, EventArgs e)
        {
            EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), itemCreationService.GetRandomGearSlot());

            lblItem1.Text = equipmentItem.Name + " " + equipmentItem.MaxAffix;
            switch (equipmentItem.Prefixes.Count)
            {
                case 0:
                    lblItem1_prefix_1.Text = "";
                    lblItem1_prefix_2.Text = "";
                    lblItem1_prefix_3.Text = "";
                    break;
                case 1:
                    lblItem1_prefix_1.Text = equipmentItem.Prefixes[0].Affix.ToString();
                    lblItem1_prefix_2.Text = "";
                    lblItem1_prefix_3.Text = "";
                    break;
                case 2:
                    lblItem1_prefix_1.Text = equipmentItem.Prefixes[0].Affix.ToString();
                    lblItem1_prefix_2.Text = equipmentItem.Prefixes[1].Affix.ToString();
                    lblItem1_prefix_3.Text = "";
                    break;
                case 3:
                    lblItem1_prefix_1.Text = equipmentItem.Prefixes[0].Affix.ToString();
                    lblItem1_prefix_2.Text = equipmentItem.Prefixes[1].Affix.ToString();
                    lblItem1_prefix_3.Text = equipmentItem.Prefixes[2].Affix.ToString();
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
                    lblItem1_suffix_1.Text = equipmentItem.Suffixes[0].Affix.ToString();
                    lblItem1_suffix_2.Text = "";
                    lblItem1_suffix_3.Text = "";
                    break;
                case 2:
                    lblItem1_suffix_1.Text = equipmentItem.Suffixes[0].Affix.ToString();
                    lblItem1_suffix_2.Text = equipmentItem.Suffixes[1].Affix.ToString();
                    lblItem1_suffix_3.Text = "";
                    break;
                case 3:
                    lblItem1_suffix_1.Text = equipmentItem.Suffixes[0].Affix.ToString();
                    lblItem1_suffix_2.Text = equipmentItem.Suffixes[1].Affix.ToString();
                    lblItem1_suffix_3.Text = equipmentItem.Suffixes[2].Affix.ToString();
                    break;
            }
        }

        private void btnCreate_Item_2_Click(object sender, EventArgs e)
        {
            EquipmentItem equipmentItem = itemCreationService.CreateEquipmentItem(Convert.ToInt16(txtLevel.Text), itemCreationService.GetRandomGearSlot());

            lblItem2.Text = equipmentItem.Name + " " + equipmentItem.MaxAffix;
            switch (equipmentItem.Prefixes.Count)
            {
                case 0:
                    lblItem2_prefix_1.Text = "";
                    lblItem2_prefix_2.Text = "";
                    lblItem2_prefix_3.Text = "";
                    break;
                case 1:
                    lblItem2_prefix_1.Text = equipmentItem.Prefixes[0].ToString();
                    lblItem2_prefix_2.Text = "";
                    lblItem2_prefix_3.Text = "";
                    break;
                case 2:
                    lblItem2_prefix_1.Text = equipmentItem.Prefixes[0].ToString();
                    lblItem2_prefix_2.Text = equipmentItem.Prefixes[1].ToString();
                    lblItem2_prefix_3.Text = "";
                    break;
                case 3:
                    lblItem2_prefix_1.Text = equipmentItem.Prefixes[0].ToString();
                    lblItem2_prefix_2.Text = equipmentItem.Prefixes[1].ToString();
                    lblItem2_prefix_3.Text = equipmentItem.Prefixes[2].ToString();
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
                    lblItem2_suffix_1.Text = equipmentItem.Suffixes[0].ToString();
                    lblItem2_suffix_2.Text = "";
                    lblItem2_suffix_3.Text = "";
                    break;
                case 2:
                    lblItem2_suffix_1.Text = equipmentItem.Suffixes[0].ToString();
                    lblItem2_suffix_2.Text = equipmentItem.Suffixes[1].ToString();
                    lblItem2_suffix_3.Text = "";
                    break;
                case 3:
                    lblItem2_suffix_1.Text = equipmentItem.Suffixes[0].ToString();
                    lblItem2_suffix_2.Text = equipmentItem.Suffixes[1].ToString();
                    lblItem2_suffix_3.Text = equipmentItem.Suffixes[2].ToString();
                    break;
            }
        }
    }
}