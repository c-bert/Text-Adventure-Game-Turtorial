using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure_Game_Turtorial
{
    class ShopItems
    {
        public string ItemName { get; set; }
        public int Cost { get; set; }
        public List<int> EventIdTriggers { get; set; }
    }
}
