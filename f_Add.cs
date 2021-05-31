﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryItemClass;


namespace Inventory_Manager
{
    public partial class f_Add : Form
    {
        public f_Add()
        {
            InitializeComponent();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String item_SKU = tb_SKU.Text;
            String item_Cat = tb_Cat.Text;
            String item_Name = tb_itemName.Text;
            int item_Quantity = int.Parse(tb_itemQuant.Text);
            double item_PPrice = double.Parse(tb_itemPPrice.Text);
            double item_LPrice = double.Parse(tb_itemLPrice.Text);
            String item_Desc = tb_itemDesc.Text;
            DateTime item_ListDate = DateTime.Today;


            InventoryItem item = new InventoryItem(item_SKU, item_Cat, item_Name,item_Quantity,item_PPrice,item_LPrice,
                item_Desc,item_ListDate);
            
            Form1.list.Add(item);

          

            f_Add.ActiveForm.Close();
            
        }
    } 
}
