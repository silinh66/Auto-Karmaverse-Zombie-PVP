using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KAutoHelper;
using Color = System.Drawing.Color;

namespace adb_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region data
        Bitmap BOSS_TRUONG_NHUONG_CP;
        Bitmap BOSS_TRUONG_NHUONG_1;
        Bitmap BOSS_TRUONG_NHUONG_2;
        Bitmap BOSS_TRUONG_NHUONG_3;
        Bitmap BOSS_TRUONG_NHUONG_4;
        Bitmap BOSS_TRUONG_NHUONG_5;
        Bitmap BOSS_TRUONG_NHUONG_6;
        Bitmap BOSS_TRUONG_NHUONG_7;
        Bitmap BOSS_TRUONG_NHUONG_8;
        Bitmap BOSS_TRUONG_NHUONG_9;
        Bitmap BOSS_TRUONG_NHUONG_10;
        Bitmap BOSS_TRUONG_NHUONG_11;
        Bitmap BOSS_TRUONG_NHUONG_12;
        Bitmap BOSS_TRUONG_NHUONG_13;
        Bitmap BOSS_TRUONG_NHUONG_14;
        Bitmap BOSS_TRUONG_NHUONG_15;
        Bitmap BOSS_TRUONG_NHUONG_16;
        Bitmap BOSS_TRUONG_NHUONG_17;
        Bitmap BOSS_TRUONG_NHUONG_18;
        Bitmap BOSS_TRUONG_NHUONG_19;
        Bitmap BOSS_TRUONG_NHUONG_20;
        Bitmap BOSS_TRUONG_NHUONG_21;
        Bitmap BOSS_TRUONG_NHUONG_22;
        Bitmap BOSS_TRUONG_NHUONG_23;
        Bitmap BOSS_TRUONG_NHUONG_24;

        Bitmap BOSS_TRUONG_LUONG_CP;
        Bitmap BOSS_TRUONG_LUONG_1;
        Bitmap BOSS_TRUONG_LUONG_2;
        Bitmap BOSS_TRUONG_LUONG_3;
        Bitmap BOSS_TRUONG_LUONG_4;
        Bitmap BOSS_TRUONG_LUONG_5;
        Bitmap BOSS_TRUONG_LUONG_6;
        Bitmap BOSS_TRUONG_LUONG_7;
        Bitmap BOSS_TRUONG_LUONG_8;
        Bitmap BOSS_TRUONG_LUONG_9;
        Bitmap BOSS_TRUONG_LUONG_10;
        Bitmap BOSS_TRUONG_LUONG_11;
        Bitmap BOSS_TRUONG_LUONG_12;
        Bitmap BOSS_TRUONG_LUONG_13;
        Bitmap BOSS_TRUONG_LUONG_14;
        Bitmap BOSS_TRUONG_LUONG_15;
        Bitmap BOSS_TRUONG_LUONG_16;
        Bitmap BOSS_TRUONG_LUONG_17;
        Bitmap BOSS_TRUONG_LUONG_18;
        Bitmap BOSS_TRUONG_LUONG_19;
        Bitmap BOSS_TRUONG_LUONG_20;
        Bitmap BOSS_TRUONG_LUONG_21;
        Bitmap BOSS_TRUONG_LUONG_22;
        Bitmap BOSS_TRUONG_LUONG_23;
        Bitmap BOSS_TRUONG_LUONG_24;

        Bitmap BOSS_TRUONG_GIAC_CP;
        Bitmap BOSS_TRUONG_GIAC_1;
        Bitmap BOSS_TRUONG_GIAC_2;
        Bitmap BOSS_TRUONG_GIAC_3;
        Bitmap BOSS_TRUONG_GIAC_4;
        Bitmap BOSS_TRUONG_GIAC_5;
        Bitmap BOSS_TRUONG_GIAC_6;
        Bitmap BOSS_TRUONG_GIAC_7;
        Bitmap BOSS_TRUONG_GIAC_8;
        Bitmap BOSS_TRUONG_GIAC_9;
        Bitmap BOSS_TRUONG_GIAC_10;
        Bitmap BOSS_TRUONG_GIAC_11;
        Bitmap BOSS_TRUONG_GIAC_12;
        Bitmap BOSS_TRUONG_GIAC_13;
        Bitmap BOSS_TRUONG_GIAC_14;
        Bitmap BOSS_TRUONG_GIAC_15;
        Bitmap BOSS_TRUONG_GIAC_16;
        Bitmap BOSS_TRUONG_GIAC_17;
        Bitmap BOSS_TRUONG_GIAC_18;
        Bitmap BOSS_TRUONG_GIAC_19;
        Bitmap BOSS_TRUONG_GIAC_20;
        Bitmap BOSS_TRUONG_GIAC_21;
        Bitmap BOSS_TRUONG_GIAC_22;
        Bitmap BOSS_TRUONG_GIAC_23;
        Bitmap BOSS_TRUONG_GIAC_24;

        Bitmap BOSS_TRUONG_BAO_CP;
        Bitmap BOSS_TRUONG_BAO_1;
        Bitmap BOSS_TRUONG_BAO_2;
        Bitmap BOSS_TRUONG_BAO_3;
        Bitmap BOSS_TRUONG_BAO_4;
        Bitmap BOSS_TRUONG_BAO_5;
        Bitmap BOSS_TRUONG_BAO_6;
        Bitmap BOSS_TRUONG_BAO_7;
        Bitmap BOSS_TRUONG_BAO_8;
        Bitmap BOSS_TRUONG_BAO_9;
        Bitmap BOSS_TRUONG_BAO_10;
        Bitmap BOSS_TRUONG_BAO_11;
        Bitmap BOSS_TRUONG_BAO_12;
        Bitmap BOSS_TRUONG_BAO_13;
        Bitmap BOSS_TRUONG_BAO_14;
        Bitmap BOSS_TRUONG_BAO_15;
        Bitmap BOSS_TRUONG_BAO_16;
        Bitmap BOSS_TRUONG_BAO_17;
        Bitmap BOSS_TRUONG_BAO_18;
        Bitmap BOSS_TRUONG_BAO_19;
        Bitmap BOSS_TRUONG_BAO_20;
        Bitmap BOSS_TRUONG_BAO_21;
        Bitmap BOSS_TRUONG_BAO_22;
        Bitmap BOSS_TRUONG_BAO_23;
        Bitmap BOSS_TRUONG_BAO_24;

        Bitmap BOSS_LUU_BIEU_CP;
        Bitmap BOSS_LUU_BIEU_1;
        Bitmap BOSS_LUU_BIEU_2;
        Bitmap BOSS_LUU_BIEU_3;
        Bitmap BOSS_LUU_BIEU_4;
        Bitmap BOSS_LUU_BIEU_5;
        Bitmap BOSS_LUU_BIEU_6;
        Bitmap BOSS_LUU_BIEU_7;
        Bitmap BOSS_LUU_BIEU_8;
        Bitmap BOSS_LUU_BIEU_9;
        Bitmap BOSS_LUU_BIEU_10;
        Bitmap BOSS_LUU_BIEU_11;
        Bitmap BOSS_LUU_BIEU_12;
        Bitmap BOSS_LUU_BIEU_13;
        Bitmap BOSS_LUU_BIEU_14;
        Bitmap BOSS_LUU_BIEU_15;
        Bitmap BOSS_LUU_BIEU_16;
        Bitmap BOSS_LUU_BIEU_17;
        Bitmap BOSS_LUU_BIEU_18;
        Bitmap BOSS_LUU_BIEU_19;
        Bitmap BOSS_LUU_BIEU_20;
        Bitmap BOSS_LUU_BIEU_21;
        Bitmap BOSS_LUU_BIEU_22;
        Bitmap BOSS_LUU_BIEU_23;
        Bitmap BOSS_LUU_BIEU_24;

        Bitmap BOSS_CONG_TON_CP;
        Bitmap BOSS_CONG_TON_1;
        Bitmap BOSS_CONG_TON_2;
        Bitmap BOSS_CONG_TON_3;
        Bitmap BOSS_CONG_TON_4;
        Bitmap BOSS_CONG_TON_5;
        Bitmap BOSS_CONG_TON_6;
        Bitmap BOSS_CONG_TON_7;
        Bitmap BOSS_CONG_TON_8;
        Bitmap BOSS_CONG_TON_9;
        Bitmap BOSS_CONG_TON_10;
        Bitmap BOSS_CONG_TON_11;
        Bitmap BOSS_CONG_TON_12;
        Bitmap BOSS_CONG_TON_13;
        Bitmap BOSS_CONG_TON_14;
        Bitmap BOSS_CONG_TON_15;
        Bitmap BOSS_CONG_TON_16;
        Bitmap BOSS_CONG_TON_17;
        Bitmap BOSS_CONG_TON_18;
        Bitmap BOSS_CONG_TON_19;
        Bitmap BOSS_CONG_TON_20;
        Bitmap BOSS_CONG_TON_21;
        Bitmap BOSS_CONG_TON_22;
        Bitmap BOSS_CONG_TON_23;
        Bitmap BOSS_CONG_TON_24;

        Bitmap LEFT_LOCATION_CP;
        Bitmap LEFT_LOCATION_1;
        Bitmap LEFT_LOCATION_2;
        Bitmap LEFT_LOCATION_3;
        Bitmap LEFT_LOCATION_4;
        Bitmap LEFT_LOCATION_5;
        Bitmap LEFT_LOCATION_6;
        Bitmap LEFT_LOCATION_7;
        Bitmap LEFT_LOCATION_8;
        Bitmap LEFT_LOCATION_9;
        Bitmap LEFT_LOCATION_10;
        Bitmap LEFT_LOCATION_11;
        Bitmap LEFT_LOCATION_12;
        Bitmap LEFT_LOCATION_13;
        Bitmap LEFT_LOCATION_14;
        Bitmap LEFT_LOCATION_15;
        Bitmap LEFT_LOCATION_16;
        Bitmap LEFT_LOCATION_17;
        Bitmap LEFT_LOCATION_18;
        Bitmap LEFT_LOCATION_19;
        Bitmap LEFT_LOCATION_20;
        Bitmap LEFT_LOCATION_21;
        Bitmap LEFT_LOCATION_22;
        Bitmap LEFT_LOCATION_23;
        Bitmap LEFT_LOCATION_24;

        Bitmap RIGHT_LOCATION_CP;
        Bitmap RIGHT_LOCATION_1;
        Bitmap RIGHT_LOCATION_2;
        Bitmap RIGHT_LOCATION_3;
        Bitmap RIGHT_LOCATION_4;
        Bitmap RIGHT_LOCATION_5;
        Bitmap RIGHT_LOCATION_6;
        Bitmap RIGHT_LOCATION_7;
        Bitmap RIGHT_LOCATION_8;
        Bitmap RIGHT_LOCATION_9;
        Bitmap RIGHT_LOCATION_10;
        Bitmap RIGHT_LOCATION_11;
        Bitmap RIGHT_LOCATION_12;
        Bitmap RIGHT_LOCATION_13;
        Bitmap RIGHT_LOCATION_14;
        Bitmap RIGHT_LOCATION_15;
        Bitmap RIGHT_LOCATION_16;
        Bitmap RIGHT_LOCATION_17;
        Bitmap RIGHT_LOCATION_18;
        Bitmap RIGHT_LOCATION_19;
        Bitmap RIGHT_LOCATION_20;
        Bitmap RIGHT_LOCATION_21;
        Bitmap RIGHT_LOCATION_22;
        Bitmap RIGHT_LOCATION_23;
        Bitmap RIGHT_LOCATION_24;

        Bitmap LEFT_LOCATION_CLONE_CP;
        Bitmap LEFT_LOCATION_CLONE_1;
        Bitmap LEFT_LOCATION_CLONE_2;
        Bitmap LEFT_LOCATION_CLONE_3;
        Bitmap LEFT_LOCATION_CLONE_4;
        Bitmap LEFT_LOCATION_CLONE_5;
        Bitmap LEFT_LOCATION_CLONE_6;
        Bitmap LEFT_LOCATION_CLONE_7;
        Bitmap LEFT_LOCATION_CLONE_8;
        Bitmap LEFT_LOCATION_CLONE_9;
        Bitmap LEFT_LOCATION_CLONE_10;
        Bitmap LEFT_LOCATION_CLONE_11;
        Bitmap LEFT_LOCATION_CLONE_12;
        Bitmap LEFT_LOCATION_CLONE_13;
        Bitmap LEFT_LOCATION_CLONE_14;
        Bitmap LEFT_LOCATION_CLONE_15;
        Bitmap LEFT_LOCATION_CLONE_16;
        Bitmap LEFT_LOCATION_CLONE_17;
        Bitmap LEFT_LOCATION_CLONE_18;
        Bitmap LEFT_LOCATION_CLONE_19;
        Bitmap LEFT_LOCATION_CLONE_20;
        Bitmap LEFT_LOCATION_CLONE_21;
        Bitmap LEFT_LOCATION_CLONE_22;
        Bitmap LEFT_LOCATION_CLONE_23;
        Bitmap LEFT_LOCATION_CLONE_24;

        Bitmap RIGHT_LOCATION_CLONE_CP;
        Bitmap RIGHT_LOCATION_CLONE_1;
        Bitmap RIGHT_LOCATION_CLONE_2;
        Bitmap RIGHT_LOCATION_CLONE_3;
        Bitmap RIGHT_LOCATION_CLONE_4;
        Bitmap RIGHT_LOCATION_CLONE_5;
        Bitmap RIGHT_LOCATION_CLONE_6;
        Bitmap RIGHT_LOCATION_CLONE_7;
        Bitmap RIGHT_LOCATION_CLONE_8;
        Bitmap RIGHT_LOCATION_CLONE_9;
        Bitmap RIGHT_LOCATION_CLONE_10;
        Bitmap RIGHT_LOCATION_CLONE_11;
        Bitmap RIGHT_LOCATION_CLONE_12;
        Bitmap RIGHT_LOCATION_CLONE_13;
        Bitmap RIGHT_LOCATION_CLONE_14;
        Bitmap RIGHT_LOCATION_CLONE_15;
        Bitmap RIGHT_LOCATION_CLONE_16;
        Bitmap RIGHT_LOCATION_CLONE_17;
        Bitmap RIGHT_LOCATION_CLONE_18;
        Bitmap RIGHT_LOCATION_CLONE_19;
        Bitmap RIGHT_LOCATION_CLONE_20;
        Bitmap RIGHT_LOCATION_CLONE_21;
        Bitmap RIGHT_LOCATION_CLONE_22;
        Bitmap RIGHT_LOCATION_CLONE_23;
        Bitmap RIGHT_LOCATION_CLONE_24;

        Bitmap FIGHTING_CP;
        Bitmap FIGHTING_1;
        Bitmap FIGHTING_2;
        Bitmap FIGHTING_3;
        Bitmap FIGHTING_4;
        Bitmap FIGHTING_5;
        Bitmap FIGHTING_6;
        Bitmap FIGHTING_7;
        Bitmap FIGHTING_8;
        Bitmap FIGHTING_9;
        Bitmap FIGHTING_10;
        Bitmap FIGHTING_11;
        Bitmap FIGHTING_12;
        Bitmap FIGHTING_13;
        Bitmap FIGHTING_14;
        Bitmap FIGHTING_15;
        Bitmap FIGHTING_16;
        Bitmap FIGHTING_17;
        Bitmap FIGHTING_18;
        Bitmap FIGHTING_19;
        Bitmap FIGHTING_20;
        Bitmap FIGHTING_21;
        Bitmap FIGHTING_22;
        Bitmap FIGHTING_23;
        Bitmap FIGHTING_24;

        Bitmap IS_FIGHT_CP;
        Bitmap IS_FIGHT_1;
        Bitmap IS_FIGHT_2;
        Bitmap IS_FIGHT_3;
        Bitmap IS_FIGHT_4;
        Bitmap IS_FIGHT_5;
        Bitmap IS_FIGHT_6;
        Bitmap IS_FIGHT_7;
        Bitmap IS_FIGHT_8;
        Bitmap IS_FIGHT_9;
        Bitmap IS_FIGHT_10;
        Bitmap IS_FIGHT_11;
        Bitmap IS_FIGHT_12;
        Bitmap IS_FIGHT_13;
        Bitmap IS_FIGHT_14;
        Bitmap IS_FIGHT_15;
        Bitmap IS_FIGHT_16;
        Bitmap IS_FIGHT_17;
        Bitmap IS_FIGHT_18;
        Bitmap IS_FIGHT_19;
        Bitmap IS_FIGHT_20;
        Bitmap IS_FIGHT_21;
        Bitmap IS_FIGHT_22;
        Bitmap IS_FIGHT_23;
        Bitmap IS_FIGHT_24;

        Bitmap TRUONG_LUONG_FIGHTING_CP;
        Bitmap TRUONG_LUONG_FIGHTING_1;
        Bitmap TRUONG_LUONG_FIGHTING_2;
        Bitmap TRUONG_LUONG_FIGHTING_3;
        Bitmap TRUONG_LUONG_FIGHTING_4;
        Bitmap TRUONG_LUONG_FIGHTING_5;
        Bitmap TRUONG_LUONG_FIGHTING_6;
        Bitmap TRUONG_LUONG_FIGHTING_7;
        Bitmap TRUONG_LUONG_FIGHTING_8;
        Bitmap TRUONG_LUONG_FIGHTING_9;
        Bitmap TRUONG_LUONG_FIGHTING_10;
        Bitmap TRUONG_LUONG_FIGHTING_11;
        Bitmap TRUONG_LUONG_FIGHTING_12;
        Bitmap TRUONG_LUONG_FIGHTING_13;
        Bitmap TRUONG_LUONG_FIGHTING_14;
        Bitmap TRUONG_LUONG_FIGHTING_15;
        Bitmap TRUONG_LUONG_FIGHTING_16;
        Bitmap TRUONG_LUONG_FIGHTING_17;
        Bitmap TRUONG_LUONG_FIGHTING_18;
        Bitmap TRUONG_LUONG_FIGHTING_19;
        Bitmap TRUONG_LUONG_FIGHTING_20;
        Bitmap TRUONG_LUONG_FIGHTING_21;
        Bitmap TRUONG_LUONG_FIGHTING_22;
        Bitmap TRUONG_LUONG_FIGHTING_23;
        Bitmap TRUONG_LUONG_FIGHTING_24;

        Bitmap TRUONG_GIAC_FIGHTING_CP;
        Bitmap TRUONG_GIAC_FIGHTING_1;
        Bitmap TRUONG_GIAC_FIGHTING_2;
        Bitmap TRUONG_GIAC_FIGHTING_3;
        Bitmap TRUONG_GIAC_FIGHTING_4;
        Bitmap TRUONG_GIAC_FIGHTING_5;
        Bitmap TRUONG_GIAC_FIGHTING_6;
        Bitmap TRUONG_GIAC_FIGHTING_7;
        Bitmap TRUONG_GIAC_FIGHTING_8;
        Bitmap TRUONG_GIAC_FIGHTING_9;
        Bitmap TRUONG_GIAC_FIGHTING_10;
        Bitmap TRUONG_GIAC_FIGHTING_11;
        Bitmap TRUONG_GIAC_FIGHTING_12;
        Bitmap TRUONG_GIAC_FIGHTING_13;
        Bitmap TRUONG_GIAC_FIGHTING_14;
        Bitmap TRUONG_GIAC_FIGHTING_15;
        Bitmap TRUONG_GIAC_FIGHTING_16;
        Bitmap TRUONG_GIAC_FIGHTING_17;
        Bitmap TRUONG_GIAC_FIGHTING_18;
        Bitmap TRUONG_GIAC_FIGHTING_19;
        Bitmap TRUONG_GIAC_FIGHTING_20;
        Bitmap TRUONG_GIAC_FIGHTING_21;
        Bitmap TRUONG_GIAC_FIGHTING_22;
        Bitmap TRUONG_GIAC_FIGHTING_23;
        Bitmap TRUONG_GIAC_FIGHTING_24;

        Bitmap TRUONG_BAO_FIGHTING_CP;
        Bitmap TRUONG_BAO_FIGHTING_1;
        Bitmap TRUONG_BAO_FIGHTING_2;
        Bitmap TRUONG_BAO_FIGHTING_3;
        Bitmap TRUONG_BAO_FIGHTING_4;
        Bitmap TRUONG_BAO_FIGHTING_5;
        Bitmap TRUONG_BAO_FIGHTING_6;
        Bitmap TRUONG_BAO_FIGHTING_7;
        Bitmap TRUONG_BAO_FIGHTING_8;
        Bitmap TRUONG_BAO_FIGHTING_9;
        Bitmap TRUONG_BAO_FIGHTING_10;
        Bitmap TRUONG_BAO_FIGHTING_11;
        Bitmap TRUONG_BAO_FIGHTING_12;
        Bitmap TRUONG_BAO_FIGHTING_13;
        Bitmap TRUONG_BAO_FIGHTING_14;
        Bitmap TRUONG_BAO_FIGHTING_15;
        Bitmap TRUONG_BAO_FIGHTING_16;
        Bitmap TRUONG_BAO_FIGHTING_17;
        Bitmap TRUONG_BAO_FIGHTING_18;
        Bitmap TRUONG_BAO_FIGHTING_19;
        Bitmap TRUONG_BAO_FIGHTING_20;
        Bitmap TRUONG_BAO_FIGHTING_21;
        Bitmap TRUONG_BAO_FIGHTING_22;
        Bitmap TRUONG_BAO_FIGHTING_23;
        Bitmap TRUONG_BAO_FIGHTING_24;

        Bitmap LUU_BIEU_FIGHTING_CP;
        Bitmap LUU_BIEU_FIGHTING_1;
        Bitmap LUU_BIEU_FIGHTING_2;
        Bitmap LUU_BIEU_FIGHTING_3;
        Bitmap LUU_BIEU_FIGHTING_4;
        Bitmap LUU_BIEU_FIGHTING_5;
        Bitmap LUU_BIEU_FIGHTING_6;
        Bitmap LUU_BIEU_FIGHTING_7;
        Bitmap LUU_BIEU_FIGHTING_8;
        Bitmap LUU_BIEU_FIGHTING_9;
        Bitmap LUU_BIEU_FIGHTING_10;
        Bitmap LUU_BIEU_FIGHTING_11;
        Bitmap LUU_BIEU_FIGHTING_12;
        Bitmap LUU_BIEU_FIGHTING_13;
        Bitmap LUU_BIEU_FIGHTING_14;
        Bitmap LUU_BIEU_FIGHTING_15;
        Bitmap LUU_BIEU_FIGHTING_16;
        Bitmap LUU_BIEU_FIGHTING_17;
        Bitmap LUU_BIEU_FIGHTING_18;
        Bitmap LUU_BIEU_FIGHTING_19;
        Bitmap LUU_BIEU_FIGHTING_20;
        Bitmap LUU_BIEU_FIGHTING_21;
        Bitmap LUU_BIEU_FIGHTING_22;
        Bitmap LUU_BIEU_FIGHTING_23;
        Bitmap LUU_BIEU_FIGHTING_24;

        Bitmap CONG_TON_FIGHTING_CP;
        Bitmap CONG_TON_FIGHTING_1;
        Bitmap CONG_TON_FIGHTING_2;
        Bitmap CONG_TON_FIGHTING_3;
        Bitmap CONG_TON_FIGHTING_4;
        Bitmap CONG_TON_FIGHTING_5;
        Bitmap CONG_TON_FIGHTING_6;
        Bitmap CONG_TON_FIGHTING_7;
        Bitmap CONG_TON_FIGHTING_8;
        Bitmap CONG_TON_FIGHTING_9;
        Bitmap CONG_TON_FIGHTING_10;
        Bitmap CONG_TON_FIGHTING_11;
        Bitmap CONG_TON_FIGHTING_12;
        Bitmap CONG_TON_FIGHTING_13;
        Bitmap CONG_TON_FIGHTING_14;
        Bitmap CONG_TON_FIGHTING_15;
        Bitmap CONG_TON_FIGHTING_16;
        Bitmap CONG_TON_FIGHTING_17;
        Bitmap CONG_TON_FIGHTING_18;
        Bitmap CONG_TON_FIGHTING_19;
        Bitmap CONG_TON_FIGHTING_20;
        Bitmap CONG_TON_FIGHTING_21;
        Bitmap CONG_TON_FIGHTING_22;
        Bitmap CONG_TON_FIGHTING_23;
        Bitmap CONG_TON_FIGHTING_24;

        Bitmap LOCATION1_CP;
        Bitmap LOCATION1_1;
        Bitmap LOCATION1_2;
        Bitmap LOCATION1_3;
        Bitmap LOCATION1_4;
        Bitmap LOCATION1_5;
        Bitmap LOCATION1_6;
        Bitmap LOCATION1_7;
        Bitmap LOCATION1_8;
        Bitmap LOCATION1_9;
        Bitmap LOCATION1_10;
        Bitmap LOCATION1_11;
        Bitmap LOCATION1_12;
        Bitmap LOCATION1_13;
        Bitmap LOCATION1_14;
        Bitmap LOCATION1_15;
        Bitmap LOCATION1_16;
        Bitmap LOCATION1_17;
        Bitmap LOCATION1_18;
        Bitmap LOCATION1_19;
        Bitmap LOCATION1_20;
        Bitmap LOCATION1_21;
        Bitmap LOCATION1_22;
        Bitmap LOCATION1_23;
        Bitmap LOCATION1_24;

        Bitmap LOCATION2_CP;
        Bitmap LOCATION2_1;
        Bitmap LOCATION2_2;
        Bitmap LOCATION2_3;
        Bitmap LOCATION2_4;
        Bitmap LOCATION2_5;
        Bitmap LOCATION2_6;
        Bitmap LOCATION2_7;
        Bitmap LOCATION2_8;
        Bitmap LOCATION2_9;
        Bitmap LOCATION2_10;
        Bitmap LOCATION2_11;
        Bitmap LOCATION2_12;
        Bitmap LOCATION2_13;
        Bitmap LOCATION2_14;
        Bitmap LOCATION2_15;
        Bitmap LOCATION2_16;
        Bitmap LOCATION2_17;
        Bitmap LOCATION2_18;
        Bitmap LOCATION2_19;
        Bitmap LOCATION2_20;
        Bitmap LOCATION2_21;
        Bitmap LOCATION2_22;
        Bitmap LOCATION2_23;
        Bitmap LOCATION2_24;

        Bitmap LOCATION3_CP;
        Bitmap LOCATION3_1;
        Bitmap LOCATION3_2;
        Bitmap LOCATION3_3;
        Bitmap LOCATION3_4;
        Bitmap LOCATION3_5;
        Bitmap LOCATION3_6;
        Bitmap LOCATION3_7;
        Bitmap LOCATION3_8;
        Bitmap LOCATION3_9;
        Bitmap LOCATION3_10;
        Bitmap LOCATION3_11;
        Bitmap LOCATION3_12;
        Bitmap LOCATION3_13;
        Bitmap LOCATION3_14;
        Bitmap LOCATION3_15;
        Bitmap LOCATION3_16;
        Bitmap LOCATION3_17;
        Bitmap LOCATION3_18;
        Bitmap LOCATION3_19;
        Bitmap LOCATION3_20;
        Bitmap LOCATION3_21;
        Bitmap LOCATION3_22;
        Bitmap LOCATION3_23;
        Bitmap LOCATION3_24;

        Bitmap LOCATION4_CP;
        Bitmap LOCATION4_1;
        Bitmap LOCATION4_2;
        Bitmap LOCATION4_3;
        Bitmap LOCATION4_4;
        Bitmap LOCATION4_5;
        Bitmap LOCATION4_6;
        Bitmap LOCATION4_7;
        Bitmap LOCATION4_8;
        Bitmap LOCATION4_9;
        Bitmap LOCATION4_10;
        Bitmap LOCATION4_11;
        Bitmap LOCATION4_12;
        Bitmap LOCATION4_13;
        Bitmap LOCATION4_14;
        Bitmap LOCATION4_15;
        Bitmap LOCATION4_16;
        Bitmap LOCATION4_17;
        Bitmap LOCATION4_18;
        Bitmap LOCATION4_19;
        Bitmap LOCATION4_20;
        Bitmap LOCATION4_21;
        Bitmap LOCATION4_22;
        Bitmap LOCATION4_23;
        Bitmap LOCATION4_24;

        Bitmap LOCATION1_CLONE_CP;
        Bitmap LOCATION1_CLONE_1;
        Bitmap LOCATION1_CLONE_2;
        Bitmap LOCATION1_CLONE_3;
        Bitmap LOCATION1_CLONE_4;
        Bitmap LOCATION1_CLONE_5;
        Bitmap LOCATION1_CLONE_6;
        Bitmap LOCATION1_CLONE_7;
        Bitmap LOCATION1_CLONE_8;
        Bitmap LOCATION1_CLONE_9;
        Bitmap LOCATION1_CLONE_10;
        Bitmap LOCATION1_CLONE_11;
        Bitmap LOCATION1_CLONE_12;
        Bitmap LOCATION1_CLONE_13;
        Bitmap LOCATION1_CLONE_14;
        Bitmap LOCATION1_CLONE_15;
        Bitmap LOCATION1_CLONE_16;
        Bitmap LOCATION1_CLONE_17;
        Bitmap LOCATION1_CLONE_18;
        Bitmap LOCATION1_CLONE_19;
        Bitmap LOCATION1_CLONE_20;
        Bitmap LOCATION1_CLONE_21;
        Bitmap LOCATION1_CLONE_22;
        Bitmap LOCATION1_CLONE_23;
        Bitmap LOCATION1_CLONE_24;

        Bitmap LOCATION2_CLONE_CP;
        Bitmap LOCATION2_CLONE_1;
        Bitmap LOCATION2_CLONE_2;
        Bitmap LOCATION2_CLONE_3;
        Bitmap LOCATION2_CLONE_4;
        Bitmap LOCATION2_CLONE_5;
        Bitmap LOCATION2_CLONE_6;
        Bitmap LOCATION2_CLONE_7;
        Bitmap LOCATION2_CLONE_8;
        Bitmap LOCATION2_CLONE_9;
        Bitmap LOCATION2_CLONE_10;
        Bitmap LOCATION2_CLONE_11;
        Bitmap LOCATION2_CLONE_12;
        Bitmap LOCATION2_CLONE_13;
        Bitmap LOCATION2_CLONE_14;
        Bitmap LOCATION2_CLONE_15;
        Bitmap LOCATION2_CLONE_16;
        Bitmap LOCATION2_CLONE_17;
        Bitmap LOCATION2_CLONE_18;
        Bitmap LOCATION2_CLONE_19;
        Bitmap LOCATION2_CLONE_20;
        Bitmap LOCATION2_CLONE_21;
        Bitmap LOCATION2_CLONE_22;
        Bitmap LOCATION2_CLONE_23;
        Bitmap LOCATION2_CLONE_24;

        Bitmap LOCATION3_CLONE_CP;
        Bitmap LOCATION3_CLONE_1;
        Bitmap LOCATION3_CLONE_2;
        Bitmap LOCATION3_CLONE_3;
        Bitmap LOCATION3_CLONE_4;
        Bitmap LOCATION3_CLONE_5;
        Bitmap LOCATION3_CLONE_6;
        Bitmap LOCATION3_CLONE_7;
        Bitmap LOCATION3_CLONE_8;
        Bitmap LOCATION3_CLONE_9;
        Bitmap LOCATION3_CLONE_10;
        Bitmap LOCATION3_CLONE_11;
        Bitmap LOCATION3_CLONE_12;
        Bitmap LOCATION3_CLONE_13;
        Bitmap LOCATION3_CLONE_14;
        Bitmap LOCATION3_CLONE_15;
        Bitmap LOCATION3_CLONE_16;
        Bitmap LOCATION3_CLONE_17;
        Bitmap LOCATION3_CLONE_18;
        Bitmap LOCATION3_CLONE_19;
        Bitmap LOCATION3_CLONE_20;
        Bitmap LOCATION3_CLONE_21;
        Bitmap LOCATION3_CLONE_22;
        Bitmap LOCATION3_CLONE_23;
        Bitmap LOCATION3_CLONE_24;

        Bitmap LOCATION4_CLONE_CP;
        Bitmap LOCATION4_CLONE_1;
        Bitmap LOCATION4_CLONE_2;
        Bitmap LOCATION4_CLONE_3;
        Bitmap LOCATION4_CLONE_4;
        Bitmap LOCATION4_CLONE_5;
        Bitmap LOCATION4_CLONE_6;
        Bitmap LOCATION4_CLONE_7;
        Bitmap LOCATION4_CLONE_8;
        Bitmap LOCATION4_CLONE_9;
        Bitmap LOCATION4_CLONE_10;
        Bitmap LOCATION4_CLONE_11;
        Bitmap LOCATION4_CLONE_12;
        Bitmap LOCATION4_CLONE_13;
        Bitmap LOCATION4_CLONE_14;
        Bitmap LOCATION4_CLONE_15;
        Bitmap LOCATION4_CLONE_16;
        Bitmap LOCATION4_CLONE_17;
        Bitmap LOCATION4_CLONE_18;
        Bitmap LOCATION4_CLONE_19;
        Bitmap LOCATION4_CLONE_20;
        Bitmap LOCATION4_CLONE_21;
        Bitmap LOCATION4_CLONE_22;
        Bitmap LOCATION4_CLONE_23;
        Bitmap LOCATION4_CLONE_24;

        #endregion

        int delayLong = 1000;
        List<Stage> listName;
        List<String> selectedComboBox = new List<String>();
        List<String> listDeviceName = new List<String>();
        

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        List<Bitmap> truongNhuong = new List<Bitmap>();
        List<Bitmap> truongLuong = new List<Bitmap>();
        List<Bitmap> truongGiac = new List<Bitmap>();
        List<Bitmap> truongBao = new List<Bitmap>();
        List<Bitmap> luuBieu = new List<Bitmap>();
        List<Bitmap> congTon = new List<Bitmap>();
        List<Bitmap> fightingList = new List<Bitmap>();
        List<Bitmap> isFightList = new List<Bitmap>();
        List<Bitmap> truongLuongFightingList = new List<Bitmap>();
        List<Bitmap> truongGiacFightingList = new List<Bitmap>();
        List<Bitmap> truongBaoFightingList = new List<Bitmap>();
        List<Bitmap> luuBieuFightingList = new List<Bitmap>();
        List<Bitmap> congTonFightingList = new List<Bitmap>();
        List<Bitmap> location1List = new List<Bitmap>();
        List<Bitmap> location2List = new List<Bitmap>();
        List<Bitmap> location3List = new List<Bitmap>();
        List<Bitmap> location4List = new List<Bitmap>();
        List<Bitmap> leftLocation = new List<Bitmap>();
        List<Bitmap> rightLocation = new List<Bitmap>();
        List<Bitmap> location1CloneList = new List<Bitmap>();
        List<Bitmap> location2CloneList = new List<Bitmap>();
        List<Bitmap> location3CloneList = new List<Bitmap>();
        List<Bitmap> location4CloneList = new List<Bitmap>();
        List<Bitmap> leftLocationClone = new List<Bitmap>();
        List<Bitmap> rightLocationClone = new List<Bitmap>();
        List<bool> isStop = new List<bool>();
        List<bool> isFinish = new List<bool>();
        class ButtonCustom
        {
            public string ButtonContent { get; set; }
            public string ButtonID { get; set; }
        }

        class Device
        {
            public string DeviceContent { get; set; }
            public string DeviceID { get; set; }
        }

        class Dropdown
        {
            public List<Stage> DropdownContent { get; set; }
            public string DropdownID { get; set; }
        }

        public class Stage
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void CbItemSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(cbItemSource.SelectedValue.ToString());
            string selectedValue = (sender as ComboBox).SelectedValue.ToString();
            string deviceID = (sender as ComboBox).Tag.ToString().Split(',')[0];
            int index = Int32.Parse((sender as ComboBox).Tag.ToString().Split(',')[1]);
            //System.Diagnostics.Debug.WriteLine(selectedValue);
            //System.Diagnostics.Debug.WriteLine(deviceID);
            //System.Diagnostics.Debug.WriteLine(index);
            selectedComboBox[index] = selectedValue;
        }

        void LoadData()
        {
            BOSS_TRUONG_NHUONG_CP = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong.png");
            BOSS_TRUONG_NHUONG_1 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (1).png");
            BOSS_TRUONG_NHUONG_2 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (2).png");
            BOSS_TRUONG_NHUONG_3 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (3).png");
            BOSS_TRUONG_NHUONG_4 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (4).png");
            BOSS_TRUONG_NHUONG_5 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (5).png");
            BOSS_TRUONG_NHUONG_6 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (6).png");
            BOSS_TRUONG_NHUONG_7 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (7).png");
            BOSS_TRUONG_NHUONG_8 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (8).png");
            BOSS_TRUONG_NHUONG_9 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (9).png");
            BOSS_TRUONG_NHUONG_10 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (10).png");
            BOSS_TRUONG_NHUONG_11 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (11).png");
            BOSS_TRUONG_NHUONG_12 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (12).png");
            BOSS_TRUONG_NHUONG_13 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (13).png");
            BOSS_TRUONG_NHUONG_14 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (14).png");
            BOSS_TRUONG_NHUONG_15 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (15).png");
            BOSS_TRUONG_NHUONG_16 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (16).png");
            BOSS_TRUONG_NHUONG_17 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (17).png");
            BOSS_TRUONG_NHUONG_18 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (18).png");
            BOSS_TRUONG_NHUONG_19 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (19).png");
            BOSS_TRUONG_NHUONG_20 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (20).png");
            BOSS_TRUONG_NHUONG_21 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (21).png");
            BOSS_TRUONG_NHUONG_22 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (22).png");
            BOSS_TRUONG_NHUONG_23 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (23).png");
            BOSS_TRUONG_NHUONG_24 = (Bitmap)Bitmap.FromFile("Data/boss_50_truong_nhuong - Copy (24).png");

            BOSS_TRUONG_LUONG_CP = (Bitmap)Bitmap.FromFile("Data/truong_luong.png");
            BOSS_TRUONG_LUONG_1 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (1).png");
            BOSS_TRUONG_LUONG_2 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (2).png");
            BOSS_TRUONG_LUONG_3 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (3).png");
            BOSS_TRUONG_LUONG_4 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (4).png");
            BOSS_TRUONG_LUONG_5 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (5).png");
            BOSS_TRUONG_LUONG_6 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (6).png");
            BOSS_TRUONG_LUONG_7 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (7).png");
            BOSS_TRUONG_LUONG_8 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (8).png");
            BOSS_TRUONG_LUONG_9 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (9).png");
            BOSS_TRUONG_LUONG_10 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (10).png");
            BOSS_TRUONG_LUONG_11 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (11).png");
            BOSS_TRUONG_LUONG_12 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (12).png");
            BOSS_TRUONG_LUONG_13 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (13).png");
            BOSS_TRUONG_LUONG_14 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (14).png");
            BOSS_TRUONG_LUONG_15 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (15).png");
            BOSS_TRUONG_LUONG_16 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (16).png");
            BOSS_TRUONG_LUONG_17 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (17).png");
            BOSS_TRUONG_LUONG_18 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (18).png");
            BOSS_TRUONG_LUONG_19 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (19).png");
            BOSS_TRUONG_LUONG_20 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (20).png");
            BOSS_TRUONG_LUONG_21 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (21).png");
            BOSS_TRUONG_LUONG_22 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (22).png");
            BOSS_TRUONG_LUONG_23 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (23).png");
            BOSS_TRUONG_LUONG_24 = (Bitmap)Bitmap.FromFile("Data/truong_luong - Copy (24).png");

            BOSS_TRUONG_GIAC_CP = (Bitmap)Bitmap.FromFile("Data/truong_giac.png");
            BOSS_TRUONG_GIAC_1 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (1).png");
            BOSS_TRUONG_GIAC_2 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (2).png");
            BOSS_TRUONG_GIAC_3 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (3).png");
            BOSS_TRUONG_GIAC_4 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (4).png");
            BOSS_TRUONG_GIAC_5 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (5).png");
            BOSS_TRUONG_GIAC_6 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (6).png");
            BOSS_TRUONG_GIAC_7 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (7).png");
            BOSS_TRUONG_GIAC_8 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (8).png");
            BOSS_TRUONG_GIAC_9 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (9).png");
            BOSS_TRUONG_GIAC_10 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (10).png");
            BOSS_TRUONG_GIAC_11 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (11).png");
            BOSS_TRUONG_GIAC_12 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (12).png");
            BOSS_TRUONG_GIAC_13 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (13).png");
            BOSS_TRUONG_GIAC_14 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (14).png");
            BOSS_TRUONG_GIAC_15 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (15).png");
            BOSS_TRUONG_GIAC_16 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (16).png");
            BOSS_TRUONG_GIAC_17 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (17).png");
            BOSS_TRUONG_GIAC_18 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (18).png");
            BOSS_TRUONG_GIAC_19 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (19).png");
            BOSS_TRUONG_GIAC_20 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (20).png");
            BOSS_TRUONG_GIAC_21 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (21).png");
            BOSS_TRUONG_GIAC_22 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (22).png");
            BOSS_TRUONG_GIAC_23 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (23).png");
            BOSS_TRUONG_GIAC_24 = (Bitmap)Bitmap.FromFile("Data/truong_giac - Copy (24).png");

            BOSS_TRUONG_BAO_CP = (Bitmap)Bitmap.FromFile("Data/truong_bao.png");
            BOSS_TRUONG_BAO_1 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (1).png");
            BOSS_TRUONG_BAO_2 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (2).png");
            BOSS_TRUONG_BAO_3 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (3).png");
            BOSS_TRUONG_BAO_4 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (4).png");
            BOSS_TRUONG_BAO_5 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (5).png");
            BOSS_TRUONG_BAO_6 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (6).png");
            BOSS_TRUONG_BAO_7 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (7).png");
            BOSS_TRUONG_BAO_8 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (8).png");
            BOSS_TRUONG_BAO_9 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (9).png");
            BOSS_TRUONG_BAO_10 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (10).png");
            BOSS_TRUONG_BAO_11 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (11).png");
            BOSS_TRUONG_BAO_12 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (12).png");
            BOSS_TRUONG_BAO_13 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (13).png");
            BOSS_TRUONG_BAO_14 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (14).png");
            BOSS_TRUONG_BAO_15 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (15).png");
            BOSS_TRUONG_BAO_16 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (16).png");
            BOSS_TRUONG_BAO_17 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (17).png");
            BOSS_TRUONG_BAO_18 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (18).png");
            BOSS_TRUONG_BAO_19 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (19).png");
            BOSS_TRUONG_BAO_20 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (20).png");
            BOSS_TRUONG_BAO_21 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (21).png");
            BOSS_TRUONG_BAO_22 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (22).png");
            BOSS_TRUONG_BAO_23 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (23).png");
            BOSS_TRUONG_BAO_24 = (Bitmap)Bitmap.FromFile("Data/truong_bao - Copy (24).png");

            BOSS_LUU_BIEU_CP = (Bitmap)Bitmap.FromFile("Data/luu_bieu.png");
            BOSS_LUU_BIEU_1 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (1).png");
            BOSS_LUU_BIEU_2 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (2).png");
            BOSS_LUU_BIEU_3 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (3).png");
            BOSS_LUU_BIEU_4 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (4).png");
            BOSS_LUU_BIEU_5 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (5).png");
            BOSS_LUU_BIEU_6 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (6).png");
            BOSS_LUU_BIEU_7 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (7).png");
            BOSS_LUU_BIEU_8 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (8).png");
            BOSS_LUU_BIEU_9 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (9).png");
            BOSS_LUU_BIEU_10 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (10).png");
            BOSS_LUU_BIEU_11 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (11).png");
            BOSS_LUU_BIEU_12 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (12).png");
            BOSS_LUU_BIEU_13 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (13).png");
            BOSS_LUU_BIEU_14 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (14).png");
            BOSS_LUU_BIEU_15 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (15).png");
            BOSS_LUU_BIEU_16 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (16).png");
            BOSS_LUU_BIEU_17 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (17).png");
            BOSS_LUU_BIEU_18 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (18).png");
            BOSS_LUU_BIEU_19 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (19).png");
            BOSS_LUU_BIEU_20 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (20).png");
            BOSS_LUU_BIEU_21 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (21).png");
            BOSS_LUU_BIEU_22 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (22).png");
            BOSS_LUU_BIEU_23 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (23).png");
            BOSS_LUU_BIEU_24 = (Bitmap)Bitmap.FromFile("Data/luu_bieu - Copy (24).png");

            BOSS_CONG_TON_CP = (Bitmap)Bitmap.FromFile("Data/cong_ton.png");
            BOSS_CONG_TON_1 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (1).png");
            BOSS_CONG_TON_2 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (2).png");
            BOSS_CONG_TON_3 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (3).png");
            BOSS_CONG_TON_4 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (4).png");
            BOSS_CONG_TON_5 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (5).png");
            BOSS_CONG_TON_6 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (6).png");
            BOSS_CONG_TON_7 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (7).png");
            BOSS_CONG_TON_8 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (8).png");
            BOSS_CONG_TON_9 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (9).png");
            BOSS_CONG_TON_10 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (10).png");
            BOSS_CONG_TON_11 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (11).png");
            BOSS_CONG_TON_12 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (12).png");
            BOSS_CONG_TON_13 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (13).png");
            BOSS_CONG_TON_14 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (14).png");
            BOSS_CONG_TON_15 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (15).png");
            BOSS_CONG_TON_16 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (16).png");
            BOSS_CONG_TON_17 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (17).png");
            BOSS_CONG_TON_18 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (18).png");
            BOSS_CONG_TON_19 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (19).png");
            BOSS_CONG_TON_20 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (20).png");
            BOSS_CONG_TON_21 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (21).png");
            BOSS_CONG_TON_22 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (22).png");
            BOSS_CONG_TON_23 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (23).png");
            BOSS_CONG_TON_24 = (Bitmap)Bitmap.FromFile("Data/cong_ton - Copy (24).png");

            LEFT_LOCATION_CP = (Bitmap)Bitmap.FromFile("Data/leftLocation.png");
            LEFT_LOCATION_1 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (1).png");
            LEFT_LOCATION_2 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (2).png");
            LEFT_LOCATION_3 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (3).png");
            LEFT_LOCATION_4 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (4).png");
            LEFT_LOCATION_5 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (5).png");
            LEFT_LOCATION_6 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (6).png");
            LEFT_LOCATION_7 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (7).png");
            LEFT_LOCATION_8 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (8).png");
            LEFT_LOCATION_9 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (9).png");
            LEFT_LOCATION_10 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (10).png");
            LEFT_LOCATION_11 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (11).png");
            LEFT_LOCATION_12 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (12).png");
            LEFT_LOCATION_13 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (13).png");
            LEFT_LOCATION_14 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (14).png");
            LEFT_LOCATION_15 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (15).png");
            LEFT_LOCATION_16 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (16).png");
            LEFT_LOCATION_17 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (17).png");
            LEFT_LOCATION_18 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (18).png");
            LEFT_LOCATION_19 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (19).png");
            LEFT_LOCATION_20 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (20).png");
            LEFT_LOCATION_21 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (21).png");
            LEFT_LOCATION_22 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (22).png");
            LEFT_LOCATION_23 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (23).png");
            LEFT_LOCATION_24 = (Bitmap)Bitmap.FromFile("Data/leftLocation - Copy (24).png");

            RIGHT_LOCATION_CP = (Bitmap)Bitmap.FromFile("Data/rightLocation.png");
            RIGHT_LOCATION_1 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (1).png");
            RIGHT_LOCATION_2 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (2).png");
            RIGHT_LOCATION_3 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (3).png");
            RIGHT_LOCATION_4 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (4).png");
            RIGHT_LOCATION_5 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (5).png");
            RIGHT_LOCATION_6 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (6).png");
            RIGHT_LOCATION_7 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (7).png");
            RIGHT_LOCATION_8 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (8).png");
            RIGHT_LOCATION_9 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (9).png");
            RIGHT_LOCATION_10 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (10).png");
            RIGHT_LOCATION_11 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (11).png");
            RIGHT_LOCATION_12 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (12).png");
            RIGHT_LOCATION_13 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (13).png");
            RIGHT_LOCATION_14 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (14).png");
            RIGHT_LOCATION_15 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (15).png");
            RIGHT_LOCATION_16 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (16).png");
            RIGHT_LOCATION_17 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (17).png");
            RIGHT_LOCATION_18 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (18).png");
            RIGHT_LOCATION_19 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (19).png");
            RIGHT_LOCATION_20 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (20).png");
            RIGHT_LOCATION_21 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (21).png");
            RIGHT_LOCATION_22 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (22).png");
            RIGHT_LOCATION_23 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (23).png");
            RIGHT_LOCATION_24 = (Bitmap)Bitmap.FromFile("Data/rightLocation - Copy (24).png");

            LEFT_LOCATION_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone.png");
            LEFT_LOCATION_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (1).png");
            LEFT_LOCATION_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (2).png");
            LEFT_LOCATION_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (3).png");
            LEFT_LOCATION_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (4).png");
            LEFT_LOCATION_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (5).png");
            LEFT_LOCATION_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (6).png");
            LEFT_LOCATION_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (7).png");
            LEFT_LOCATION_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (8).png");
            LEFT_LOCATION_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (9).png");
            LEFT_LOCATION_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (10).png");
            LEFT_LOCATION_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (11).png");
            LEFT_LOCATION_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (12).png");
            LEFT_LOCATION_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (13).png");
            LEFT_LOCATION_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (14).png");
            LEFT_LOCATION_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (15).png");
            LEFT_LOCATION_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (16).png");
            LEFT_LOCATION_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (17).png");
            LEFT_LOCATION_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (18).png");
            LEFT_LOCATION_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (19).png");
            LEFT_LOCATION_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (20).png");
            LEFT_LOCATION_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (21).png");
            LEFT_LOCATION_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (22).png");
            LEFT_LOCATION_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (23).png");
            LEFT_LOCATION_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/leftLocation_clone - Copy (24).png");

            RIGHT_LOCATION_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone.png");
            RIGHT_LOCATION_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (1).png");
            RIGHT_LOCATION_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (2).png");
            RIGHT_LOCATION_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (3).png");
            RIGHT_LOCATION_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (4).png");
            RIGHT_LOCATION_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (5).png");
            RIGHT_LOCATION_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (6).png");
            RIGHT_LOCATION_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (7).png");
            RIGHT_LOCATION_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (8).png");
            RIGHT_LOCATION_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (9).png");
            RIGHT_LOCATION_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (10).png");
            RIGHT_LOCATION_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (11).png");
            RIGHT_LOCATION_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (12).png");
            RIGHT_LOCATION_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (13).png");
            RIGHT_LOCATION_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (14).png");
            RIGHT_LOCATION_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (15).png");
            RIGHT_LOCATION_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (16).png");
            RIGHT_LOCATION_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (17).png");
            RIGHT_LOCATION_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (18).png");
            RIGHT_LOCATION_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (19).png");
            RIGHT_LOCATION_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (20).png");
            RIGHT_LOCATION_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (21).png");
            RIGHT_LOCATION_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (22).png");
            RIGHT_LOCATION_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (23).png");
            RIGHT_LOCATION_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/rightLocation_clone - Copy (24).png");

            FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/fighting.png");
            FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (1).png");
            FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (2).png");
            FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (3).png");
            FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (4).png");
            FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (5).png");
            FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (6).png");
            FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (7).png");
            FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (8).png");
            FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (9).png");
            FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (10).png");
            FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (11).png");
            FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (12).png");
            FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (13).png");
            FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (14).png");
            FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (15).png");
            FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (16).png");
            FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (17).png");
            FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (18).png");
            FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (19).png");
            FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (20).png");
            FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (21).png");
            FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (22).png");
            FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (23).png");
            FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/fighting - Copy (24).png");

            IS_FIGHT_CP = (Bitmap)Bitmap.FromFile("Data/isFight.png");
            IS_FIGHT_1 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (1).png");
            IS_FIGHT_2 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (2).png");
            IS_FIGHT_3 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (3).png");
            IS_FIGHT_4 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (4).png");
            IS_FIGHT_5 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (5).png");
            IS_FIGHT_6 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (6).png");
            IS_FIGHT_7 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (7).png");
            IS_FIGHT_8 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (8).png");
            IS_FIGHT_9 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (9).png");
            IS_FIGHT_10 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (10).png");
            IS_FIGHT_11 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (11).png");
            IS_FIGHT_12 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (12).png");
            IS_FIGHT_13 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (13).png");
            IS_FIGHT_14 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (14).png");
            IS_FIGHT_15 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (15).png");
            IS_FIGHT_16 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (16).png");
            IS_FIGHT_17 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (17).png");
            IS_FIGHT_18 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (18).png");
            IS_FIGHT_19 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (19).png");
            IS_FIGHT_20 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (20).png");
            IS_FIGHT_21 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (21).png");
            IS_FIGHT_22 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (22).png");
            IS_FIGHT_23 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (23).png");
            IS_FIGHT_24 = (Bitmap)Bitmap.FromFile("Data/isFight - Copy (24).png");

            TRUONG_LUONG_FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting.png");
            TRUONG_LUONG_FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (1).png");
            TRUONG_LUONG_FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (2).png");
            TRUONG_LUONG_FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (3).png");
            TRUONG_LUONG_FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (4).png");
            TRUONG_LUONG_FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (5).png");
            TRUONG_LUONG_FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (6).png");
            TRUONG_LUONG_FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (7).png");
            TRUONG_LUONG_FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (8).png");
            TRUONG_LUONG_FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (9).png");
            TRUONG_LUONG_FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (10).png");
            TRUONG_LUONG_FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (11).png");
            TRUONG_LUONG_FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (12).png");
            TRUONG_LUONG_FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (13).png");
            TRUONG_LUONG_FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (14).png");
            TRUONG_LUONG_FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (15).png");
            TRUONG_LUONG_FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (16).png");
            TRUONG_LUONG_FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (17).png");
            TRUONG_LUONG_FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (18).png");
            TRUONG_LUONG_FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (19).png");
            TRUONG_LUONG_FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (20).png");
            TRUONG_LUONG_FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (21).png");
            TRUONG_LUONG_FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (22).png");
            TRUONG_LUONG_FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (23).png");
            TRUONG_LUONG_FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/truong_luong_fighting - Copy (24).png");

            TRUONG_GIAC_FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting.png");
            TRUONG_GIAC_FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (1).png");
            TRUONG_GIAC_FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (2).png");
            TRUONG_GIAC_FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (3).png");
            TRUONG_GIAC_FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (4).png");
            TRUONG_GIAC_FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (5).png");
            TRUONG_GIAC_FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (6).png");
            TRUONG_GIAC_FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (7).png");
            TRUONG_GIAC_FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (8).png");
            TRUONG_GIAC_FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (9).png");
            TRUONG_GIAC_FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (10).png");
            TRUONG_GIAC_FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (11).png");
            TRUONG_GIAC_FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (12).png");
            TRUONG_GIAC_FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (13).png");
            TRUONG_GIAC_FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (14).png");
            TRUONG_GIAC_FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (15).png");
            TRUONG_GIAC_FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (16).png");
            TRUONG_GIAC_FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (17).png");
            TRUONG_GIAC_FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (18).png");
            TRUONG_GIAC_FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (19).png");
            TRUONG_GIAC_FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (20).png");
            TRUONG_GIAC_FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (21).png");
            TRUONG_GIAC_FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (22).png");
            TRUONG_GIAC_FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (23).png");
            TRUONG_GIAC_FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/truong_giac_fighting - Copy (24).png");

            TRUONG_BAO_FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting.png");
            TRUONG_BAO_FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (1).png");
            TRUONG_BAO_FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (2).png");
            TRUONG_BAO_FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (3).png");
            TRUONG_BAO_FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (4).png");
            TRUONG_BAO_FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (5).png");
            TRUONG_BAO_FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (6).png");
            TRUONG_BAO_FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (7).png");
            TRUONG_BAO_FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (8).png");
            TRUONG_BAO_FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (9).png");
            TRUONG_BAO_FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (10).png");
            TRUONG_BAO_FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (11).png");
            TRUONG_BAO_FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (12).png");
            TRUONG_BAO_FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (13).png");
            TRUONG_BAO_FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (14).png");
            TRUONG_BAO_FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (15).png");
            TRUONG_BAO_FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (16).png");
            TRUONG_BAO_FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (17).png");
            TRUONG_BAO_FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (18).png");
            TRUONG_BAO_FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (19).png");
            TRUONG_BAO_FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (20).png");
            TRUONG_BAO_FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (21).png");
            TRUONG_BAO_FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (22).png");
            TRUONG_BAO_FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (23).png");
            TRUONG_BAO_FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/truong_bao_fighting - Copy (24).png");

            LUU_BIEU_FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting.png");
            LUU_BIEU_FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (1).png");
            LUU_BIEU_FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (2).png");
            LUU_BIEU_FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (3).png");
            LUU_BIEU_FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (4).png");
            LUU_BIEU_FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (5).png");
            LUU_BIEU_FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (6).png");
            LUU_BIEU_FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (7).png");
            LUU_BIEU_FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (8).png");
            LUU_BIEU_FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (9).png");
            LUU_BIEU_FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (10).png");
            LUU_BIEU_FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (11).png");
            LUU_BIEU_FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (12).png");
            LUU_BIEU_FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (13).png");
            LUU_BIEU_FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (14).png");
            LUU_BIEU_FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (15).png");
            LUU_BIEU_FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (16).png");
            LUU_BIEU_FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (17).png");
            LUU_BIEU_FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (18).png");
            LUU_BIEU_FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (19).png");
            LUU_BIEU_FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (20).png");
            LUU_BIEU_FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (21).png");
            LUU_BIEU_FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (22).png");
            LUU_BIEU_FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (23).png");
            LUU_BIEU_FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/luu_bieu_fighting - Copy (24).png");

            CONG_TON_FIGHTING_CP = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting.png");
            CONG_TON_FIGHTING_1 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (1).png");
            CONG_TON_FIGHTING_2 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (2).png");
            CONG_TON_FIGHTING_3 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (3).png");
            CONG_TON_FIGHTING_4 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (4).png");
            CONG_TON_FIGHTING_5 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (5).png");
            CONG_TON_FIGHTING_6 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (6).png");
            CONG_TON_FIGHTING_7 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (7).png");
            CONG_TON_FIGHTING_8 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (8).png");
            CONG_TON_FIGHTING_9 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (9).png");
            CONG_TON_FIGHTING_10 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (10).png");
            CONG_TON_FIGHTING_11 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (11).png");
            CONG_TON_FIGHTING_12 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (12).png");
            CONG_TON_FIGHTING_13 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (13).png");
            CONG_TON_FIGHTING_14 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (14).png");
            CONG_TON_FIGHTING_15 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (15).png");
            CONG_TON_FIGHTING_16 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (16).png");
            CONG_TON_FIGHTING_17 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (17).png");
            CONG_TON_FIGHTING_18 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (18).png");
            CONG_TON_FIGHTING_19 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (19).png");
            CONG_TON_FIGHTING_20 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (20).png");
            CONG_TON_FIGHTING_21 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (21).png");
            CONG_TON_FIGHTING_22 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (22).png");
            CONG_TON_FIGHTING_23 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (23).png");
            CONG_TON_FIGHTING_24 = (Bitmap)Bitmap.FromFile("Data/cong_ton_fighting - Copy (24).png");

            LOCATION1_CP = (Bitmap)Bitmap.FromFile("Data/loca tion1.png");
            LOCATION1_1 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (1).png");
            LOCATION1_2 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (2).png");
            LOCATION1_3 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (3).png");
            LOCATION1_4 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (4).png");
            LOCATION1_5 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (5).png");
            LOCATION1_6 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (6).png");
            LOCATION1_7 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (7).png");
            LOCATION1_8 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (8).png");
            LOCATION1_9 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (9).png");
            LOCATION1_10 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (10).png");
            LOCATION1_11 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (11).png");
            LOCATION1_12 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (12).png");
            LOCATION1_13 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (13).png");
            LOCATION1_14 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (14).png");
            LOCATION1_15 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (15).png");
            LOCATION1_16 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (16).png");
            LOCATION1_17 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (17).png");
            LOCATION1_18 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (18).png");
            LOCATION1_19 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (19).png");
            LOCATION1_20 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (20).png");
            LOCATION1_21 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (21).png");
            LOCATION1_22 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (22).png");
            LOCATION1_23 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (23).png");
            LOCATION1_24 = (Bitmap)Bitmap.FromFile("Data/loca tion1 - Copy (24).png");

            LOCATION2_CP = (Bitmap)Bitmap.FromFile("Data/location2.png");
            LOCATION2_1 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (1).png");
            LOCATION2_2 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (2).png");
            LOCATION2_3 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (3).png");
            LOCATION2_4 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (4).png");
            LOCATION2_5 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (5).png");
            LOCATION2_6 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (6).png");
            LOCATION2_7 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (7).png");
            LOCATION2_8 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (8).png");
            LOCATION2_9 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (9).png");
            LOCATION2_10 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (10).png");
            LOCATION2_11 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (11).png");
            LOCATION2_12 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (12).png");
            LOCATION2_13 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (13).png");
            LOCATION2_14 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (14).png");
            LOCATION2_15 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (15).png");
            LOCATION2_16 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (16).png");
            LOCATION2_17 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (17).png");
            LOCATION2_18 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (18).png");
            LOCATION2_19 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (19).png");
            LOCATION2_20 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (20).png");
            LOCATION2_21 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (21).png");
            LOCATION2_22 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (22).png");
            LOCATION2_23 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (23).png");
            LOCATION2_24 = (Bitmap)Bitmap.FromFile("Data/location2 - Copy (24).png");

            LOCATION3_CP = (Bitmap)Bitmap.FromFile("Data/location3.png");
            LOCATION3_1 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (1).png");
            LOCATION3_2 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (2).png");
            LOCATION3_3 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (3).png");
            LOCATION3_4 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (4).png");
            LOCATION3_5 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (5).png");
            LOCATION3_6 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (6).png");
            LOCATION3_7 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (7).png");
            LOCATION3_8 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (8).png");
            LOCATION3_9 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (9).png");
            LOCATION3_10 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (10).png");
            LOCATION3_11 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (11).png");
            LOCATION3_12 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (12).png");
            LOCATION3_13 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (13).png");
            LOCATION3_14 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (14).png");
            LOCATION3_15 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (15).png");
            LOCATION3_16 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (16).png");
            LOCATION3_17 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (17).png");
            LOCATION3_18 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (18).png");
            LOCATION3_19 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (19).png");
            LOCATION3_20 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (20).png");
            LOCATION3_21 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (21).png");
            LOCATION3_22 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (22).png");
            LOCATION3_23 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (23).png");
            LOCATION3_24 = (Bitmap)Bitmap.FromFile("Data/location3 - Copy (24).png");

            LOCATION4_CP = (Bitmap)Bitmap.FromFile("Data/location4.png");
            LOCATION4_1 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (1).png");
            LOCATION4_2 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (2).png");
            LOCATION4_3 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (3).png");
            LOCATION4_4 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (4).png");
            LOCATION4_5 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (5).png");
            LOCATION4_6 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (6).png");
            LOCATION4_7 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (7).png");
            LOCATION4_8 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (8).png");
            LOCATION4_9 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (9).png");
            LOCATION4_10 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (10).png");
            LOCATION4_11 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (11).png");
            LOCATION4_12 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (12).png");
            LOCATION4_13 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (13).png");
            LOCATION4_14 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (14).png");
            LOCATION4_15 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (15).png");
            LOCATION4_16 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (16).png");
            LOCATION4_17 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (17).png");
            LOCATION4_18 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (18).png");
            LOCATION4_19 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (19).png");
            LOCATION4_20 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (20).png");
            LOCATION4_21 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (21).png");
            LOCATION4_22 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (22).png");
            LOCATION4_23 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (23).png");
            LOCATION4_24 = (Bitmap)Bitmap.FromFile("Data/location4 - Copy (24).png");

            LOCATION1_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone.png");
            LOCATION1_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (1).png");
            LOCATION1_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (2).png");
            LOCATION1_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (3).png");
            LOCATION1_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (4).png");
            LOCATION1_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (5).png");
            LOCATION1_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (6).png");
            LOCATION1_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (7).png");
            LOCATION1_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (8).png");
            LOCATION1_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (9).png");
            LOCATION1_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (10).png");
            LOCATION1_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (11).png");
            LOCATION1_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (12).png");
            LOCATION1_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (13).png");
            LOCATION1_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (14).png");
            LOCATION1_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (15).png");
            LOCATION1_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (16).png");
            LOCATION1_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (17).png");
            LOCATION1_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (18).png");
            LOCATION1_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (19).png");
            LOCATION1_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (20).png");
            LOCATION1_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (21).png");
            LOCATION1_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (22).png");
            LOCATION1_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (23).png");
            LOCATION1_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/loca tion1_clone - Copy (24).png");

            LOCATION2_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/location2_clone.png");
            LOCATION2_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (1).png");
            LOCATION2_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (2).png");
            LOCATION2_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (3).png");
            LOCATION2_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (4).png");
            LOCATION2_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (5).png");
            LOCATION2_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (6).png");
            LOCATION2_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (7).png");
            LOCATION2_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (8).png");
            LOCATION2_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (9).png");
            LOCATION2_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (10).png");
            LOCATION2_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (11).png");
            LOCATION2_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (12).png");
            LOCATION2_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (13).png");
            LOCATION2_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (14).png");
            LOCATION2_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (15).png");
            LOCATION2_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (16).png");
            LOCATION2_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (17).png");
            LOCATION2_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (18).png");
            LOCATION2_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (19).png");
            LOCATION2_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (20).png");
            LOCATION2_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (21).png");
            LOCATION2_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (22).png");
            LOCATION2_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (23).png");
            LOCATION2_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/location2_clone - Copy (24).png");

            LOCATION3_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/location3_clone.png");
            LOCATION3_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (1).png");
            LOCATION3_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (2).png");
            LOCATION3_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (3).png");
            LOCATION3_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (4).png");
            LOCATION3_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (5).png");
            LOCATION3_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (6).png");
            LOCATION3_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (7).png");
            LOCATION3_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (8).png");
            LOCATION3_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (9).png");
            LOCATION3_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (10).png");
            LOCATION3_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (11).png");
            LOCATION3_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (12).png");
            LOCATION3_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (13).png");
            LOCATION3_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (14).png");
            LOCATION3_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (15).png");
            LOCATION3_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (16).png");
            LOCATION3_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (17).png");
            LOCATION3_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (18).png");
            LOCATION3_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (19).png");
            LOCATION3_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (20).png");
            LOCATION3_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (21).png");
            LOCATION3_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (22).png");
            LOCATION3_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (23).png");
            LOCATION3_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/location3_clone - Copy (24).png");

            LOCATION4_CLONE_CP = (Bitmap)Bitmap.FromFile("Data/location4_clone.png");
            LOCATION4_CLONE_1 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (1).png");
            LOCATION4_CLONE_2 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (2).png");
            LOCATION4_CLONE_3 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (3).png");
            LOCATION4_CLONE_4 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (4).png");
            LOCATION4_CLONE_5 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (5).png");
            LOCATION4_CLONE_6 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (6).png");
            LOCATION4_CLONE_7 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (7).png");
            LOCATION4_CLONE_8 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (8).png");
            LOCATION4_CLONE_9 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (9).png");
            LOCATION4_CLONE_10 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (10).png");
            LOCATION4_CLONE_11 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (11).png");
            LOCATION4_CLONE_12 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (12).png");
            LOCATION4_CLONE_13 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (13).png");
            LOCATION4_CLONE_14 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (14).png");
            LOCATION4_CLONE_15 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (15).png");
            LOCATION4_CLONE_16 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (16).png");
            LOCATION4_CLONE_17 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (17).png");
            LOCATION4_CLONE_18 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (18).png");
            LOCATION4_CLONE_19 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (19).png");
            LOCATION4_CLONE_20 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (20).png");
            LOCATION4_CLONE_21 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (21).png");
            LOCATION4_CLONE_22 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (22).png");
            LOCATION4_CLONE_23 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (23).png");
            LOCATION4_CLONE_24 = (Bitmap)Bitmap.FromFile("Data/location4_clone - Copy (24).png");


            truongNhuong.Add(BOSS_TRUONG_NHUONG_CP);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_1);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_2);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_3);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_4);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_5);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_6);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_7);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_8);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_9);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_10);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_11);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_12);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_13);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_14);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_15);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_16);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_17);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_18);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_19);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_20);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_21);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_22);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_23);
            truongNhuong.Add(BOSS_TRUONG_NHUONG_24);

            truongLuong.Add(BOSS_TRUONG_LUONG_CP);
            truongLuong.Add(BOSS_TRUONG_LUONG_1);
            truongLuong.Add(BOSS_TRUONG_LUONG_2);
            truongLuong.Add(BOSS_TRUONG_LUONG_3);
            truongLuong.Add(BOSS_TRUONG_LUONG_4);
            truongLuong.Add(BOSS_TRUONG_LUONG_5);
            truongLuong.Add(BOSS_TRUONG_LUONG_6);
            truongLuong.Add(BOSS_TRUONG_LUONG_7);
            truongLuong.Add(BOSS_TRUONG_LUONG_8);
            truongLuong.Add(BOSS_TRUONG_LUONG_9);
            truongLuong.Add(BOSS_TRUONG_LUONG_10);
            truongLuong.Add(BOSS_TRUONG_LUONG_11);
            truongLuong.Add(BOSS_TRUONG_LUONG_12);
            truongLuong.Add(BOSS_TRUONG_LUONG_13);
            truongLuong.Add(BOSS_TRUONG_LUONG_14);
            truongLuong.Add(BOSS_TRUONG_LUONG_15);
            truongLuong.Add(BOSS_TRUONG_LUONG_16);
            truongLuong.Add(BOSS_TRUONG_LUONG_17);
            truongLuong.Add(BOSS_TRUONG_LUONG_18);
            truongLuong.Add(BOSS_TRUONG_LUONG_19);
            truongLuong.Add(BOSS_TRUONG_LUONG_20);
            truongLuong.Add(BOSS_TRUONG_LUONG_21);
            truongLuong.Add(BOSS_TRUONG_LUONG_22);
            truongLuong.Add(BOSS_TRUONG_LUONG_23);
            truongLuong.Add(BOSS_TRUONG_LUONG_24);

            truongGiac.Add(BOSS_TRUONG_GIAC_CP);
            truongGiac.Add(BOSS_TRUONG_GIAC_1);
            truongGiac.Add(BOSS_TRUONG_GIAC_2);
            truongGiac.Add(BOSS_TRUONG_GIAC_3);
            truongGiac.Add(BOSS_TRUONG_GIAC_4);
            truongGiac.Add(BOSS_TRUONG_GIAC_5);
            truongGiac.Add(BOSS_TRUONG_GIAC_6);
            truongGiac.Add(BOSS_TRUONG_GIAC_7);
            truongGiac.Add(BOSS_TRUONG_GIAC_8);
            truongGiac.Add(BOSS_TRUONG_GIAC_9);
            truongGiac.Add(BOSS_TRUONG_GIAC_10);
            truongGiac.Add(BOSS_TRUONG_GIAC_11);
            truongGiac.Add(BOSS_TRUONG_GIAC_12);
            truongGiac.Add(BOSS_TRUONG_GIAC_13);
            truongGiac.Add(BOSS_TRUONG_GIAC_14);
            truongGiac.Add(BOSS_TRUONG_GIAC_15);
            truongGiac.Add(BOSS_TRUONG_GIAC_16);
            truongGiac.Add(BOSS_TRUONG_GIAC_17);
            truongGiac.Add(BOSS_TRUONG_GIAC_18);
            truongGiac.Add(BOSS_TRUONG_GIAC_19);
            truongGiac.Add(BOSS_TRUONG_GIAC_20);
            truongGiac.Add(BOSS_TRUONG_GIAC_21);
            truongGiac.Add(BOSS_TRUONG_GIAC_22);
            truongGiac.Add(BOSS_TRUONG_GIAC_23);
            truongGiac.Add(BOSS_TRUONG_GIAC_24);

            truongBao.Add(BOSS_TRUONG_BAO_CP);
            truongBao.Add(BOSS_TRUONG_BAO_1);
            truongBao.Add(BOSS_TRUONG_BAO_2);
            truongBao.Add(BOSS_TRUONG_BAO_3);
            truongBao.Add(BOSS_TRUONG_BAO_4);
            truongBao.Add(BOSS_TRUONG_BAO_5);
            truongBao.Add(BOSS_TRUONG_BAO_6);
            truongBao.Add(BOSS_TRUONG_BAO_7);
            truongBao.Add(BOSS_TRUONG_BAO_8);
            truongBao.Add(BOSS_TRUONG_BAO_9);
            truongBao.Add(BOSS_TRUONG_BAO_10);
            truongBao.Add(BOSS_TRUONG_BAO_11);
            truongBao.Add(BOSS_TRUONG_BAO_12);
            truongBao.Add(BOSS_TRUONG_BAO_13);
            truongBao.Add(BOSS_TRUONG_BAO_14);
            truongBao.Add(BOSS_TRUONG_BAO_15);
            truongBao.Add(BOSS_TRUONG_BAO_16);
            truongBao.Add(BOSS_TRUONG_BAO_17);
            truongBao.Add(BOSS_TRUONG_BAO_18);
            truongBao.Add(BOSS_TRUONG_BAO_19);
            truongBao.Add(BOSS_TRUONG_BAO_20);
            truongBao.Add(BOSS_TRUONG_BAO_21);
            truongBao.Add(BOSS_TRUONG_BAO_22);
            truongBao.Add(BOSS_TRUONG_BAO_23);
            truongBao.Add(BOSS_TRUONG_BAO_24);

            luuBieu.Add(BOSS_LUU_BIEU_CP);
            luuBieu.Add(BOSS_LUU_BIEU_1);
            luuBieu.Add(BOSS_LUU_BIEU_2);
            luuBieu.Add(BOSS_LUU_BIEU_3);
            luuBieu.Add(BOSS_LUU_BIEU_4);
            luuBieu.Add(BOSS_LUU_BIEU_5);
            luuBieu.Add(BOSS_LUU_BIEU_6);
            luuBieu.Add(BOSS_LUU_BIEU_7);
            luuBieu.Add(BOSS_LUU_BIEU_8);
            luuBieu.Add(BOSS_LUU_BIEU_9);
            luuBieu.Add(BOSS_LUU_BIEU_10);
            luuBieu.Add(BOSS_LUU_BIEU_11);
            luuBieu.Add(BOSS_LUU_BIEU_12);
            luuBieu.Add(BOSS_LUU_BIEU_13);
            luuBieu.Add(BOSS_LUU_BIEU_14);
            luuBieu.Add(BOSS_LUU_BIEU_15);
            luuBieu.Add(BOSS_LUU_BIEU_16);
            luuBieu.Add(BOSS_LUU_BIEU_17);
            luuBieu.Add(BOSS_LUU_BIEU_18);
            luuBieu.Add(BOSS_LUU_BIEU_19);
            luuBieu.Add(BOSS_LUU_BIEU_20);
            luuBieu.Add(BOSS_LUU_BIEU_21);
            luuBieu.Add(BOSS_LUU_BIEU_22);
            luuBieu.Add(BOSS_LUU_BIEU_23);
            luuBieu.Add(BOSS_LUU_BIEU_24);

            congTon.Add(BOSS_CONG_TON_CP);
            congTon.Add(BOSS_CONG_TON_1);
            congTon.Add(BOSS_CONG_TON_2);
            congTon.Add(BOSS_CONG_TON_3);
            congTon.Add(BOSS_CONG_TON_4);
            congTon.Add(BOSS_CONG_TON_5);
            congTon.Add(BOSS_CONG_TON_6);
            congTon.Add(BOSS_CONG_TON_7);
            congTon.Add(BOSS_CONG_TON_8);
            congTon.Add(BOSS_CONG_TON_9);
            congTon.Add(BOSS_CONG_TON_10);
            congTon.Add(BOSS_CONG_TON_11);
            congTon.Add(BOSS_CONG_TON_12);
            congTon.Add(BOSS_CONG_TON_13);
            congTon.Add(BOSS_CONG_TON_14);
            congTon.Add(BOSS_CONG_TON_15);
            congTon.Add(BOSS_CONG_TON_16);
            congTon.Add(BOSS_CONG_TON_17);
            congTon.Add(BOSS_CONG_TON_18);
            congTon.Add(BOSS_CONG_TON_19);
            congTon.Add(BOSS_CONG_TON_20);
            congTon.Add(BOSS_CONG_TON_21);
            congTon.Add(BOSS_CONG_TON_22);
            congTon.Add(BOSS_CONG_TON_23);
            congTon.Add(BOSS_CONG_TON_24);

            leftLocation.Add(LEFT_LOCATION_CP);
            leftLocation.Add(LEFT_LOCATION_1);
            leftLocation.Add(LEFT_LOCATION_2);
            leftLocation.Add(LEFT_LOCATION_3);
            leftLocation.Add(LEFT_LOCATION_4);
            leftLocation.Add(LEFT_LOCATION_5);
            leftLocation.Add(LEFT_LOCATION_6);
            leftLocation.Add(LEFT_LOCATION_7);
            leftLocation.Add(LEFT_LOCATION_8);
            leftLocation.Add(LEFT_LOCATION_9);
            leftLocation.Add(LEFT_LOCATION_10);
            leftLocation.Add(LEFT_LOCATION_11);
            leftLocation.Add(LEFT_LOCATION_12);
            leftLocation.Add(LEFT_LOCATION_13);
            leftLocation.Add(LEFT_LOCATION_14);
            leftLocation.Add(LEFT_LOCATION_15);
            leftLocation.Add(LEFT_LOCATION_16);
            leftLocation.Add(LEFT_LOCATION_17);
            leftLocation.Add(LEFT_LOCATION_18);
            leftLocation.Add(LEFT_LOCATION_19);
            leftLocation.Add(LEFT_LOCATION_20);
            leftLocation.Add(LEFT_LOCATION_21);
            leftLocation.Add(LEFT_LOCATION_22);
            leftLocation.Add(LEFT_LOCATION_23);
            leftLocation.Add(LEFT_LOCATION_24);

            rightLocation.Add(RIGHT_LOCATION_CP);
            rightLocation.Add(RIGHT_LOCATION_1);
            rightLocation.Add(RIGHT_LOCATION_2);
            rightLocation.Add(RIGHT_LOCATION_3);
            rightLocation.Add(RIGHT_LOCATION_4);
            rightLocation.Add(RIGHT_LOCATION_5);
            rightLocation.Add(RIGHT_LOCATION_6);
            rightLocation.Add(RIGHT_LOCATION_7);
            rightLocation.Add(RIGHT_LOCATION_8);
            rightLocation.Add(RIGHT_LOCATION_9);
            rightLocation.Add(RIGHT_LOCATION_10);
            rightLocation.Add(RIGHT_LOCATION_11);
            rightLocation.Add(RIGHT_LOCATION_12);
            rightLocation.Add(RIGHT_LOCATION_13);
            rightLocation.Add(RIGHT_LOCATION_14);
            rightLocation.Add(RIGHT_LOCATION_15);
            rightLocation.Add(RIGHT_LOCATION_16);
            rightLocation.Add(RIGHT_LOCATION_17);
            rightLocation.Add(RIGHT_LOCATION_18);
            rightLocation.Add(RIGHT_LOCATION_19);
            rightLocation.Add(RIGHT_LOCATION_20);
            rightLocation.Add(RIGHT_LOCATION_21);
            rightLocation.Add(RIGHT_LOCATION_22);
            rightLocation.Add(RIGHT_LOCATION_23);
            rightLocation.Add(RIGHT_LOCATION_24);

            leftLocationClone.Add(LEFT_LOCATION_CLONE_CP);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_1);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_2);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_3);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_4);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_5);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_6);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_7);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_8);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_9);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_10);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_11);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_12);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_13);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_14);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_15);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_16);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_17);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_18);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_19);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_20);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_21);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_22);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_23);
            leftLocationClone.Add(LEFT_LOCATION_CLONE_24);

            rightLocationClone.Add(RIGHT_LOCATION_CLONE_CP);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_1);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_2);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_3);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_4);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_5);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_6);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_7);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_8);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_9);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_10);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_11);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_12);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_13);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_14);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_15);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_16);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_17);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_18);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_19);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_20);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_21);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_22);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_23);
            rightLocationClone.Add(RIGHT_LOCATION_CLONE_24);

            fightingList.Add(FIGHTING_CP);
            fightingList.Add(FIGHTING_1);
            fightingList.Add(FIGHTING_2);
            fightingList.Add(FIGHTING_3);
            fightingList.Add(FIGHTING_4);
            fightingList.Add(FIGHTING_5);
            fightingList.Add(FIGHTING_6);
            fightingList.Add(FIGHTING_7);
            fightingList.Add(FIGHTING_8);
            fightingList.Add(FIGHTING_9);
            fightingList.Add(FIGHTING_10);
            fightingList.Add(FIGHTING_11);
            fightingList.Add(FIGHTING_12);
            fightingList.Add(FIGHTING_13);
            fightingList.Add(FIGHTING_14);
            fightingList.Add(FIGHTING_15);
            fightingList.Add(FIGHTING_16);
            fightingList.Add(FIGHTING_17);
            fightingList.Add(FIGHTING_18);
            fightingList.Add(FIGHTING_19);
            fightingList.Add(FIGHTING_20);
            fightingList.Add(FIGHTING_21);
            fightingList.Add(FIGHTING_22);
            fightingList.Add(FIGHTING_23);
            fightingList.Add(FIGHTING_24);

            isFightList.Add(IS_FIGHT_CP);
            isFightList.Add(IS_FIGHT_1);
            isFightList.Add(IS_FIGHT_2);
            isFightList.Add(IS_FIGHT_3);
            isFightList.Add(IS_FIGHT_4);
            isFightList.Add(IS_FIGHT_5);
            isFightList.Add(IS_FIGHT_6);
            isFightList.Add(IS_FIGHT_7);
            isFightList.Add(IS_FIGHT_8);
            isFightList.Add(IS_FIGHT_9);
            isFightList.Add(IS_FIGHT_10);
            isFightList.Add(IS_FIGHT_11);
            isFightList.Add(IS_FIGHT_12);
            isFightList.Add(IS_FIGHT_13);
            isFightList.Add(IS_FIGHT_14);
            isFightList.Add(IS_FIGHT_15);
            isFightList.Add(IS_FIGHT_16);
            isFightList.Add(IS_FIGHT_17);
            isFightList.Add(IS_FIGHT_18);
            isFightList.Add(IS_FIGHT_19);
            isFightList.Add(IS_FIGHT_20);
            isFightList.Add(IS_FIGHT_21);
            isFightList.Add(IS_FIGHT_22);
            isFightList.Add(IS_FIGHT_23);
            isFightList.Add(IS_FIGHT_24);

            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_CP);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_1);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_2);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_3);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_4);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_5);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_6);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_7);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_8);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_9);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_10);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_11);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_12);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_13);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_14);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_15);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_16);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_17);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_18);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_19);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_20);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_21);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_22);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_23);
            truongLuongFightingList.Add(TRUONG_LUONG_FIGHTING_24);

            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_CP);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_1);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_2);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_3);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_4);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_5);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_6);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_7);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_8);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_9);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_10);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_11);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_12);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_13);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_14);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_15);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_16);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_17);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_18);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_19);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_20);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_21);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_22);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_23);
            truongGiacFightingList.Add(TRUONG_GIAC_FIGHTING_24);

            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_CP);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_1);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_2);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_3);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_4);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_5);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_6);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_7);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_8);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_9);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_10);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_11);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_12);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_13);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_14);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_15);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_16);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_17);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_18);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_19);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_20);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_21);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_22);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_23);
            truongBaoFightingList.Add(TRUONG_BAO_FIGHTING_24);

            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_CP);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_1);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_2);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_3);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_4);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_5);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_6);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_7);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_8);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_9);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_10);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_11);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_12);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_13);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_14);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_15);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_16);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_17);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_18);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_19);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_20);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_21);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_22);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_23);
            luuBieuFightingList.Add(LUU_BIEU_FIGHTING_24);

            congTonFightingList.Add(CONG_TON_FIGHTING_CP);
            congTonFightingList.Add(CONG_TON_FIGHTING_1);
            congTonFightingList.Add(CONG_TON_FIGHTING_2);
            congTonFightingList.Add(CONG_TON_FIGHTING_3);
            congTonFightingList.Add(CONG_TON_FIGHTING_4);
            congTonFightingList.Add(CONG_TON_FIGHTING_5);
            congTonFightingList.Add(CONG_TON_FIGHTING_6);
            congTonFightingList.Add(CONG_TON_FIGHTING_7);
            congTonFightingList.Add(CONG_TON_FIGHTING_8);
            congTonFightingList.Add(CONG_TON_FIGHTING_9);
            congTonFightingList.Add(CONG_TON_FIGHTING_10);
            congTonFightingList.Add(CONG_TON_FIGHTING_11);
            congTonFightingList.Add(CONG_TON_FIGHTING_12);
            congTonFightingList.Add(CONG_TON_FIGHTING_13);
            congTonFightingList.Add(CONG_TON_FIGHTING_14);
            congTonFightingList.Add(CONG_TON_FIGHTING_15);
            congTonFightingList.Add(CONG_TON_FIGHTING_16);
            congTonFightingList.Add(CONG_TON_FIGHTING_17);
            congTonFightingList.Add(CONG_TON_FIGHTING_18);
            congTonFightingList.Add(CONG_TON_FIGHTING_19);
            congTonFightingList.Add(CONG_TON_FIGHTING_20);
            congTonFightingList.Add(CONG_TON_FIGHTING_21);
            congTonFightingList.Add(CONG_TON_FIGHTING_22);
            congTonFightingList.Add(CONG_TON_FIGHTING_23);
            congTonFightingList.Add(CONG_TON_FIGHTING_24);

            location1List.Add(LOCATION1_CP);
            location1List.Add(LOCATION1_1);
            location1List.Add(LOCATION1_2);
            location1List.Add(LOCATION1_3);
            location1List.Add(LOCATION1_4);
            location1List.Add(LOCATION1_5);
            location1List.Add(LOCATION1_6);
            location1List.Add(LOCATION1_7);
            location1List.Add(LOCATION1_8);
            location1List.Add(LOCATION1_9);
            location1List.Add(LOCATION1_10);
            location1List.Add(LOCATION1_11);
            location1List.Add(LOCATION1_12);
            location1List.Add(LOCATION1_13);
            location1List.Add(LOCATION1_14);
            location1List.Add(LOCATION1_15);
            location1List.Add(LOCATION1_16);
            location1List.Add(LOCATION1_17);
            location1List.Add(LOCATION1_18);
            location1List.Add(LOCATION1_19);
            location1List.Add(LOCATION1_20);
            location1List.Add(LOCATION1_21);
            location1List.Add(LOCATION1_22);
            location1List.Add(LOCATION1_23);
            location1List.Add(LOCATION1_24);

            location2List.Add(LOCATION2_CP);
            location2List.Add(LOCATION2_1);
            location2List.Add(LOCATION2_2);
            location2List.Add(LOCATION2_3);
            location2List.Add(LOCATION2_4);
            location2List.Add(LOCATION2_5);
            location2List.Add(LOCATION2_6);
            location2List.Add(LOCATION2_7);
            location2List.Add(LOCATION2_8);
            location2List.Add(LOCATION2_9);
            location2List.Add(LOCATION2_10);
            location2List.Add(LOCATION2_11);
            location2List.Add(LOCATION2_12);
            location2List.Add(LOCATION2_13);
            location2List.Add(LOCATION2_14);
            location2List.Add(LOCATION2_15);
            location2List.Add(LOCATION2_16);
            location2List.Add(LOCATION2_17);
            location2List.Add(LOCATION2_18);
            location2List.Add(LOCATION2_19);
            location2List.Add(LOCATION2_20);
            location2List.Add(LOCATION2_21);
            location2List.Add(LOCATION2_22);
            location2List.Add(LOCATION2_23);
            location2List.Add(LOCATION2_24);

            location3List.Add(LOCATION3_CP);
            location3List.Add(LOCATION3_1);
            location3List.Add(LOCATION3_2);
            location3List.Add(LOCATION3_3);
            location3List.Add(LOCATION3_4);
            location3List.Add(LOCATION3_5);
            location3List.Add(LOCATION3_6);
            location3List.Add(LOCATION3_7);
            location3List.Add(LOCATION3_8);
            location3List.Add(LOCATION3_9);
            location3List.Add(LOCATION3_10);
            location3List.Add(LOCATION3_11);
            location3List.Add(LOCATION3_12);
            location3List.Add(LOCATION3_13);
            location3List.Add(LOCATION3_14);
            location3List.Add(LOCATION3_15);
            location3List.Add(LOCATION3_16);
            location3List.Add(LOCATION3_17);
            location3List.Add(LOCATION3_18);
            location3List.Add(LOCATION3_19);
            location3List.Add(LOCATION3_20);
            location3List.Add(LOCATION3_21);
            location3List.Add(LOCATION3_22);
            location3List.Add(LOCATION3_23);
            location3List.Add(LOCATION3_24);

            location4List.Add(LOCATION4_CP);
            location4List.Add(LOCATION4_1);
            location4List.Add(LOCATION4_2);
            location4List.Add(LOCATION4_3);
            location4List.Add(LOCATION4_4);
            location4List.Add(LOCATION4_5);
            location4List.Add(LOCATION4_6);
            location4List.Add(LOCATION4_7);
            location4List.Add(LOCATION4_8);
            location4List.Add(LOCATION4_9);
            location4List.Add(LOCATION4_10);
            location4List.Add(LOCATION4_11);
            location4List.Add(LOCATION4_12);
            location4List.Add(LOCATION4_13);
            location4List.Add(LOCATION4_14);
            location4List.Add(LOCATION4_15);
            location4List.Add(LOCATION4_16);
            location4List.Add(LOCATION4_17);
            location4List.Add(LOCATION4_18);
            location4List.Add(LOCATION4_19);
            location4List.Add(LOCATION4_20);
            location4List.Add(LOCATION4_21);
            location4List.Add(LOCATION4_22);
            location4List.Add(LOCATION4_23);
            location4List.Add(LOCATION4_24);

            location1CloneList.Add(LOCATION1_CLONE_CP);
            location1CloneList.Add(LOCATION1_CLONE_1);
            location1CloneList.Add(LOCATION1_CLONE_2);
            location1CloneList.Add(LOCATION1_CLONE_3);
            location1CloneList.Add(LOCATION1_CLONE_4);
            location1CloneList.Add(LOCATION1_CLONE_5);
            location1CloneList.Add(LOCATION1_CLONE_6);
            location1CloneList.Add(LOCATION1_CLONE_7);
            location1CloneList.Add(LOCATION1_CLONE_8);
            location1CloneList.Add(LOCATION1_CLONE_9);
            location1CloneList.Add(LOCATION1_CLONE_10);
            location1CloneList.Add(LOCATION1_CLONE_11);
            location1CloneList.Add(LOCATION1_CLONE_12);
            location1CloneList.Add(LOCATION1_CLONE_13);
            location1CloneList.Add(LOCATION1_CLONE_14);
            location1CloneList.Add(LOCATION1_CLONE_15);
            location1CloneList.Add(LOCATION1_CLONE_16);
            location1CloneList.Add(LOCATION1_CLONE_17);
            location1CloneList.Add(LOCATION1_CLONE_18);
            location1CloneList.Add(LOCATION1_CLONE_19);
            location1CloneList.Add(LOCATION1_CLONE_20);
            location1CloneList.Add(LOCATION1_CLONE_21);
            location1CloneList.Add(LOCATION1_CLONE_22);
            location1CloneList.Add(LOCATION1_CLONE_23);
            location1CloneList.Add(LOCATION1_CLONE_24);

            location2CloneList.Add(LOCATION2_CLONE_CP);
            location2CloneList.Add(LOCATION2_CLONE_1);
            location2CloneList.Add(LOCATION2_CLONE_2);
            location2CloneList.Add(LOCATION2_CLONE_3);
            location2CloneList.Add(LOCATION2_CLONE_4);
            location2CloneList.Add(LOCATION2_CLONE_5);
            location2CloneList.Add(LOCATION2_CLONE_6);
            location2CloneList.Add(LOCATION2_CLONE_7);
            location2CloneList.Add(LOCATION2_CLONE_8);
            location2CloneList.Add(LOCATION2_CLONE_9);
            location2CloneList.Add(LOCATION2_CLONE_10);
            location2CloneList.Add(LOCATION2_CLONE_11);
            location2CloneList.Add(LOCATION2_CLONE_12);
            location2CloneList.Add(LOCATION2_CLONE_13);
            location2CloneList.Add(LOCATION2_CLONE_14);
            location2CloneList.Add(LOCATION2_CLONE_15);
            location2CloneList.Add(LOCATION2_CLONE_16);
            location2CloneList.Add(LOCATION2_CLONE_17);
            location2CloneList.Add(LOCATION2_CLONE_18);
            location2CloneList.Add(LOCATION2_CLONE_19);
            location2CloneList.Add(LOCATION2_CLONE_20);
            location2CloneList.Add(LOCATION2_CLONE_21);
            location2CloneList.Add(LOCATION2_CLONE_22);
            location2CloneList.Add(LOCATION2_CLONE_23);
            location2CloneList.Add(LOCATION2_CLONE_24);

            location3CloneList.Add(LOCATION3_CLONE_CP);
            location3CloneList.Add(LOCATION3_CLONE_1);
            location3CloneList.Add(LOCATION3_CLONE_2);
            location3CloneList.Add(LOCATION3_CLONE_3);
            location3CloneList.Add(LOCATION3_CLONE_4);
            location3CloneList.Add(LOCATION3_CLONE_5);
            location3CloneList.Add(LOCATION3_CLONE_6);
            location3CloneList.Add(LOCATION3_CLONE_7);
            location3CloneList.Add(LOCATION3_CLONE_8);
            location3CloneList.Add(LOCATION3_CLONE_9);
            location3CloneList.Add(LOCATION3_CLONE_10);
            location3CloneList.Add(LOCATION3_CLONE_11);
            location3CloneList.Add(LOCATION3_CLONE_12);
            location3CloneList.Add(LOCATION3_CLONE_13);
            location3CloneList.Add(LOCATION3_CLONE_14);
            location3CloneList.Add(LOCATION3_CLONE_15);
            location3CloneList.Add(LOCATION3_CLONE_16);
            location3CloneList.Add(LOCATION3_CLONE_17);
            location3CloneList.Add(LOCATION3_CLONE_18);
            location3CloneList.Add(LOCATION3_CLONE_19);
            location3CloneList.Add(LOCATION3_CLONE_20);
            location3CloneList.Add(LOCATION3_CLONE_21);
            location3CloneList.Add(LOCATION3_CLONE_22);
            location3CloneList.Add(LOCATION3_CLONE_23);
            location3CloneList.Add(LOCATION3_CLONE_24);

            location4CloneList.Add(LOCATION4_CLONE_CP);
            location4CloneList.Add(LOCATION4_CLONE_1);
            location4CloneList.Add(LOCATION4_CLONE_2);
            location4CloneList.Add(LOCATION4_CLONE_3);
            location4CloneList.Add(LOCATION4_CLONE_4);
            location4CloneList.Add(LOCATION4_CLONE_5);
            location4CloneList.Add(LOCATION4_CLONE_6);
            location4CloneList.Add(LOCATION4_CLONE_7);
            location4CloneList.Add(LOCATION4_CLONE_8);
            location4CloneList.Add(LOCATION4_CLONE_9);
            location4CloneList.Add(LOCATION4_CLONE_10);
            location4CloneList.Add(LOCATION4_CLONE_11);
            location4CloneList.Add(LOCATION4_CLONE_12);
            location4CloneList.Add(LOCATION4_CLONE_13);
            location4CloneList.Add(LOCATION4_CLONE_14);
            location4CloneList.Add(LOCATION4_CLONE_15);
            location4CloneList.Add(LOCATION4_CLONE_16);
            location4CloneList.Add(LOCATION4_CLONE_17);
            location4CloneList.Add(LOCATION4_CLONE_18);
            location4CloneList.Add(LOCATION4_CLONE_19);
            location4CloneList.Add(LOCATION4_CLONE_20);
            location4CloneList.Add(LOCATION4_CLONE_21);
            location4CloneList.Add(LOCATION4_CLONE_22);
            location4CloneList.Add(LOCATION4_CLONE_23);
            location4CloneList.Add(LOCATION4_CLONE_24);
        }


        void Delay(int delay)
        {
                while(delay > 0)
                {
                    Thread.Sleep(TimeSpan.FromMilliseconds(1));
                    delay--;
                    //if (isStop[index])
                    //    break;
                }
        }

        void goTo(string deviceID, int index, int tuyen, Bitmap LOCATION, bool isDone, int xLocation, int yLocation, List<Bitmap> bossList, List<Bitmap> listFighting)
        {
            if (isStop[index])
                return;
            Bitmap BOSS_TRUONG_NHUONG = bossList[index];
            Bitmap FIGHTING = listFighting[index];
            Bitmap IS_FIGHT = isFightList[index];
            /*----------Tuyến 1--------------------------*/
            //go to location
            //KAutoHelper.ADBHelper.Tap(deviceID, xLocation, yLocation);
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //Delay(50);
            if (isStop[index])
                return;
            var truong_nhuong = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOSS_TRUONG_NHUONG, 0.7);
            var fighting = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, FIGHTING, 0.7);
            //Tìm trương nhượng
            if (truong_nhuong != null)
            {
                if(fighting == null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, truong_nhuong.Value.X, truong_nhuong.Value.Y);
                    //System.Diagnostics.Debug.WriteLine($"Clicked boss lúc vừa chạy {xLocation}, {yLocation}");
                    Delay(delayLong);
                    if (isStop[index])
                        return;
                } 
            }
            while (truong_nhuong == null)
            {
                if (isStop[index])
                    return;
                //go to location
                KAutoHelper.ADBHelper.Tap(deviceID, xLocation, yLocation);
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                Delay(50);
                if (isStop[index])
                    return;
                truong_nhuong = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOSS_TRUONG_NHUONG, 0.7);

                if (truong_nhuong != null)
                {
                    if (isStop[index])
                        return;
                    KAutoHelper.ADBHelper.Tap(deviceID, truong_nhuong.Value.X, truong_nhuong.Value.Y);
                    //System.Diagnostics.Debug.WriteLine($"Click boss lúc đang chạy");
                    Delay(delayLong);
                    if (isStop[index])
                        return;
                    //    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    //truong_nhuong = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOSS_TRUONG_NHUONG, 0.7);
                    break;
                }
                else
                {
                    if (isStop[index])
                        return;
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                    Delay(50);
                    if (isStop[index])
                        return;
                    var leftLocation = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, LOCATION);
                    
                    if (leftLocation != null)
                    {
                        if (isStop[index])
                            return;
                        if (isDone)
                        {
                            //chuyển tuyến
                            KAutoHelper.ADBHelper.Tap(deviceID, 1129, 705);
                            Delay(delayLong);
                            if (isStop[index])
                                return;
                            //chuyển tuyến {tuyen + 1}
                            if (tuyen == 1)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 583, 291);
                            }
                            if (tuyen == 2)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 580, 347);
                            }
                            if (tuyen == 3)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 599, 390);
                            }
                            if (tuyen == 4)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 599, 436);
                            }
                            if (tuyen == 5)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 599, 476);
                            }
                            if (tuyen == 6)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 588, 527);
                            }
                            if (tuyen == 7)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 637, 554);
                            }
                            if (tuyen == 8)
                            {
                                //Swipe lên đầu phát 1
                                KAutoHelper.ADBHelper.Swipe(deviceID, 637, 196, 621, 533, 500);
                                Delay(delayLong);
                                if (isStop[index])
                                    return;
                                KAutoHelper.ADBHelper.Tap(deviceID, 605, 207);
                            }
                            Delay(delayLong);
                            if (isStop[index])
                                return;
                            //đổi tuyến
                            KAutoHelper.ADBHelper.Tap(deviceID, 631, 608);
                            Delay(delayLong);
                            if (isStop[index])
                                return;
                            //xác nhận
                            KAutoHelper.ADBHelper.Tap(deviceID, 527, 390);
                            Delay(3000);
                            if (isStop[index])
                                return;
                            break;
                        } else
                        {
                            //for (int i = 0; i < 2; i++)
                            //{
                                //System.Diagnostics.Debug.WriteLine($"Chạy vào vòng lặp thứ {i}");
                                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                                //Delay(50);
                                if (isStop[index])
                                    return;
                                truong_nhuong = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOSS_TRUONG_NHUONG, 0.7);

                                if (truong_nhuong != null)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, truong_nhuong.Value.X, truong_nhuong.Value.Y);
                                    //System.Diagnostics.Debug.WriteLine($"Đã click boss ở vòng lặp thứ {i}");
                                    //Delay(delayLong);
                                    if (isStop[index])
                                        return;
                                    return;
                                }
                                //Delay(300);
                                if (isStop[index])
                                    return;
                            //}
                            return;
                        }
                    }
                }

                if (isStop[index])
                    return;
            }
            while (truong_nhuong != null)
            {
                if (isStop[index])
                    return;
                System.Diagnostics.Debug.WriteLine("Đang đánh boss");
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false); 
                var isFight = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, IS_FIGHT, 0.7);
                if(isFight == null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, truong_nhuong.Value.X, truong_nhuong.Value.Y);
                }
                Delay(50);
                if (isStop[index])
                    return;
                truong_nhuong = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOSS_TRUONG_NHUONG, 0.7);
                if (truong_nhuong == null)
                {
                    //System.Diagnostics.Debug.WriteLine($"Done boss tuyen {tuyen}");
                    //Tắt auto
                    KAutoHelper.ADBHelper.Tap(deviceID, 1207, 487);
                    Delay(delayLong);
                    if (isStop[index])
                        return;
                    var leftLocation = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, LOCATION);
                    
                    while (leftLocation == null)
                    {
                        //System.Diagnostics.Debug.WriteLine($"leftLocation ??? {leftLocation}");
                        //go to location
                        KAutoHelper.ADBHelper.Tap(deviceID, xLocation, yLocation);
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        leftLocation = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, LOCATION);
                        if (leftLocation != null)
                        {
                            if (isDone)
                            {
                                //chuyển tuyến
                                KAutoHelper.ADBHelper.Tap(deviceID, 1129, 705);
                                Delay(delayLong);
                                if (isStop[index])
                                    return;
                                //chuyển tuyến {tuyen + 1}
                                if (tuyen == 1)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 583, 291);
                                }
                                if (tuyen == 2)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 580, 347);
                                }
                                if (tuyen == 3)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 599, 390);
                                }
                                if (tuyen == 4)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 599, 436);
                                }
                                if (tuyen == 5)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 599, 476);
                                }
                                if (tuyen == 6)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 588, 527);
                                }
                                if (tuyen == 7)
                                {
                                    KAutoHelper.ADBHelper.Tap(deviceID, 637, 554);
                                }
                                if (tuyen == 8)
                                {
                                    //Swipe lên đầu phát 1
                                    KAutoHelper.ADBHelper.Swipe(deviceID, 637, 196, 621, 533, 500);
                                    Delay(delayLong);
                                    if (isStop[index])
                                        return;
                                    KAutoHelper.ADBHelper.Tap(deviceID, 605, 207);
                                }
                                Delay(delayLong);
                                if (isStop[index])
                                    return;
                                //đổi tuyến
                                KAutoHelper.ADBHelper.Tap(deviceID, 631, 608);
                                Delay(delayLong);
                                if (isStop[index])
                                    return;
                                //xác nhận
                                KAutoHelper.ADBHelper.Tap(deviceID, 527, 390);
                                Delay(3000);
                                if (isStop[index])
                                    return;
                                break;
                            } else
                            {
                                return;
                            }
                                
                        }
                        if (isStop[index])
                            return;
                    }
                }
                if (isStop[index])
                    return;
            }
            /*------------Hết tuyến 1--------------------*/
        }


        void pb50_boss(string deviceID, int index, List<Bitmap> bossList, List<Bitmap> listFighting, List<Bitmap> locationLeft, List<Bitmap> locationRight, List<Bitmap> location1, List<Bitmap> location2, List<Bitmap> location3, List<Bitmap> location4)
        {
            if (isStop[index])
                return;
            //System.Diagnostics.Debug.WriteLine(index);
            Bitmap LEFT_LOCATION = locationLeft[index];
            Bitmap RIGHT_LOCATION = locationRight[index];
            Bitmap LOCATION1 = location1[index];
            Bitmap LOCATION2 = location2[index];
            Bitmap LOCATION3 = location3[index];
            Bitmap LOCATION4 = location4[index];
            if (isStop[index])
                return;
            //location1
            //KAutoHelper.ADBHelper.Tap(deviceID, 677, 648);
            //location2
            //KAutoHelper.ADBHelper.Tap(deviceID, 605, 651);
            //location3
            //KAutoHelper.ADBHelper.Tap(deviceID, 693, 648);
            //location4
            //KAutoHelper.ADBHelper.Tap(deviceID, 586, 646);

            //location3 new
            //KAutoHelper.ADBHelper.Tap(deviceID, 658, 646);
            //location4 new
            //KAutoHelper.ADBHelper.Tap(deviceID, 613, 646);

            //location4 new2
            //KAutoHelper.ADBHelper.Tap(deviceID, 640, 648);


            /*----------Tuyến 1--------------------------*/
            goTo(deviceID, index, 1, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 1, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 1, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 1, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 1, LEFT_LOCATION, true, 559, 648, bossList, listFighting);
            /*------------Hết tuyến 1--------------------*/


            ///*----------Tuyến 2--------------------------*/
            goTo(deviceID, index, 2, LOCATION2 , false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 2, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 2, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 2, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 2, RIGHT_LOCATION, true, 720, 646, bossList, listFighting);
            ///*------------Hết tuyến 2--------------------*/



            ///*----------Tuyến 3--------------------------*/
            goTo(deviceID, index, 3, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 3, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 3, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 3, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 3, LEFT_LOCATION, true, 559, 648, bossList, listFighting);
            ///*------------Hết tuyến 3--------------------*/




            ///*----------Tuyến 4--------------------------*/
            goTo(deviceID, index, 4, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 4, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 4, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 4, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 4, RIGHT_LOCATION, true, 720, 646, bossList, listFighting);
            ///*------------Hết tuyến 4--------------------*/




            ///*----------Bán đồ--------------------------*/
            //Out ra thọ xuân
            KAutoHelper.ADBHelper.Tap(deviceID, 1218, 640);
            Delay(5000);
            if (isStop[index])
                return;
            //Vào khách quán
            KAutoHelper.ADBHelper.Tap(deviceID, 1046, 336);
            Delay(2000);
            if (isStop[index])
                return;
            //Sang tab bán
            KAutoHelper.ADBHelper.Tap(deviceID, 701, 110);
            Delay(500);
            if (isStop[index])
                return;
            //Bán tạp vật
            KAutoHelper.ADBHelper.Tap(deviceID, 1083, 622);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Bán nhanh
            KAutoHelper.ADBHelper.Tap(deviceID, 497, 624);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Xác nhận bán
            KAutoHelper.ADBHelper.Tap(deviceID, 532, 592);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Thoát ra ấn X
            KAutoHelper.ADBHelper.Tap(deviceID, 1229, 51);
            Delay(2000);
            if (isStop[index])
                return;
            //Ấn cờ
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            Delay(5000);
            if (isStop[index])
                return;
            //System.Diagnostics.Debug.WriteLine("Kết thúc bán đồ");
            ///*------------Hết bán đồ--------------------*/





            ///*----------Tuyến 5--------------------------*/
            goTo(deviceID, index, 5, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 5, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 5, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 5, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 5, LEFT_LOCATION, true, 559, 648, bossList, listFighting);
            ///*------------Hết tuyến 5--------------------*/





            ///*----------Tuyến 6--------------------------*/
            goTo(deviceID, index, 6, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 6, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 6, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 6, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 6, RIGHT_LOCATION, true, 720, 646, bossList, listFighting);
            ///*------------Hết tuyến 6--------------------*/




            ///*----------Tuyến 7--------------------------*/
            goTo(deviceID, index, 7, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 7, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 7, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 7, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 7, LEFT_LOCATION, true, 559, 648, bossList, listFighting);
            ///*------------Hết tuyến 7--------------------*/





            ///*----------Tuyến 8--------------------------*/
            goTo(deviceID, index, 8, LOCATION2, false, 605, 651, bossList, listFighting);
            goTo(deviceID, index, 8, LOCATION4, false, 640, 648, bossList, listFighting);
            goTo(deviceID, index, 8, LOCATION3, false, 658, 646, bossList, listFighting);
            goTo(deviceID, index, 8, LOCATION1, false, 677, 648, bossList, listFighting);
            goTo(deviceID, index, 8, RIGHT_LOCATION, true, 720, 646, bossList, listFighting);
            ///*------------Hết tuyến 8--------------------*/



            ///*----------Bán đồ--------------------------*/
            //Out ra thọ xuân
            KAutoHelper.ADBHelper.Tap(deviceID, 1218, 640);
            Delay(5000);
            if (isStop[index])
                return;
            //Vào khách quán
            KAutoHelper.ADBHelper.Tap(deviceID, 1046, 336);
            Delay(2000);
            if (isStop[index])
                return;
            //Sang tab bán
            KAutoHelper.ADBHelper.Tap(deviceID, 701, 110);
            Delay(500);
            if (isStop[index])
                return;
            //Bán tạp vật
            KAutoHelper.ADBHelper.Tap(deviceID, 1083, 622);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Bán nhanh
            KAutoHelper.ADBHelper.Tap(deviceID, 497, 624);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Xác nhận bán
            KAutoHelper.ADBHelper.Tap(deviceID, 532, 592);
            Delay(delayLong);
            if (isStop[index])
                return;
            //Thoát ra ấn X
            KAutoHelper.ADBHelper.Tap(deviceID, 1229, 51);
            Delay(2000);
            if (isStop[index])
                return;
            //Ấn cờ
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            KAutoHelper.ADBHelper.Tap(deviceID, 134, 627);
            Delay(5000);
            if (isStop[index])
                return;
            //System.Diagnostics.Debug.WriteLine("Kết thúc bán đồ");
            ///*------------Hết bán đồ--------------------*/
        }

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            
            string deviceID = (sender as Button).Tag.ToString().Split(',')[0];
            int index = Int32.Parse((sender as Button).Tag.ToString().Split(',')[1]);
            string deviceName = (sender as Button).Tag.ToString().Split(',')[2];
            string selectedValue = selectedComboBox[index];
            System.Diagnostics.Debug.WriteLine($"index: {index}");
            if (isFinish[index ] == false)
            {
                MessageBox.Show($"{deviceName} đang chạy rồi!!!");
            } else
            {
                
                //System.Diagnostics.Debug.WriteLine(deviceID);
                //System.Diagnostics.Debug.WriteLine(index);
                //System.Diagnostics.Debug.WriteLine(selectedValue);
                if (selectedValue != "")
                {
                    isStop[index] = false;
                    isFinish[index] = false;
                    Task t = new Task(() =>
                    {
                        Auto(deviceID, index, selectedValue, deviceName);
                    });
                    t.Start();
                }
                else
                {
                    MessageBox.Show($"{deviceName} chưa chọn màn");
                }
            }
            
        }

        private void Button_Click_StartAll(object sender, RoutedEventArgs e)
        {
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();


            foreach (var item in listDeviceName.Select((value, i) => (value, i)))
            {
                string deviceID = item.value;
                System.Diagnostics.Debug.WriteLine($"deviceID: {deviceID}");
                int index = item.i;

                    System.Diagnostics.Debug.WriteLine($"index: {index}");
                    string deviceName = listDeviceName[index];
                    string selectedValue = selectedComboBox[index];
                    System.Diagnostics.Debug.WriteLine($"deviceName: {deviceName}");
                    System.Diagnostics.Debug.WriteLine($"selectedValue: {selectedValue}");
                    if (isFinish[index] == false)
                    {
                        MessageBox.Show($"{deviceName} đang chạy rồi!!!");
                    }
                    else
                    {
                        //System.Diagnostics.Debug.WriteLine(deviceID);
                        //System.Diagnostics.Debug.WriteLine(index);
                        //System.Diagnostics.Debug.WriteLine(selectedValue);
                        if (selectedValue != "")
                        {
                            isStop[index] = false;
                            isFinish[index] = false;
                            Task t = new Task(() =>
                            {
                                Auto(deviceID, index, selectedValue, deviceName);
                            });
                            t.Start();
                        }
                        else
                        {
                            MessageBox.Show($"{deviceName} chưa chọn màn");
                        }
                    }
                
            }
        }

        private void Button_Click_Restart(object sender, RoutedEventArgs e)
        {
            string deviceID = (sender as Button).Tag.ToString().Split(',')[0];
            int index = Int32.Parse((sender as Button).Tag.ToString().Split(',')[1]);
            System.Diagnostics.Debug.WriteLine($"{index} restart is click");
            Button_Click_Stop(sender, e);
            while(isFinish[index] == false)
            {
                System.Diagnostics.Debug.WriteLine($"{index} is waiting to stoped");
            }
            Button_Click_Start(sender, e);
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            string deviceID = (sender as Button).Tag.ToString().Split(',')[0];
            int index = Int32.Parse((sender as Button).Tag.ToString().Split(',')[1]);
            System.Diagnostics.Debug.WriteLine($"{index} stop is click");
            isStop[index] = true;
        }

        private void Button_Click_StopAll(object sender, RoutedEventArgs e)
        {
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();


            foreach (var item in listDeviceName.Select((value, i) => (value, i)))
            {
                string deviceID = item.value;
                int index = item.i;
                System.Diagnostics.Debug.WriteLine($"{index} stop is click");
                isStop[index] = true;
            }
        }

        void Auto(string deviceID, int index, string selectedValue, string deviceName)
        {
                Task t = new Task(() =>
                {
                    System.Diagnostics.Debug.WriteLine("Start");
                    if (selectedValue == "truongNhuong")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, truongNhuong, fightingList, leftLocation, rightLocation, location1List, location2List, location3List, location4List);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }
                    if (selectedValue == "truongLuong")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, truongLuong, truongLuongFightingList, leftLocation, rightLocation, location1List, location2List, location3List, location4List);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }
                    if (selectedValue == "truongGiac")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, truongGiac, truongGiacFightingList, leftLocation, rightLocation, location1List, location2List, location3List, location4List);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }

                    if (selectedValue == "truongBao")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, truongBao, truongBaoFightingList, leftLocationClone, rightLocationClone, location1CloneList, location2CloneList, location3CloneList, location4CloneList);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }

                    if (selectedValue == "luuBieu")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, luuBieu, luuBieuFightingList, leftLocation, rightLocation, location1List, location2List, location3List, location4List);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index ] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }

                    if (selectedValue == "congTon")
                    {
                        while (true)
                        {
                            System.Diagnostics.Debug.WriteLine($"{deviceID} is running");
                            pb50_boss(deviceID, index, congTon, congTonFightingList, leftLocation, rightLocation, location1List, location2List, location3List, location4List);
                            Delay(2000);
                            if (isStop[index])
                            {
                                isFinish[index] = true;
                                System.Diagnostics.Debug.WriteLine($"{deviceID} is stoped");
                                MessageBox.Show($"{deviceName} đã dừng!!! ");
                                break;
                            }
                        }
                    }

                });
                t.Start();
        }


        ////MEMU
        //private void Button_Click_Connect(object sender, RoutedEventArgs e)
        //{
        //    System.Diagnostics.Process p = new System.Diagnostics.Process();
        //    p.StartInfo.UseShellExecute = false;
        //    p.StartInfo.RedirectStandardOutput = true;
        //    p.StartInfo.FileName = "cmd.exe";
        //    p.StartInfo.Arguments = "/C memuc listvms -r";
        //    //p.StartInfo.Arguments = "/C adb connect localhost:21523";
        //    p.Start();

        //    string output = p.StandardOutput.ReadToEnd();
        //    p.WaitForExit();
        //    System.Diagnostics.Debug.WriteLine($"Current devices: {output}");
        //    string[] arrListStr = output.Split('\n');

        //    //Đoạn này để cmd ko bị treo
        //    p.StartInfo.Arguments = $"/C adb devices";
        //    p.Start();
        //    p.WaitForExit();
        //    for (int i = 0; i < arrListStr.Length -2; i++)
        //    {
        //        System.Diagnostics.Debug.WriteLine($"Length: {arrListStr.Length}");
        //        if (arrListStr[i].Length > 0)
        //        {
        //            string currentDeviceInfo = arrListStr[i].Split(',')[0];
        //            System.Diagnostics.Debug.WriteLine($"currentDeviceInfo {currentDeviceInfo}");
        //                if (Int32.Parse(currentDeviceInfo) >= 0)
        //                {
        //                    int adbHost = 50 + Int32.Parse(currentDeviceInfo);
        //                    p.StartInfo.Arguments = $"/C adb connect 127.0.0.1:21{adbHost}3";
        //                    p.Start();

        //                    output = p.StandardOutput.ReadToEnd();
        //                    p.WaitForExit();
        //                    System.Diagnostics.Debug.WriteLine(output);
        //                    MessageBox.Show(output, "Connect devices");
        //                }
        //        }
        //    }
        //    List<Device> nameList = new List<Device>();
        //    List<Dropdown> dropdownList = new List<Dropdown>();
        //    List<ButtonCustom> startList = new List<ButtonCustom>();
        //    List<ButtonCustom> restartList = new List<ButtonCustom>();
        //    List<ButtonCustom> stopList = new List<ButtonCustom>();

        //    List<string> devices = new List<string>();
        //    devices = KAutoHelper.ADBHelper.GetDevices();
        //    listName = new List<Stage>() {
        //        new Stage(){Name="Boss Trương Nhượng", Value="truongNhuong" },
        //        new Stage(){Name="Boss Trương Lương", Value="truongLuong" },
        //        new Stage(){Name="Boss Trương Giác", Value="truongGiac" },
        //        new Stage(){Name="Boss Trương Bảo", Value="truongBao" },
        //       };
        //    foreach (var item in devices.Select((value, i) => (value, i)))
        //    {
        //        selectedComboBox.Add("");
        //        isStop.Add(false);
        //        isFinish.Add(true);

        //        string deviceID = item.value;
        //        int index = item.i + 1;
        //        System.Diagnostics.Debug.WriteLine($"Length: {arrListStr.Length}");
        //        if (arrListStr[item.i].Length > 0)
        //        {
        //            string currentDeviceInfo = arrListStr[item.i].Split(',')[1];
        //            listDeviceName.Add(currentDeviceInfo);
        //            nameList.Add(new Device { DeviceContent = currentDeviceInfo, DeviceID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
        //            dropdownList.Add(new Dropdown { DropdownContent = listName, DropdownID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
        //            startList.Add(new ButtonCustom { ButtonContent = $"Start", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
        //            restartList.Add(new ButtonCustom { ButtonContent = $"Restart", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
        //            stopList.Add(new ButtonCustom { ButtonContent = $"Stop", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
        //        }
        //    }

        //    name.ItemsSource = nameList;
        //    map.ItemsSource = dropdownList;
        //    start.ItemsSource = startList;
        //    restart.ItemsSource = restartList;
        //    stop.ItemsSource = stopList;

        //}


        //BLUESTACK
        private void Button_Click_Connect(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";

            //Đoạn này để cmd ko bị treo
            p.StartInfo.Arguments = $"/C netstat -aon | find /i \"listening\"";
            p.Start();
            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            //System.Diagnostics.Debug.WriteLine($"Current devices: {output}");
            string[] arrListStr = output.Split('\n');
            for (int i = 0; i < arrListStr.Length; i++)
            {
                if(arrListStr[i].Contains("127.0.0.1:5"))
                {
                    string subString = arrListStr[i].Substring(9, 15);
                    int port = Int32.Parse(arrListStr[i].Substring(19, 4));
                    if(port > 5554 &&  port < 5800)
                    {
                        //System.Diagnostics.Debug.WriteLine($"{port}");
                        //System.Diagnostics.Debug.WriteLine($"{subString}");
                        p.StartInfo.Arguments = $"/C adb connect {subString}";
                        p.Start();

                        output = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        //System.Diagnostics.Debug.WriteLine(output);
                        MessageBox.Show(output, "Connect devices");
                    }
                    //System.Diagnostics.Debug.WriteLine($"{arrListStr[i]}");
                }
            }
            ////Đoạn này để cmd ko bị treo
            //p.StartInfo.Arguments = $"/C adb devices";
            //p.Start();

            //p.WaitForExit();
            //string output = p.StandardOutput.ReadToEnd();
            //System.Diagnostics.Debug.WriteLine($"Current devices: {output}");

            /*-----------------------------MEMU--------------------------*/

            p.StartInfo.Arguments = "/C memuc listvms -r";
            //p.StartInfo.Arguments = "/C adb connect localhost:21523";
            p.Start();

            output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            System.Diagnostics.Debug.WriteLine($"Current devices: {output}");
            string[] arrListStrMemu = output.Split('\n');

            //Đoạn này để cmd ko bị treo
            p.StartInfo.Arguments = $"/C adb devices";
            p.Start();
            p.WaitForExit();
            for (int i = 0; i < arrListStrMemu.Length - 2; i++)
            {
                //System.Diagnostics.Debug.WriteLine($"Length: {arrListStrMemu.Length}");
                if (arrListStrMemu[i].Length > 0)
                {
                    string currentDeviceInfo = arrListStrMemu[i].Split(',')[0];
                    //System.Diagnostics.Debug.WriteLine($"currentDeviceInfo {currentDeviceInfo}");
                    if (Int32.Parse(currentDeviceInfo) >= 0)
                    {
                        int adbHost = 50 + Int32.Parse(currentDeviceInfo);
                        p.StartInfo.Arguments = $"/C adb connect 127.0.0.1:21{adbHost}3";
                        p.Start();

                        output = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        System.Diagnostics.Debug.WriteLine(output);
                        MessageBox.Show(output, "Connect devices");
                    }
                }
            }

            /*-----------------------------END MEMU--------------------------*/










            List<Device> nameList = new List<Device>();
            List<Dropdown> dropdownList = new List<Dropdown>();
            List<ButtonCustom> startList = new List<ButtonCustom>();
            List<ButtonCustom> restartList = new List<ButtonCustom>();
            List<ButtonCustom> stopList = new List<ButtonCustom>();

            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();
            List<string> activeDevices = new List<string>();
            foreach (var item in devices.Select((value, i) => (value, i)))
            {
                string deviceID = item.value;
                if (deviceID.Contains("127.0.0.1:5") || deviceID.Contains("127.0.0.1:21"))
                {
                    activeDevices.Add(deviceID);
                }
            }
                    listName = new List<Stage>() {
                        new Stage(){Name="Boss Trương Nhượng", Value="truongNhuong" },
                        new Stage(){Name="Boss Trương Lương", Value="truongLuong" },
                        new Stage(){Name="Boss Trương Giác", Value="truongGiac" },
                        new Stage(){Name="Boss Trương Bảo", Value="truongBao" },
                        new Stage(){Name="Boss Lưu Biểu", Value="luuBieu" },
                        new Stage(){Name="Boss Công Tôn Toản", Value="congTon" },
                       };
            foreach (var item in activeDevices.Select((value, i) => (value, i)))
            {
                    string deviceID = item.value;
                    int index = item.i;
                    selectedComboBox.Add("");
                    isStop.Add(false);
                    isFinish.Add(true);
                    string currentDeviceInfo = deviceID.ToString();
                    System.Diagnostics.Debug.WriteLine($"currentDeviceInfo {currentDeviceInfo}");
                    listDeviceName.Add(currentDeviceInfo);
                    nameList.Add(new Device { DeviceContent = currentDeviceInfo, DeviceID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
                    dropdownList.Add(new Dropdown { DropdownContent = listName, DropdownID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
                    startList.Add(new ButtonCustom { ButtonContent = $"Start", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
                    restartList.Add(new ButtonCustom { ButtonContent = $"Restart", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
                    stopList.Add(new ButtonCustom { ButtonContent = $"Stop", ButtonID = $"{deviceID.ToString()},{index},{currentDeviceInfo}" });
            }

            name.ItemsSource = nameList;
            map.ItemsSource = dropdownList;
            start.ItemsSource = startList;
            restart.ItemsSource = restartList;
            stop.ItemsSource = stopList;

        }
    }
}
